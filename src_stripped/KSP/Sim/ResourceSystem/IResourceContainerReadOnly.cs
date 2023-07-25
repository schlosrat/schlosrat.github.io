// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ResourceSystem.IResourceContainerReadOnly
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections;
using System.Collections.Generic;

namespace KSP.Sim.ResourceSystem
{
  public interface IResourceContainerReadOnly : 
    IReadOnlyCollection<ResourceDefinitionID>,
    IEnumerable<ResourceDefinitionID>,
    IEnumerable
  {
    bool IsResourceContained(ResourceDefinitionID resourceID);

    int GetResourcesContainedCount();

    ContainedResourceData GetResourceContainedData(ResourceDefinitionID resourceID);

    double GetResourceStoredUnits(ResourceDefinitionID resourceID);

    double GetResourcePreProcessedUnits(ResourceDefinitionID resourceID);

    double GetResourceCapacityUnits(ResourceDefinitionID resourceID);

    double GetResourceEmptyUnits(ResourceDefinitionID resourceId);

    double GetResourceFillRatio(ResourceDefinitionID resourceID);
  }
}
