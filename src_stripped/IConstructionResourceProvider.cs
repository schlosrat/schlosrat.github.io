// Decompiled with JetBrains decompiler
// Type: IConstructionResourceProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.ResourceSystem;
using System.Collections.Generic;

public interface IConstructionResourceProvider
{
  bool DeductCost(
    IReadOnlyDictionary<ResourceDefinitionID, double> cost);

  bool CanAffordCost(
    IReadOnlyDictionary<ResourceDefinitionID, double> cost);

  Dictionary<ResourceDefinitionID, double> GetCurrentResources();
}
