# Adding and Editing Articles on This Site
The first thing you need to do if you've not done this already is to fork this GitHub repo. All the changes you make will be made on your local fork. To incorporate them simply use a Pull Request (PR) from your frok to the main branch of this repo. That said, adding a *new* article is a two-step process.

## Editing an Existing Article on This Site
To edit articles on this site you simply need to find the MarkDown (.md) file that defines them and edit that. DocFX automaticallly generates the HTML files served to site visitors based on the content of the corresponding MarkDown file, so editing the HTML files directly will not accomplish anything as they'll just be overwritten based on what's in the MarkDown file they're generated from.

With the exception of the main site's intro page (docfx_project/index.md) and the API Documentation intro page (docfx_project/api/index.md) all the articles for this site are located in the **docfx_project/articles** folder. Simply open the one you'd like to edit with a MarkDown capable editor and you're in business. Refer to [Markdown](http://daringfireball.net/projects/markdown/) for how to write markdown files.

## Adding a New Article to This Site
Adding a *new* article is only slightly more complex than editing an existing one in that it's a two-step process.

1. First, create a new MarkDown file in the **docfx_project/articles** folder. Give it a useful descriptive name that ends in the .md suffix, and then you can edit that file in any markdown capable editor you like. Refer to [Markdown](http://daringfireball.net/projects/markdown/) for how to write markdown files.
2. Second, you need to edit the **toc.yml** file, which is also in the **docfx_project/articles** folder. If you don't do this, then site visitors will not be shown the spiffy new article you've added. As with editing code or articles, you do this on your fork of the repo and submit your updates to toc.yml along with the new .md file you've added to the **docfx_project/articles** folder. The toc.yml file's contents will something look like this.
```yml
- name: Introduction
  href: intro.md
- name: Adding Comments to Code
  href: AddCodeComments.md
- name: Adding/Editing Articles
  href: AddArticles.md
```
All you need to do is add two lines to this file so that your new article will be included. The first (`- name: ...`) provides a visitor-friendly name for the article. You should use something simple enough to fit in the left side ToC section of the page and yet descriptive of what would be found in your new article. The second (`href: fileName.md`) tells the site where to find your file. This can be just the name of your new .md file if it's located in the  **docfx_project/articles** folder, or it can be a relative path to find your file starting from this folder.

Rinse and repeat for as many new articles as you would like to contribute, then create a PR to get your updates into the main branch of this repo.