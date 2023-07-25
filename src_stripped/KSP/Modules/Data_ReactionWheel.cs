// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_ReactionWheel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.Definitions;
using KSP.Sim.ResourceSystem;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  [Serializable]
  public sealed class Data_ReactionWheel : ModuleData
  {
    [SteppedRange(0.0f, 1f, 0.01f)]
    [KSPState(CopyToSymmetrySet = true)]
    [HideInInspector]
    [LocalizedField("PartModules/ReactionWheel/WheelAuthority")]
    [PAMDisplayControl(SortIndex = 4)]
    public ModuleProperty<float> WheelAuthority;
    [LocalizedField("PartModules/ReactionWheel/WheelSetting")]
    [HideInInspector]
    [PAMDisplayControl(SortIndex = 3)]
    [KSPState(CopyToSymmetrySet = true)]
    public ModuleProperty<Data_ReactionWheel.ActuatorModes> WheelActuatorMode;
    [PAMDisplayControl(SortIndex = 2)]
    [KSPState(CopyToSymmetrySet = true)]
    [HideInInspector]
    [LocalizedField("PartModules/ReactionWheel/TorqueEnabled")]
    public ModuleProperty<bool> ToggleTorque;
    [LocalizedField("PartModules/ReactionWheel/WheelStatus")]
    [PAMDisplayControl(SortIndex = 1)]
    [KSPState]
    [HideInInspector]
    public ModuleProperty<string> StatusText;
    [KSPState]
    [HideInInspector]
    public Data_ReactionWheel.ReactionWheelState WheelState;
    [KSPDefinition]
    public float PitchTorque;
    [KSPDefinition]
    public float YawTorque;
    [KSPDefinition]
    public float RollTorque;
    [KSPDefinition]
    public float TorqueResponseSpeed;
    [KSPDefinition]
    public List<PartModuleResourceSetting> RequiredResources;
    [HideInInspector]
    [KSPState]
    public bool HasResourcesToOperate;
    public bool HasPendingResourceActivity;
    public float InputSumForResource;
    [JsonIgnore]
    public ResourceFlowRequestCommandConfig RequestConfig;
    private ResourceFlowRequestBroker _resourceFlowRequestBroker;

    public override System.Type ModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool HasPendingInputActivity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static string GetWheelAuthorityString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static string GetStatusString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SetupResourceRequest(
      ResourceFlowRequestBroker resourceFlowRequestBroker)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResourceFlowRequestHandle GetResourceRequestHandle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal override List<OABPartData.PartInfoModuleEntry> GetPartInfoEntries(
      System.Type partBehaviourModuleType,
      List<OABPartData.PartInfoModuleEntry> delegateList)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<OABPartData.PartInfoModuleSubEntry> GetResourceStrings(
      OABPartData.OABSituationStats oabSituationStats)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<OABPartData.PartInfoModuleSubEntry> GetTorqueStrings(
      OABPartData.OABSituationStats oabSituationStats)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Data_ReactionWheel() => throw null;

    [Serializable]
    public enum ReactionWheelState : byte
    {
      Active,
      Disabled,
      Broken,
    }

    public enum ActuatorModes : byte
    {
      [Description("PartModules/ReactionWheel/WheelSetting/All")] All,
      [Description("PartModules/ReactionWheel/WheelSetting/ManualOnly")] ManualOnly,
      [Description("PartModules/ReactionWheel/WheelSetting/SASOnly")] SASOnly,
    }
  }
}
