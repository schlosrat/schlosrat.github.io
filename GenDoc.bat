Echo off

REM Make sure we're in the right directory
REM cd C:\KSP2\gh_pages\schlosrat.github.io

REM Generate the XML file from the stripped source files
GenDoc\GenDoc src_stripped\Assembly-CSharp-Stripped.sln DLL_stripped

REM Generate the DocFX project
REM docfx docfx_project\docfx.json --serve