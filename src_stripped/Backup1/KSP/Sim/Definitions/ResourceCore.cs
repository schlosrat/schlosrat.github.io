// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.ResourceCore
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
