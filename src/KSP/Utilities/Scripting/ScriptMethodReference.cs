// Decompiled with JetBrains decompiler
// Type: KSP.Utilities.Scripting.ScriptMethodReference
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using Newtonsoft.Json;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Utilities.Scripting
{
  [Serializable]
  public class ScriptMethodReference
  {
    [JsonProperty]
    public ScriptExecutionContext TargetContext;
    [JsonProperty]
    public string ScriptFileAsset;
    [JsonProperty]
    public string ScriptMethod;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ScriptMethodReference() => throw null;
  }
}
