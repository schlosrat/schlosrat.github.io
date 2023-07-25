// Decompiled with JetBrains decompiler
// Type: IConstructionResourceProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
