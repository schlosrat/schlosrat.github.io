// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Loaders.EmbeddedResourcesScriptLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
