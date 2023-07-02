// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Loaders.ScriptLoaderBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Loaders
{
  public abstract class ScriptLoaderBase : IScriptLoader
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract bool ScriptFileExists(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract object LoadFile(string file, Table globalContext) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual string ResolveModuleName(string modname, string[] paths) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string ResolveModuleName(string modname, Table globalContext) => throw null;

    public string[] ModulePaths
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string[] UnpackStringPaths(string str) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string[] GetDefaultEnvironmentPaths() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string ResolveFileName(string filename, Table globalContext) => throw null;

    public bool IgnoreLuaPathGlobal
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected ScriptLoaderBase() => throw null;
  }
}
