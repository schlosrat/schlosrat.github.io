// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_SolarPanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.Definitions;
using KSP.Sim.ResourceSystem;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  [Serializable]
  public sealed class Data_SolarPanel : ModuleData
  {
    [LocalizedField("PartModules/SolarPanel/StellarExposure")]
    [KSPState]
    [PAMDisplayControl(SortIndex = 5)]
    public ModuleProperty<string> StellarExposure;
    [KSPState]
    [PAMDisplayControl(SortIndex = 6)]
    [LocalizedField("PartModules/SolarPanel/EnergyFlow")]
    public ModuleProperty<float> EnergyFlow;
    public string SimBlockingBody;
    public double SimStarEnergyScale;
    [KSPDefinition]
    public float RaycastOffset;
    [KSPDefinition]
    public bool UseRaycastForTrackingDot;
    [KSPDefinition]
    public string RaycastTransformName;
    [KSPDefinition]
    public Vector3 PanelIncidenceDirection;
    [KSPDefinition]
    public PartModuleResourceSetting ResourceSettings;
    [KSPDefinition]
    public float EfficiencyMultiplier;
    public ResourceFlowRequestCommandConfig RequestConfig;

    public override System.Type ModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetEnergyFlowString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal override void OnPartBehaviourModuleInit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal override List<OABPartData.PartInfoModuleEntry> GetPartInfoEntries(
      System.Type partBehaviourModuleType,
      List<OABPartData.PartInfoModuleEntry> delegateList)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<OABPartData.PartInfoModuleSubEntry> GetResourceGeneratedStrings(
      OABPartData.OABSituationStats oabSituationStats)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SetupResourceRequest(
      ResourceFlowRequestBroker resourceFlowRequestBroker)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Data_SolarPanel() => throw null;
  }
}
