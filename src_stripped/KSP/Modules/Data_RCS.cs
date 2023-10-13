// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_RCS
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
    [LocalizedField("PartModules/RCS/Status")]
    [KSPState]
    [PAMDisplayControl(SortIndex = 1)]
    [HideInInspector]
    public ModuleProperty<string> ThrustStatus;
    [HideInInspector]
    [LocalizedField("PartModules/RCS/IsEnabled")]
    [PAMDisplayControl(SortIndex = 2)]
    [KSPState(CopyToSymmetrySet = true)]
    public ModuleProperty<bool> isEnabled;
    [HideInInspector]
    [PAMDisplayControl(SortIndex = 3)]
    [KSPState(CopyToSymmetrySet = true)]
    [LocalizedField("PartModules/RCS/RCSThrust")]
    [SteppedRange(0.0f, 100f, 1f)]
    public ModuleProperty<float> thrustPercentage;
    [KSPState]
    [PAMDisplayControl(SortIndex = 4)]
    [LocalizedField("PartModules/RCS/AdvancedSettings")]
    [HideInInspector]
    public ModuleProperty<bool> IsAdvancedSettingsShown;
    [HideInInspector]
    [PAMDisplayControl(SortIndex = 5)]
    [KSPState(CopyToSymmetrySet = true)]
    [LocalizedField("PartModules/RCS/Pitch")]
    public ModuleProperty<bool> enablePitch;
    [PAMDisplayControl(SortIndex = 6)]
    [HideInInspector]
    [LocalizedField("PartModules/RCS/Yaw")]
    [KSPState(CopyToSymmetrySet = true)]
    public ModuleProperty<bool> enableYaw;
    [LocalizedField("PartModules/RCS/Roll")]
    [HideInInspector]
    [PAMDisplayControl(SortIndex = 7)]
    [KSPState(CopyToSymmetrySet = true)]
    public ModuleProperty<bool> enableRoll;
    [HideInInspector]
    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(SortIndex = 8)]
    [LocalizedField("PartModules/RCS/PortStarboard")]
    public ModuleProperty<bool> enableX;
    [LocalizedField("PartModules/RCS/DorsalVentral")]
    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(SortIndex = 9)]
    [HideInInspector]
    public ModuleProperty<bool> enableY;
    [LocalizedField("PartModules/RCS/ForeAft")]
    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(SortIndex = 10)]
    [HideInInspector]
    public ModuleProperty<bool> enableZ;
    [PAMDisplayControl(SortIndex = 11)]
    [KSPState(CopyToSymmetrySet = true)]
    [LocalizedField("PartModules/RCS/ForeByThrottle")]
    [HideInInspector]
    public ModuleProperty<bool> foreByThrottle;
    [KSPState(CopyToSymmetrySet = true)]
    [LocalizedField("PartModules/RCS/AlwaysFullAction")]
    [PAMDisplayControl(SortIndex = 12)]
    [HideInInspector]
    public ModuleProperty<bool> fullThrust;
    [KSPDefinition]
    public PropellantDefinition Propellant;
    [Tooltip("Maximum Thrust in kN this engine produces at 100% throttle.")]
    [FormerlySerializedAs("thrusterPower")]
    [KSPDefinition]
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
    [Tooltip("Is this engine disabled when under water?")]
    [KSPDefinition]
    public bool disableUnderwater;
    [KSPDefinition]
    public float fullThrustMin;
    [KSPDefinition]
    public bool useLever;
    [JsonIgnore]
    [HideInInspector]
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
