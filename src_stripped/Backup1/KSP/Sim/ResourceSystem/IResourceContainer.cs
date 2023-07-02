// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ResourceSystem.IResourceContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections;
using System.Collections.Generic;

namespace KSP.Sim.ResourceSystem
{
  public interface IResourceContainer : 
    IResourceContainerReadOnly,
    IReadOnlyCollection<ResourceDefinitionID>,
    IEnumerable<ResourceDefinitionID>,
    IEnumerable
  {
    bool AreDefinitionsFrozen { get; }

    bool OverrideContainedCapacity(
      ResourceDefinitionID resourceID,
      double capacityUnits,
      bool nonStageable,
      bool fillToCapacity = false);

    bool OverrideContainedData(
      ResourceDefinitionID resourceID,
      double capacityUnits,
      double storedUnits,
      bool nonStageable);

    bool OverrideContainedData(ContainedResourceData data);

    double FillResourceToCapacity(ResourceDefinitionID resourceID);

    void FillAllResourcesToCapacity();

    double DumpResource(ResourceDefinitionID resourceID);

    void DumpAllResources();

    double SetResourceStoredUnits(ResourceDefinitionID resourceID, double unitsToSet);

    double SetResourceFillRatio(ResourceDefinitionID resourceID, double percentOfCapacity);

    double AddResourceUnits(ResourceDefinitionID resourceID, double totalUnitsToAdd);

    double AddResourceUnits(
      ResourceDefinitionID resourceID,
      double unitsToAddPerSecond,
      double timeInSeconds);

    double RemoveResourceUnits(ResourceDefinitionID resourceID, double totalUnitsToRemove);

    double RemoveResourceUnits(
      ResourceDefinitionID resourceID,
      double unitsToRemovePerSecond,
      double timeInSeconds);

    double GetResourceStoredMass(ResourceDefinitionID resourceID);

    double GetStoredResourcesTotalMass();

    double GetStoredResourceThermalMass(ResourceDefinitionID resourceID);

    double GetStoredResourcesTotalThermalMass();
  }
}
