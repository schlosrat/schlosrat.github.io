// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Loaders.InvalidScriptLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
