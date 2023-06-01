// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Loaders.UnityAssetsScriptLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Loaders
{
  public class UnityAssetsScriptLoader : ScriptLoaderBase
  {
    private Dictionary<string, string> m_Resources;
    public const string DEFAULT_PATH = "MoonSharp/Scripts";

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UnityAssetsScriptLoader(string assetsPath = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UnityAssetsScriptLoader(Dictionary<string, string> scriptToCodeMap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LoadResourcesWithReflection(string assetsPath) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetFileName(string filename) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object LoadFile(string file, Table globalContext) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool ScriptFileExists(string file) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string[] GetLoadedScripts() => throw null;
  }
}
