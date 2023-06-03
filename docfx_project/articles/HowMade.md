# How This Site is Made
This site is the direct result of necessity, ingenuity, perseverence, and curiosity. Apparently, with enough of those four ingedients you can do just about anything...

OK, seriously. There are only two ways a site like this is possible. First, and this would be our strong preference, if there is support for modding and the game developers were to make their XML docs available, then making a site like this largely comes down to processing a stripped version of the DLL in conjunction with the XML docs - and Bingo! you have a site far better than this! Sadly, that's not the story of this site...

Fortunately, there's another way to get a site like this - exactly like this, in fact - and it doesn't require the game developers to share their XML documentation. Instead the basic process is this.

1. **Produce a Stripped DLL**. Using the Assembly-CSharp.dll that ships with the game it's possible to produce a stripped version of the original in which all the internal code has been removed leaving only the external interface the DLL exposes naturally. There are a number of tools that can be used for this. We chose to use the [BepInEx Publicizer](https://github.com/BepInEx/BepInEx.AssemblyPublicizer) (assembly-publicizer), and we used it like this.
```
dotnet tool install -g BepInEx.AssemblyPublicizer.Cli
assembly-publicizer ./Assembly-CSharp.dll --strip-only
```
2. **Produce a Stripped Project**. Using the stripped version of the Assembly-CSharp.dll generated in Step 1 it's possible to create a C# project from that DLL. This is the step that produces the initial set of .cs files to which we may manually add triple slash (///) comments. There are several ways to do this, one being to load the stripped DLL into [JetBrains dotPeek](https://www.jetbrains.com/decompiler/) and use that tool to create a new Visual Studio project. **NOTE**: As the input is a *stripped DLL*, we're not in fact decompiling the game, and thus the output does not contain any actual internal game code. What we do capture are namespaces, method interfaces, class definitions, etc. Everything we need for the API documentation and nothing we're forbidden from sharing.
3. **Generate an XML Documentation File**. Using the stripped project generated in Step 2 it's possible to produce an Assembly-CSharp.xml file that is useful both for intellisence documentation for modding, and as an input to DocFX to supply the unofficial comments to go with the stripped DLL. This can be done using a variety of methods, one being [GenDoc](https://github.com/jan-bures/GenDoc), which is an open source Roslyn API tool that can open a .sln file you point it to, and for each project that's in it, it goes through all the types and members and generates their XML documentation into a file per project.
GenDoc is called from the command line and takes two arguments, the path to the .sln file and the output folder in which to deposit the resulting XML files. In this case there will be just one XML file, Assembly-CSharp.xml, and we want it to be located in the same folder along with the stripped version of Assembly-CSharp.dll. Here is the command used to do this which looks for the stripped project form Step 2 in the src_stripped folder and will place the resulting Assembly-CSharp.xml file in the DLL_stripped folder. The any of the stripped .cs files have been modified to include documentation generating comments (///), then those will be captured in the Assembly-CSharp.xml file.
```
GenDoc src_stripped\Assembly-CSharp_stripped.sln DLL_Stripped
```
4. **Generate DocFX API Documentation Site**. Using the stripped DLL from Step 1 and the resulting XMl from Step 3, it's possible to generate useful API documentation using [DocFX](https://dotnet.github.io/docfx/index.html). This process requires 4 sub steps. 1. Install DocFx, 2. Build a docfx_project, 3. Edit the docfx.json file, and 4. Generate the DocFX site files. The first two steps are as follows.
```
dotnet tool update -g docfx
docfx init --quiet
```
This creates a docfx_project folder with a number of files in it, one of which will be docfx.json. Defore building the DocFX site files this file needs to be edited. Here's a copy of the version we've used which has worked.
```json
{
  "metadata": [
    {
      "src": [
        {
          "files": ["Assembly-CSharp.dll",
                    "Assembly-CSharp.xml"],
          "src": "../DLL_stripped"
        }
      ],
      "dest": "api",
      "includePrivateMembers": false,
      "disableGitFeatures": false,
      "disableDefaultFilter": false,
      "noRestore": false,
      "namespaceLayout": "flattened",
      "memberLayout": "samePage",
      "allowCompilationErrors": false
    }
  ],
  "build": {
    "content": [
      {
        "files": [
          "api/**.yml",
          "api/index.md"
        ]
      },
      {
        "files": [
          "articles/**.md",
          "articles/**/toc.yml",
          "toc.yml",
          "*.md"
        ]
      }
    ],
    "resource": [
      {
        "files": [
          "images/**"
        ]
      }
    ],
    "output": "_site",
    "globalMetadataFiles": [],
    "fileMetadataFiles": [],
    "template": [
      "default",
      "modern"
    ],
    "postProcessors": [],
    "keepFileLink": false,
    "disableGitFeatures": false
  }
}
```
The important things to know are the (a) DocFX is looking for relative paths, so with the "src" parameter set to "../DLL_stripped" that means it will look for the "files" in a folder named DLL_stripped that is located beside the "docfx_project" folder. Place the stripped DLL and resulting XML there, and then you're ready to generate site files using this command.
```
docfx docfx_project/docfx.json --serve
```
Note that when DocFX processes the stripped DLL it will report that there are many missing references. These don't matter and won't interfere with the process, so you can ignore those warnings.

The --serve command line argument will cause DocFX to serve up the resulting documentation site on your local machine at http://localhost:8080. This is useful for testing to make sure things are working OK and what you got from DocFX was good, but obviously this will not get the site served to the masses!
5. **Build a GitHub Pages Site**. At this point the process moves to workign with a GitHub repo and making a GitHub Pages site. GitHub provides ample documentation for this, and also DocFX documents thigns too. The key to getting this working is actually in GitHub Actions, which is where the automation takes place. If all we did was place a static copy of the DocFX generated site online, it wouldn't be nearly as useful. Any community additions to it would require rebuilding and pushing it back up manually. Instead, we've developed a GitHub action that aotomatically triggers when new content is pushed to certain folders in the repo. The GitHub action takes care of re-running GenDoc to rebuild the Assembly-CSharp.xml file (in case any of the .cs files have changed), and then is re-runs DocFX to rebuild the site (to incorporate any new XML comments from GenDoc and in case any article or site template files have changed). The GitHub action is the yaml script shown here.
```yml
# Simple workflow for generating DocFx Content and publish to GitHub Pages
name: Generate and Publish DocFx Content

on:
  # Runs on pushes targeting the default branch and impacting either the src_stripped, docfx_project, public, or DLL_stripped folders
  push:
    branches: ["main"]
    paths: ["src_stripped/**", "docfx_project/**", "public/**", "DLL_stripped/**"]
    
  # Allows you to run this workflow manually from the Actions tab
  workflow_dispatch:
  
# Sets permissions of the GITHUB_TOKEN to allow deployment to GitHub Pages
permissions:
  contents: read
  pages: write
  id-token: write

# Allow only one concurrent deployment, skipping runs queued between the run in-progress and latest queued.
# However, do NOT cancel in-progress runs as we want to allow these production deployments to complete.
concurrency:
  group: "pages"
  cancel-in-progress: false

jobs:
  build:
    runs-on: windows-latest
    steps:
      - name: Checkout
        uses: actions/checkout@master
      - name: Generate XML Documentation Directly
        run: GenDoc\GenDoc.exe src_stripped\Assembly-CSharp-Stripped.sln DLL_stripped
        shell: cmd
      - name: Upload Assembly-CSharp.xml Artifact
        uses: actions/upload-artifact@v3
        with:
          name: Assembly-CSharp.xml
          path: DLL_stripped/Assembly-CSharp.xml
  publish-docs:
    needs: build
    environment:
      name: github-pages
      url: ${{ steps.deployment.outputs.page_url }}
    runs-on: ubuntu-latest
    steps:
      - name: Chekout
        uses: actions/checkout@v3
      - name: Remove old Assembly-CSharp.xml
        run: rm DLL_stripped/Assembly-CSharp.xml
      - name: Download Assembly-CSharp.xml Artifact
        uses: actions/download-artifact@v3
        with:
          name: Assembly-CSharp.xml
          path: DLL_stripped/Assembly-CSharp.xml
      - name: Dotnet Setup
        uses: actions/setup-dotnet@v3
        with:
          dotnet-version: 7.x

      - run: dotnet tool update -g docfx
      - run: docfx docfx_project/docfx.json

      - name: Setup Pages
        uses: actions/configure-pages@v3
      - name: Upload artifact
        uses: actions/upload-pages-artifact@v1
        with:
          # Upload entire repository
          path: '.'
      - name: Deploy to GitHub Pages
        id: deployment
        uses: actions/deploy-pages@v2
```

There you have it. Now you know exactly how this site is built, which may give you some confidence (or not) as to the quality of the information you'll find here.
