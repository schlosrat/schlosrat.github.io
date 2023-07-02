// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ResourceSystem.ContainedResourceData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
