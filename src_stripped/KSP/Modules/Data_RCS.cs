// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_RCS
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.Definitions;
using KSP.Sim.impl;
using KSP.Sim.ResourceSystem;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.Modules
{
  [Serializable]
  public sealed class Data_RCS : ModuleData
  {
    [HideInInspector]
    [PAMDisplayControl(SortIndex = 1)]
    [KSPState]
    [LocalizedField("PartModules/RCS/Status")]
    public ModuleProperty<string> ThrustStatus;
    [LocalizedField("PartModules/RCS/IsEnabled")]
    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(SortIndex = 2)]
    [HideInInspector]
    public ModuleProperty<bool> isEnabled;
    [LocalizedField("PartModules/RCS/RCSThrust")]
    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(SortIndex = 3)]
    [HideInInspector]
    [SteppedRange(0.0f, 100f, 1f)]
    public ModuleProperty<float> thrustPercentage;
    [HideInInspector]
    [PAMDisplayControl(SortIndex = 4)]
    [KSPState]
    [LocalizedField("PartModules/RCS/AdvancedSettings")]
    public ModuleProperty<bool> IsAdvancedSettingsShown;
    [LocalizedField("PartModules/RCS/Pitch")]
    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(SortIndex = 5)]
    [HideInInspector]
    public ModuleProperty<bool> enablePitch;
    [LocalizedField("PartModules/RCS/Yaw")]
    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(SortIndex = 6)]
    [HideInInspector]
    public ModuleProperty<bool> enableYaw;
    [KSPState(CopyToSymmetrySet = true)]
    [LocalizedField("PartModules/RCS/Roll")]
    [HideInInspector]
    [PAMDisplayControl(SortIndex = 7)]
    public ModuleProperty<bool> enableRoll;
    [LocalizedField("PartModules/RCS/PortStarboard")]
    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(SortIndex = 8)]
    [HideInInspector]
    public ModuleProperty<bool> enableX;
    [PAMDisplayControl(SortIndex = 9)]
    [LocalizedField("PartModules/RCS/DorsalVentral")]
    [KSPState(CopyToSymmetrySet = true)]
    [HideInInspector]
    public ModuleProperty<bool> enableY;
    [HideInInspector]
    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(SortIndex = 10)]
    [LocalizedField("PartModules/RCS/ForeAft")]
    public ModuleProperty<bool> enableZ;
    [LocalizedField("PartModules/RCS/ForeByThrottle")]
    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(SortIndex = 11)]
    [HideInInspector]
    public ModuleProperty<bool> foreByThrottle;
    [LocalizedField("PartModules/RCS/AlwaysFullAction")]
    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(SortIndex = 12)]
    [HideInInspector]
    public ModuleProperty<bool> fullThrust;
    [KSPDefinition]
    public PropellantDefinition Propellant;
    [KSPDefinition]
    [Tooltip("Maximum Thrust in kN this engine produces at 100% throttle.")]
    [FormerlySerializedAs("thrusterPower")]
    public float maxThrust;
    [KSPDefinition]
    [Tooltip("Can the engine be be activated when shielded from airstream? ie: inside a fairing?")]
    public bool shieldedCanActivate;
    [KSPDefinition]
    [Tooltip("A curve to determine loss or gain of thrust due to changes in atmosphere vs vacuum values are based on ISP to ATM Pressure")]
    public FloatCurve atmosphereCurve;
    [KSPDefinition]
    [Tooltip("should we use a thrust curve (based on resource remaining) ?")]
    public bool useThrustCurve;
    [KSPDefinition]
    [Tooltip("The thrust curve to use if useThrustCurve is true.")]
    public FloatCurve thrustCurve;
    [KSPDefinition]
    [Tooltip("Is this engine disabled when under water?")]
    public bool disableUnderwater;
    [KSPDefinition]
    public float fullThrustMin;
    [KSPDefinition]
    public bool useLever;
    [HideInInspector]
    [JsonIgnore]
    public PropellantState PropellantState;

    public override System.Type ModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal override void OnPartBehaviourModuleInit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetThrustPercentage(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetupMixtures(
      IGGuid guid,
      ResourceFlowRequestBroker resourceFlowRequestBroker,
      IResourceContainer[] resourceContainer)
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
    private List<OABPartData.PartInfoModuleSubEntry> GetMaxThrustStrings(
      OABPartData.OABSituationStats OABSituationStats)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal List<OABPartData.PartInfoModuleSubEntry> GetIspStrings(
      OABPartData.OABSituationStats OABSituationStats)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<OABPartData.PartInfoModuleSubEntry> GetPropellantStrings(
      OABPartData.OABSituationStats OABSituationStats)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float OABGetMaxFuelFlow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float OABGetMinFuelFlow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float OABGetThrust(float oabAtmPressure, float thrustLevel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Data_RCS() => throw null;
  }
}
