// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Platforms.PlatformAccessorBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace MoonSharp.Interpreter.Platforms
{
  public abstract class PlatformAccessorBase : IPlatformAccessor
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract string GetPlatformNamePrefix() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetPlatformName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetUnityRuntimeName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetUnityPlatformName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void DefaultPrint(string content) => throw null;

    [Obsolete("Replace with DefaultInput(string)")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string DefaultInput() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string DefaultInput(string prompt) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract Stream IO_OpenFile(
      Script script,
      string filename,
      Encoding encoding,
      string mode)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract Stream IO_GetStandardStream(StandardFileType type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract string IO_OS_GetTempFilename() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void OS_ExitFast(int exitCode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract bool OS_FileExists(string file) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void OS_FileDelete(string file) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void OS_FileMove(string src, string dst) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract int OS_Execute(string cmdline) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract CoreModules FilterSupportedCoreModules(CoreModules module) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract string GetEnvironmentVariable(string envvarname) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool IsRunningOnAOT() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected PlatformAccessorBase() => throw null;
  }
}
