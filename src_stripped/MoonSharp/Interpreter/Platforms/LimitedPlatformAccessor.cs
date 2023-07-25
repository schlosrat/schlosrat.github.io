// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Platforms.LimitedPlatformAccessor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace MoonSharp.Interpreter.Platforms
{
  public class LimitedPlatformAccessor : PlatformAccessorBase
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string GetEnvironmentVariable(string envvarname) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override CoreModules FilterSupportedCoreModules(CoreModules module) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Stream IO_OpenFile(
      Script script,
      string filename,
      Encoding encoding,
      string mode)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Stream IO_GetStandardStream(StandardFileType type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string IO_OS_GetTempFilename() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OS_ExitFast(int exitCode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool OS_FileExists(string file) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OS_FileDelete(string file) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OS_FileMove(string src, string dst) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int OS_Execute(string cmdline) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string GetPlatformNamePrefix() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void DefaultPrint(string content) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LimitedPlatformAccessor() => throw null;
  }
}
