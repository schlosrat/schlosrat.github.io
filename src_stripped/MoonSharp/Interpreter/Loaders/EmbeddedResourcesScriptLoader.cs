// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Loaders.EmbeddedResourcesScriptLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Loaders
{
  public class EmbeddedResourcesScriptLoader : ScriptLoaderBase
  {
    private Assembly m_ResourceAssembly;
    private HashSet<string> m_ResourceNames;
    private string m_Namespace;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public EmbeddedResourcesScriptLoader(Assembly resourceAssembly = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string FileNameToResource(string file) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool ScriptFileExists(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object LoadFile(string file, MoonSharp.Interpreter.Table globalContext) => throw null;
  }
}
