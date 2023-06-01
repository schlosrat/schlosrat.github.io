// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_Engine
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.Definitions;
using KSP.Sim.impl;
using KSP.Sim.ResourceSystem;
using KSP.UI.Binding;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.Modules
{
  [Serializable]
  public sealed class Data_Engine : ModuleData
  {
    [LocalizedField("PartModules/Engine/IndependentThrottle")]
    [KSPState(CopyToSymmetrySet = true)]
    [HideInInspector]
    [PAMDisplayControl(SortIndex = 12)]
    public ModuleProperty<bool> IndependentThrottle;
    [HideInInspector]
    [PAMDisplayControl(SortIndex = 13)]
    [KSPState(CopyToSymmetrySet = true)]
    [SteppedRange(0.0f, 100f, 1f)]
    [LocalizedField("PartModules/Engine/EngineThrottle")]
    public ModuleProperty<float> IndependentThrottlePercentage;
    [LocalizedField("PartModules/Engine/EngineMode")]
    [PAMDisplayControl(SortIndex = 3)]
    [KSPState]
    [HideInInspector]
    public ModuleProperty<string> EngineModeString;
    [KSPState(CopyToSymmetrySet = true)]
    [LocalizedField("PartModules/Engine/EngineMode")]
    [PAMDisplayControl(SortIndex = 2)]
    [HideInInspector]
    public ModuleProperty<string> activeEngineMode;
    [HideInInspector]
    [KSPState(CopyToSymmetrySet = true)]
    [SteppedRange(0.0f, 100f, 1f)]
    [LocalizedField("PartModules/Engine/EngineThrustLimiter")]
    [PAMDisplayControl(SortIndex = 7)]
    public ModuleProperty<float> thrustPercentage;
    public float FinalThrustValue;
    public float RealISPValue;
    private EngineState _state;
    [HideInInspector]
    [KSPState]
    [LocalizedField("PartModules/Engine/EngineStatus")]
    [PAMDisplayControl(SortIndex = 1)]
    public ModuleProperty<string> StatusString;
    [HideInInspector]
    [KSPState]
    [PAMDisplayControl(SortIndex = 2)]
    [LocalizedField("PartModules/Engine/EngineISP")]
    public ModuleProperty<float> StatusISPString;
    [KSPState]
    [LocalizedField("PartModules/Engine/EngineStaging")]
    [PAMDisplayControl(SortIndex = 11)]
    public ModuleProperty<bool> stagingOn;
    [KSPState]
    [HideInInspector]
    public bool staged;
    [KSPState]
    [HideInInspector]
    [FormerlySerializedAs("flameout")]
    public bool Flameout;
    [KSPState]
    [HideInInspector]
    public bool EngineIgnited;
    [HideInInspector]
    [FormerlySerializedAs("engineShutdown")]
    [KSPState]
    public bool EngineShutdown;
    [KSPState]
    [LocalizedField("PartModules/Engine/EngineHeat")]
    [PAMDisplayControl(SortIndex = 9)]
    [HideInInspector]
    public ModuleProperty<float> HeatProduced;
    [KSPState]
    [HideInInspector]
    public float currentThrottle;
    [KSPState]
    public float thrustCurveDisplay;
    [KSPState]
    public float thrustCurveRatio;
    [JsonIgnore]
    [HideInInspector]
    public List<PropellantState> PropellantStates;
    [KSPState]
    [FormerlySerializedAs("engineSpool")]
    [HideInInspector]
    public float EngineSpool;
    [KSPState]
    [HideInInspector]
    public Vector3 ThrustDirRelativePartWorldSpace;
    [KSPState]
    [HideInInspector]
    public int currentEngineModeIndex;
    [KSPDefinition]
    [NonReorderable]
    public Data_Engine.EngineMode[] engineModes;
    [KSPDefinition]
    public bool UseEmissive;
    [KSPDefinition]
    public List<string> EmissiveMaterialNames;
    [KSPDefinition]
    public FloatCurve EmissiveTemperatureCurve;
    [KSPDefinition]
    public float EmissiveLerpRateUp;
    [KSPDefinition]
    public float EmissiveLerpRateDown;
    private DropdownItemList _dropdownItems;
    [JsonIgnore]
    public bool IsPropellantStarved;
    [JsonIgnore]
    public float ResultingThrust;
    [JsonIgnore]
    public float FlowMultiplier;
    [JsonIgnore]
    public float RequestedThrottle;
    [JsonIgnore]
    public float ThrottleMin;
    [JsonIgnore]
    public bool IsUnderwater;
    [JsonIgnore]
    public float RequestedMassFlow;
    [JsonIgnore]
    public float MaxFuelFlow;
    [JsonIgnore]
    public float MinFuelFlow;

    public override System.Type ModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public EngineState State
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void SetState(EngineState newState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float MaxThrustOutputAtm(
      bool runningActive = false,
      bool useThrustLimiter = true,
      double atmPressure = 1.0,
      double atmTemp = 310.0,
      double atmDensity = 1.2250000238418579,
      float machNumber = 0.0f)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float CalculateThrustCurveValueRatio(
      float thrustCurveValueRatio,
      ResourceDefinitionID resourceId)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float MaxThrustOutputVac(bool useThrustLimiter = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetLimiterString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetIndependentThrottleString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetIndependentThrottlePercentageString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetHeatString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetISPString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal override void OnPartBehaviourModuleInit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void SetupEngineModeDropdown() => throw null;

    [JsonIgnore]
    public Data_Engine.EngineMode currentEngineModeData
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [JsonIgnore]
    public PropellantState CurrentPropellantState
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetThrottlingMult(float atm) => throw null;

    public bool IsOperational
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetupMixtures(
      IGGuid guid,
      ResourceFlowRequestBroker resourceFlowRequestBroker,
      IResourceContainer[] resourceContainer)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetConsumptionRate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal override List<OABPartData.PartInfoModuleEntry> GetPartInfoEntries(
      System.Type partBehaviourModuleType,
      List<OABPartData.PartInfoModuleEntry> delegateList)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<OABPartData.PartInfoModuleSubEntry> GetModeEntries(
      OABPartData.OABSituationStats stats)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<OABPartData.PartInfoModuleSubEntry> GetModeValues(
      OABPartData.OABSituationStats stats,
      Data_Engine.EngineMode currentMode)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal List<OABPartData.PartInfoModuleSubEntry> GetMaxThrustStrings(
      OABPartData.OABSituationStats OABSituationStats,
      Data_Engine.EngineMode currentMode)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<OABPartData.PartInfoModuleSubEntry> GetMinThrustStrings(
      OABPartData.OABSituationStats OABSituationStats,
      Data_Engine.EngineMode currentMode)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal List<OABPartData.PartInfoModuleSubEntry> GetIspStrings(
      OABPartData.OABSituationStats OABSituationStats,
      Data_Engine.EngineMode currentMode)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<OABPartData.PartInfoModuleSubEntry> GetPropellantStrings(
      OABPartData.OABSituationStats OABSituationStats,
      Data_Engine.EngineMode currentMode)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<OABPartData.PartInfoModuleSubEntry> GetFlagStrings(
      OABPartData.OABSituationStats OABSituationStats,
      Data_Engine.EngineMode currentMode)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float OABGetMaxFuelFlow(Data_Engine.EngineMode currentMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float OABGetMinFuelFlow(Data_Engine.EngineMode currentMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float OABGetThrust(
      Data_Engine.EngineMode currentMode,
      float oabAtmPressure,
      float thrustLevel)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Data_Engine() => throw null;

    [Serializable]
    public class EngineMode
    {
      [Tooltip("The Engine ID. should be in English.")]
      [KSPDefinition]
      public string engineID;
      [Tooltip("The Engine ID display name, should be a localization tag to get localized engine mode in the UI.\nThis only appears in the UI for multi-mode engines.")]
      [KSPDefinition]
      public string EngineDisplayName;
      [KSPDefinition]
      [Tooltip("The Thrust Transform name in the model for this engine mode.")]
      public string thrustVectorTransformName;
      [KSPDefinition]
      [Tooltip("Is the throttle locked in this engine mode? EG: SRB or can be changed by the player.")]
      public bool throttleLocked;
      [Tooltip("When will the engine fail from lack of propellants?\n Default = 0.1 or at 10% of required fuel or less the engine flames out.")]
      [KSPDefinition]
      public float ignitionThreshold;
      [Tooltip("Do we clamp the return percent to the min ratio (and never request more on followups) or do we request all always, and average?")]
      [KSPDefinition]
      public bool clampPropReceived;
      [KSPDefinition]
      public double clampPropReceivedMinLowerAmount;
      [KSPDefinition]
      [Tooltip("Can the engine be restarted in this mode? eg: SRB would be false.")]
      public bool allowRestart;
      [KSPDefinition]
      [Tooltip("Can the engine be shut down in this mode? eg: SRB would be false.")]
      public bool allowShutdown;
      [Tooltip("Can the engine be be activated when shielded from airstream? ie: inside a fairing?")]
      [KSPDefinition]
      public bool shieldedCanActivate;
      [Tooltip("A curve to determine loss or gain of thrust due to changes in atmosphere vs vacuum values are based on ISP to ATM Pressure")]
      [KSPDefinition]
      public FloatCurve atmosphereCurve;
      [Tooltip("should we use a thrust curve (based on resource remaining) ?")]
      [KSPDefinition]
      public bool useThrustCurve;
      [KSPDefinition]
      [Tooltip("The thrust curve to use if useThrustCurve is true.")]
      public FloatCurve thrustCurve;
      [KSPDefinition]
      [Tooltip("Is this engine disabled when under water?")]
      public bool disableUnderwater;
      [Tooltip("If set to true this engine mode will not be included in Delta-V calculations.")]
      [KSPDefinition]
      public bool nonThrustMotor;
      [Tooltip("Minimum Thrust in kN this engine produces at 0% throttle.")]
      [KSPDefinition]
      public float minThrust;
      [KSPDefinition]
      [Tooltip("Maximum Thrust in kN this engine produces at 100% throttle.")]
      public float maxThrust;
      [Tooltip("What type of engine is this?")]
      [KSPDefinition]
      public EngineType engineType;
      [KSPDefinition]
      public PropellantDefinition propellant;
      [Tooltip("Whether to apply the engine acceleration and deceleration speed variables.")]
      [KSPDefinition]
      public bool useEngineResponseTime;
      [Tooltip("How quickly the engine can increase its thrust production, as a fraction of maximum/second.")]
      [KSPDefinition]
      public float engineAccelerationSpeed;
      [Tooltip("How quickly the engine can decrease its thrust production, as a fraction of maximum/second.")]
      [KSPDefinition]
      public float engineDecelerationSpeed;
      [Tooltip("Does this engine generate heat at all?")]
      [KSPDefinition]
      [Header("Heat Variables")]
      public bool GenerateHeat;
      [KSPDefinition]
      [Tooltip("Curve to adjust heat produced based on atmosphere pressure key (coordinate)\nX: Atmospheric Pressure.  1 = Kerbin Atmosphere at sea level.\nY: Defines the heat production  at the given atmosphere of pressure.")]
      public FloatCurve HeatAtmosphereCurve;
      [KSPDefinition]
      [Tooltip("Do we divide the heat produced by the flow multiplier to get the final flux?\ni.e. do we always produce the same heat for the same throttle setting?")]
      public bool NormalizeHeatForFlow;
      [Header("Exhaust Damage Variables")]
      [Tooltip("Determines whether the engine heats up and pushes on parts that are arranged in its exhaust path.")]
      [KSPDefinition]
      public bool exhaustDamage;
      [KSPDefinition]
      [Tooltip("A multiplier to the exhaust damage radius.\n The radius is calculated from the Part Size category * this multiplier")]
      public float exhaustDamageRadiusMultiplier;
      [Tooltip("The amount of heat added from exhaust to a part, in kW.")]
      [KSPDefinition]
      public float ExhaustDamageValue;
      [Tooltip("Whether damage from the engine exhaust is logged for debugging.")]
      [KSPDefinition]
      public bool exhaustDamageLogEvent;
      [KSPDefinition]
      [Tooltip("Whether the engine will receive heating from the exhaust splashing back.")]
      public bool exhaustSplashbackDamage;
      [Tooltip("Adjusts the exponent of the exhaust damage distance falloff curve.")]
      [KSPDefinition]
      public double exhaustDamageFalloffPower;
      [KSPDefinition]
      [Tooltip("Adjusts the exponent of the exhaust splashback damage distance  falloff curve.")]
      public double exhaustDamageSplashbackFallofPower;
      [KSPDefinition]
      [Tooltip("Adjusts the splashback damage multiplier per Newton of force produced.")]
      public double exhaustDamageSplashbackMult;
      [Tooltip("The maximum amount of splashback damage that can occur.")]
      [KSPDefinition]
      public double exhaustDamageSplashbackMaxMutliplier;
      [Tooltip("Distance from the thrust transform where exhaust damage starts to occur.")]
      [KSPDefinition]
      public double exhaustDamageDistanceOffset;
      [Tooltip("Maximum range in meters that the exhaust damage is applied.")]
      [KSPDefinition]
      public float exhaustDamageMaxRange;
      [Tooltip("Cap on the maximum multiplier to above factors that the exhaust damage can be at.")]
      [KSPDefinition]
      public double exhaustDamageMaxMutliplier;
      [Tooltip("Whether this engine creates a shockwave.")]
      [KSPDefinition]
      [Header("Exhaust Shockwave Variables")]
      public bool exhaustShockwave;
      [KSPDefinition]
      [Tooltip("Whether damage from shockwave events are logged for debugging.")]
      public bool exhaustShockwaveLogEvent;
      [KSPDefinition]
      [Tooltip("Period of time between shockwaves. A value of -1 means this shockwave always occurs.")]
      public float exhaustShockwaveInterval;
      [KSPDefinition]
      [Tooltip("Adjusts the force in Newtons a shockwave produces for damage purposes.")]
      public double exhaustShockwaveMultiplier;
      [KSPDefinition]
      [Tooltip("Adjusts the exponent of the shockwave damage distance falloff curve.")]
      public double exhaustShockwaveFalloffPower;
      [KSPDefinition]
      [Tooltip("Distance from the thrust transform that the shockwave starts.")]
      public float exhaustShockwaveDistanceOffset;
      [KSPDefinition]
      [Tooltip("Maximum range in meters that shockwave damage is applied.")]
      public float exhaustShockwaveMaxRange;
      [KSPDefinition]
      [Tooltip("Cap on the maximum multiplier that shockwave damage can be at.")]
      public double exhaustShockwaveMaxMultiplier;
      [KSPDefinition]
      [Header("AlternateThrottle Variables")]
      public bool throttleUseAlternate;
      [KSPDefinition]
      public float throttleResponseRate;
      [KSPDefinition]
      public float throttleIgniteLevelMult;
      [KSPDefinition]
      public float throttleStartupMult;
      [KSPDefinition]
      public float throttleStartedMult;
      [KSPDefinition]
      public bool throttleInstantShutdown;
      [KSPDefinition]
      public float throttleShutdownMult;
      [KSPDefinition]
      public bool throttleInstant;
      [KSPDefinition]
      public double throttlingBaseRate;
      [KSPDefinition]
      public double throttlingBaseClamp;
      [KSPDefinition]
      public double throttlingBaseDivisor;
      [KSPDefinition]
      [Header("Jet Variables")]
      [Tooltip("Atmospheric density will change fuel flow (and thus thrust)")]
      public bool atmChangeFlow;
      [Tooltip("Normally thrust is proportional to density, but we allow tuning.\nTuning is especially needed because there's no stratosphere, so temperature keeps decreasing and thus speed of sound keeps decreasing.")]
      [KSPDefinition]
      public FloatCurve atmCurve;
      [KSPDefinition]
      [Tooltip("Do we use the atm curve? If not, and atmChangeFlow is true, just use atm linearly.")]
      public bool useAtmCurve;
      [KSPDefinition]
      [Tooltip("replacement for the existing module's velocityCurve.\nNote that its x value is Mach, not m/s velocity.\nHigh-bypass turbofans will see thrust decrease steadily from static.\nLow-bypass turbofans and turbojets will see thrust decrease slightly up to about 0.2 Mach then increase steadily until the limit is reached (both in terms of heat, and incoming compression vs compressor compression).\nRamjets have 0 static thrust, and do not light until 0.3 Mach or so, but once lit have steadily increasing thrust until Mach 5, when the incoming air can no longer be slowed to subsonic (combustion must be subsonic for ramjets). Thermal limits also apply, of course.")]
      public FloatCurve velCurve;
      [KSPDefinition]
      [Tooltip("If false, we don't use the new velCurve above.")]
      public bool useVelCurve;
      [KSPDefinition]
      [Tooltip("tunable clamp. The flow multiplier will never go below this.")]
      public float CLAMP;
      [Tooltip("Same as atmCurve, but changes Isp not flow")]
      [KSPDefinition]
      public FloatCurve atmCurveIsp;
      [Tooltip("Whether to use the atmCurveIsp curve above.")]
      [KSPDefinition]
      public bool useAtmCurveIsp;
      [Tooltip("Same as velCurve but changes Isp not flow.")]
      [KSPDefinition]
      public FloatCurve velCurveIsp;
      [Tooltip("Whether to use the velCurveIsp curve above.")]
      [KSPDefinition]
      public bool useVelCurveIsp;
      [Tooltip("When the flow multiplier goes below this, we Flameout the engine. NOTE: THIS FIXES ASYMMETRIC FLAMEOUTS.")]
      [KSPDefinition]
      public float flameoutBar;
      [KSPDefinition]
      [Tooltip("cap beyond which increases to flow multiplier aren't fully felt (start to taper off)")]
      public float flowMultCap;
      [KSPDefinition]
      [Tooltip("Sharpness of the tapering off of flow increase beyond cap.")]
      public float flowMultCapSharpness;
      [KSPDefinition]
      [Tooltip("Multiplier to final flow as calculated.")]
      public float multFlow;
      [Tooltip("Multiplier to final Isp as calculated.")]
      [KSPDefinition]
      public float multIsp;
      [Tooltip("This is the Turbine Spool Up time used for Spool Up Engine FX.")]
      [KSPDefinition]
      [Header("Turbine Variables")]
      public float engineSpoolTime;
      [KSPDefinition]
      public float engineSpoolIdle;
      [Header("Wait Time Variables")]
      [KSPDefinition]
      [Tooltip("The time to wait when exiting this engine mode in seconds.")]
      public float ModeExitWaitTime;
      [KSPDefinition]
      [Tooltip("The time to wait when exiting running state in this engine mode in seconds.")]
      public float ModeExitRunningWaitTime;
      [Tooltip("The time to wait when entering this engine mode in seconds.")]
      [KSPDefinition]
      public float ModeEnterWaitTime;
      [Tooltip("The time to wait when entering running state in this engine mode in seconds.")]
      [KSPDefinition]
      public float ModeEnterRunningWaitTime;
      [KSPDefinition]
      [Tooltip("The time to wait when deactivating this engine mode in seconds.")]
      public float DeactivateEngineWaitTime;
      [KSPDefinition]
      [Tooltip("The time to wait when activating this engine mode in seconds.")]
      public float ActivateEngineWaitTime;
      [Header("Other Variables")]
      [KSPDefinition]
      [Tooltip("Should we use the Throttle ISP curve?")]
      public bool useThrottleIspCurve;
      [Tooltip("Modifies Isp based on throttle.\nTime is pressure in atm, value is how much throttling affects Isp\n(i.e. Isp = input * Lerp(1, throttleIspCurve, throttleIspCurveAtmStrength)")]
      [KSPDefinition]
      public FloatCurve throttleIspCurveAtmStrength;
      [Tooltip("Modifies Isp based on throttle. time is throttle, value is multiplier to Isp")]
      [KSPDefinition]
      public FloatCurve throttleIspCurve;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public EngineMode() => throw null;
    }

    [Serializable]
    public class EngineForce : IForce
    {
      public ForceType ForceMode
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      }

      public Vector3d RelativeForce
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      }

      public Vector3d RelativePosition
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      }

      public static Data_Engine.EngineForce Default
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public EngineForce() => throw null;
    }

    [Serializable]
    public class DamageForce : IForce
    {
      public ForceType ForceMode
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      }

      public Vector3d RelativeForce
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      }

      public Vector3d RelativePosition
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      }

      public double DamageScale
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      }

      public List<PartBehavior> PartsDamaged
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      }

      public static Data_Engine.DamageForce Default
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public DamageForce() => throw null;
    }

    [Serializable]
    public class ShockwaveForce : IForce
    {
      public ForceType ForceMode
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      }

      public Vector3d RelativeForce
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      }

      public Vector3d RelativePosition
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      }

      public PartBehavior partDamaged
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      }

      public static Data_Engine.ShockwaveForce Default
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public ShockwaveForce() => throw null;
    }

    public class ThrustCollisionInfo
    {
      public bool Active;
      public float collisionDistance;
      public Vector3 UnityWorldSpaceLocation;
      public Vector3 UnityWorldSpaceNormal;
      public Quaternion surfaceForward;
      public float NormalDeviationFromRaycast;
      public Transform UnityWorldSpaceTransform;
      public int UnityLayer;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Reset() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public ThrustCollisionInfo() => throw null;
    }
  }
}
