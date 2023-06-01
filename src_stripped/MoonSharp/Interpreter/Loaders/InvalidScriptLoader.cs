// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Loaders.InvalidScriptLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Loaders
{
  internal class InvalidScriptLoader : IScriptLoader
  {
    private string m_Error;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal InvalidScriptLoader(string frameworkname) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public object LoadFile(string file, Table globalContext) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string ResolveFileName(string filename, Table globalContext) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string ResolveModuleName(string modname, Table globalContext) => throw null;
  }
}
