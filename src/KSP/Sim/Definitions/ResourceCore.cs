// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.ResourceCore
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.ResourceSystem;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.Definitions
{
  [Serializable]
  public class ResourceCore
  {
    public const string RESOURCE_SERIALIZATION_VERSION = "0.1";
    [HideInInspector]
    public string version;
    [HideInInspector]
    public bool useExternal;
    [HideInInspector]
    public bool isRecipe;
    public ResourceDefinition data;
    public ResourceRecipeDefinition recipeData;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResourceCore() => throw null;
  }
}
