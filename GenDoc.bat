Echo off

REM Make sure we're in the right directory
cd C:\KSP2\gh_pages\schlosrat.github.io

REM Generate the XML file from the stripped source files
C:\GenDoc_2\GenDoc\GenDoc C:\KSP2\gh_pages\schlosrat.github.io\src_stripped\Assembly-CSharp-Stripped.sln C:\KSP2\gh_pages\schlosrat.github.io\DLL_stripped

REM Generate the DocFX project
docfx docfx_project\docfx.json --serve