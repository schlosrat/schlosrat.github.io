// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ResourceSystem.ContainedResourceData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Sim.ResourceSystem
{
  [Serializable]
  public struct ContainedResourceData
  {
    public ResourceDefinitionID ResourceID;
    public double CapacityUnits;
    public double StoredUnits;
    public bool NonStageable;
    public bool IsPartOfRecipe;
    public ResourceDefinitionID RecipeID;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ContainedResourceData(
      ContainedResourceDefinition data,
      ResourceDefinitionDatabase database)
    {
      throw null;
    }
  }
}
