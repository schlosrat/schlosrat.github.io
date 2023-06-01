// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Loaders.ScriptLoaderBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
