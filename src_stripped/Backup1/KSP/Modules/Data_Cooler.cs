// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_Cooler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.Definitions;
using KSP.Sim.impl;
using KSP.Sim.ResourceSystem;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  [Serializable]
  public sealed class Data_Cooler : ModuleData
  {
    [KSPState]
    [HideInInspector]
    public CoolerStates currentCoolerState;
    [LocalizedField("PartModules/Cooler/Enabled")]
    [KSPState(CopyToSymmetrySet = true)]
    [HideInInspector]
    public ModuleProperty<bool> coolerEnabled;
    [LocalizedField("PartModules/Cooler/Status")]
    [HideInInspector]
    [KSPState]
    public ModuleProperty<string> coolerStatusText;
    [KSPState]
    [HideInInspector]
    public bool isTransformInContact;
    [KSPState]
    [HideInInspector]
    public bool hasEnoughResources;
    [KSPState]
    [HideInInspector]
    public string[] resourceDiplayNames;
    [KSPDefinition]
    public double fluxRemoved;
    [KSPDefinition]
    public float emissiveLerpRateUp;
    [KSPDefinition]
    public float emissiveLerpRateDown;
    [KSPDefinition]
    public List<string> emissiveMaterialNames;
    [KSPDefinition]
    public string fxGroupName;
    [KSPDefinition]
    public string fxPrefab;
    [KSPDefinition]
    public List<PartModuleResourceSetting> requiredResources;
    public List<ResourceDefinitionID> InputResourcesIDs;
    public List<ResourceFlowRequestCommandConfig> RequestConfigs;

    public override System.Type ModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SetupResourceRequest(
      ResourceFlowRequestBroker resourceFlowRequestBroker)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal override List<OABPartData.PartInfoModuleEntry> GetPartInfoEntries(
      System.Type partBehaviourModuleType,
      List<OABPartData.PartInfoModuleEntry> delegateList)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetHeatRemovedString(OABPartData.OABSituationStats oabSituationStats) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetResourceStrings(OABPartData.OABSituationStats oabSituationStats) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Data_Cooler() => throw null;
  }
}
