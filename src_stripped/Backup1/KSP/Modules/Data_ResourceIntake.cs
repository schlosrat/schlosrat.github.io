// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_ResourceIntake
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.Definitions;
using KSP.Sim.ResourceSystem;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  [Serializable]
  public sealed class Data_ResourceIntake : ModuleData
  {
    [PAMDisplayControl(SortIndex = 2)]
    [KSPState(CopyToSymmetrySet = true)]
    [HideInInspector]
    [LocalizedField("PartModules/ResourceIntake/IntakeEnabled")]
    public ModuleProperty<bool> toggleResourceIntake;
    [HideInInspector]
    [KSPState]
    [PAMDisplayControl(SortIndex = 3)]
    [LocalizedField("PartModules/ResourceIntake/Flow")]
    public ModuleProperty<float> flowRate;
    [KSPState]
    [HideInInspector]
    [PAMDisplayControl(SortIndex = 1)]
    [LocalizedField("PartModules/ResourceIntake/Status")]
    public ModuleProperty<string> statusTxt;
    [KSPDefinition]
    public string resourceName;
    [KSPDefinition]
    public double acceptanceThreshold;
    [KSPDefinition]
    public bool checkForOxygen;
    [KSPDefinition]
    public float area;
    [KSPDefinition]
    public double intakeSpeed;
    [KSPDefinition]
    public string intakeTransformName;
    [KSPDefinition]
    public FloatCurve machCurve;
    [KSPDefinition]
    public string occludeNode;
    [KSPDefinition]
    public double unitScalar;
    [KSPDefinition]
    public double kPaThreshold;
    [KSPDefinition]
    public bool underwaterOnly;
    [KSPDefinition]
    public bool disableUnderwater;
    [JsonIgnore]
    public ResourceDefinitionID IntakeResourceID;
    [JsonIgnore]
    public ResourceDefinitionData ResourceDefinitionData;
    [JsonIgnore]
    public ResourceFlowRequestCommandConfig RequestConfig;
    [JsonIgnore]
    public double ResourceUnits;
    [JsonIgnore]
    public bool ModuleEnabled;

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
    private string GetResourceString(OABPartData.OABSituationStats oabSituationStats) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<OABPartData.PartInfoModuleSubEntry> GetEfficiencyStrings(
      OABPartData.OABSituationStats oabSituationStats)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private OABPartData.PartInfoModuleSubEntry GetMachEntry(int mach) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetAreaString(OABPartData.OABSituationStats oabSituationStats) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Data_ResourceIntake() => throw null;
  }
}
