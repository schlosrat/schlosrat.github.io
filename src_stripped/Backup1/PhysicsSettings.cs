// Decompiled with JetBrains decompiler
// Type: PhysicsSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.IO;
using KSP.Sim.impl;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

[JsonObject(MemberSerialization.OptIn)]
public class PhysicsSettings : VersionedBase
{
  public const string PhysicsSettingsFilename = "PhysicsSettings";
  public const IOProvider.DataLocation PhysicsSettingsFileLocation = IOProvider.DataLocation.Global;
  public const string CURRENT_FILE_VERSION = "0.1.6";
  public static readonly string[] PreviousFileVersionsThatRequireReset;
  private static PhysicsSettings _physicsSettings;
  public const string SIM_PHYSX_SCENERY_COLLIDER_LAYER_MASK_NAME = "Default";
  public const double ATMOSPHERES_PER_KPA = 0.0098692326671601;
  public const int KILOGRAM_PER_TONNE = 1000;
  public const double STANDARD_GRAVITY_EARTH = 9.80665;
  public const double GRAVITATIONAL_CONSTANT = 6.6743E-11;
  public const double METERS_PER_LIGHTYEAR = 9.4607304725808E+15;
  internal const float PHYSX_UNPACKED_RANGE_SQUARED = 4000000f;
  internal const float PHYSX_PACKED_RANGE_SQUARED = 4000000f;
  [JsonProperty("TimeWarpLevels")]
  private TimeWarp.TimeWarpLevel[] _timeWarpLevels;
  public const double WARP_TO_MANNODE_MARGIN = 30.0;
  public const int MAX_TIME_WARP_RATE_INDEX_SOI_TRANSITIONS = 4;
  public const int SOI_TRANSITION_LOOK_AHEAD_TIME_SECONDS = 50;
  public const int OUT_OF_FUEL_LOOK_AHEAD_TIME_SECONDS = 10;
  public const double AT_REST_SURFACE_SQ_VELOCITY_THRESHOLD = 0.1;
  public const double AT_REST_SURFACE_LANDED_VELOCITY_THRESHOLD = 0.25;
  public const double AT_REST_WATER_LANDED_VELOCITY_THRESHOLD = 0.5;
  public const double NEWTON_RAPHSON_MAX_ERROR = 1E-07;
  public const int NEWTON_RAPHSON_MAX_ITER = 20;
  public const double DENSITY_IN_VACUUM = 6.5E-27;
  public const double PRESSURE_IN_VACUUM = 0.0;
  [JsonProperty("GLOBAL_ENVIRONMENT_FLUX_SCALE")]
  private double _globalEnvironmentFluxScale;
  [JsonProperty("GLOBAL_ATMOSPHERE_FLUX_SCALE")]
  private double _globalAtmosphereFluxScale;
  [JsonProperty("GLOBAL_BODY_LOCAL_FLUX_SCALE")]
  private double _globalBodyLocalFluxScale;
  [JsonProperty("GLOBAL_BODY_SURFACE_FLUX_SCALE")]
  private double _globalBodySurfaceFluxScale;
  [JsonProperty("GLOBAL_POSITIVE_PART_TEMPERATURE_CHANGE_RATE_SCALE")]
  private double _globalPositivePartTemperatureChangeRateScale;
  [JsonProperty("GLOBAL_NEGATIVE_PART_TEMPERATURE_CHANGE_RATE_SCALE")]
  private double _globalNegativePartTemperatureChangeRateScale;
  [JsonProperty("GLOBAL_BACKGROUND_PART_TEMPERATURE_CHANGE_RATE_SCALE")]
  private double _globalBackgroundPartTemperatureChangeRateScale;
  [JsonProperty("GLOBAL_ENGINE_EXHAUST_FLUX_SCALE")]
  private double _globalEngineExhaustFluxScale;
  [JsonProperty("GLOBAL_REENTRY_FLUX_SCALE")]
  private double _globalReentryFluxScale;
  public const double ATMOSPHERIC_THERMAL_CONDUCTIVITY = 0.026;
  public const double THERMAL_WINDOW_SMOOTHING = 10000.0;
  public const double THERMAL_SKIN_FRICTION = 1.0;
  public static double GraviticForceMultiplier;
  [JsonProperty("PHYSX_RB_SQR_MAG_THRESHOLD")]
  private double _physxRbSqrMagThreshold;
  [JsonProperty("PHYSX_MASS_TOLERANCE")]
  private float _physxMassTolerance;
  [JsonProperty("PHYSX_MINIMUM_PART_MASS")]
  private double _physxMinimumPartMass;
  [JsonProperty("JOINT_RIGIDITY")]
  private float _jointRigidity;
  [JsonProperty("JOINT_SURFACE_NODE_FACTOR")]
  private float _jointSurfaceNodeFactor;
  [JsonProperty("JOINT_STACK_NODE_FACTOR")]
  private float _jointStackNodeFactor;
  [JsonProperty("JOINT_STACK_ATTACH_STIFFNESS")]
  private float _jointStackAttachStiffness;
  [JsonProperty("JOINT_SURFACE_ATTACH_STIFFNESS")]
  private float _jointSurfaceAttachStiffness;
  [JsonProperty("ENABLE_MULTI_JOINT")]
  private bool _enableMultiJoint;
  [JsonProperty("ENABLE_SCALED_SOLVER_ITERATION")]
  private bool _enableScaledSolverIteration;
  [JsonProperty("ENABLE_PART_TO_PART_COLLISIONS")]
  private bool _enablePartToPartCollisions;
  [JsonProperty("ENABLE_RIGIDBODY_SLEEPING")]
  private bool _enableRigidbodySleeping;
  [JsonProperty("ENABLE_INERTIA_TENSOR_SCALING")]
  private bool _enableInertiaTensorScaling;
  [JsonProperty("KSC_COMM_NET_RANGE_METERS")]
  private double _kscCommNetRangeMeters;
  [JsonProperty("GLOBAL_TENSOR_SCALAR")]
  private float _globalTensorScalar;
  [JsonProperty("GLOBAL_LOWMASS_TENSOR_SCALAR")]
  private float _globalLowMassTensorScalar;
  [JsonProperty("GLOBAL_LOWMASS_TENSOR_LIMIT")]
  private float _globalLowMassTensorLimit;
  [JsonProperty("GLOBAL_EJECTION_FORCE_SCALING_LOWMASS_LIMIT")]
  private float _globalEjectionForceLowMassLimit;
  [JsonProperty("GLOBAL_EJECTION_FORCE_SCALE")]
  private float _globalEjectionForceScale;
  private bool _enableDynamicTensorSolution;
  private bool _debugDisableJoints;
  [JsonProperty("BodyLiftLiftingSurfaceCurve")]
  private PhysicsSettings.LiftingSurfaceCurve _bodyLiftLiftingSurfaceCurve;
  [JsonProperty("CapsuleBottomLiftingSurfaceCurve")]
  private PhysicsSettings.LiftingSurfaceCurve _capsuleBottomLiftingSurfaceCurve;
  [JsonProperty("DefaultLiftingSurfaceCurve")]
  private PhysicsSettings.LiftingSurfaceCurve _defaultLiftingSurfaceCurve;
  [JsonProperty("SpeedBrakeLiftingSurfaceCurve")]
  private PhysicsSettings.LiftingSurfaceCurve _SpeedBrakeLiftingSurfaceCurve;
  [JsonProperty("AeroDataDisplay")]
  private bool _aeroDataDisplay;
  [JsonProperty("AeroForceDisplay")]
  private bool _aeroForceDisplay;
  [JsonProperty("AeroGUIDisplay")]
  private bool _aeroGUIDisplay;
  [JsonProperty("AeroForceDisplayScale")]
  private float _aeroForceDisplayScale;
  [JsonProperty("AutoStrutDisplay")]
  private bool _autoStrutDisplay;
  [JsonProperty("DisableTimeWarpWhileUnderThrust")]
  private bool _disableTimeWarpWhileUnderThrust;
  [JsonProperty("IdealGasConstant")]
  private double _idealGasConstant;
  [JsonProperty("BoltzmannConstant")]
  private double _boltzmannConstant;
  [JsonProperty("StefanBoltzmanConstant")]
  private double _stefanBoltzmanConstant;
  [JsonProperty("AvogadroConstant")]
  private double _avogadroConstant;
  [JsonProperty("ThermoGUIDisplay")]
  private bool _thermoGUIDisplay;
  [JsonProperty("ThermalMaxIntegrationWarp")]
  private double _thermalMaxIntegrationWarp;
  [JsonProperty("SpaceTemperature")]
  private double _spaceTemperature;
  [JsonProperty("SolarLuminosity")]
  private double _solarLuminosity;
  [JsonProperty("SolarLuminosityAtHome")]
  private double _solarLuminosityAtHome;
  [JsonProperty("SolarInsolationAtHome")]
  private double _solarInsolationAtHome;
  [JsonProperty("MachConvectionDensityExponent")]
  private double _machConvectionDensityExponent;
  [JsonProperty("MachConvectionVelocityExponent")]
  private double _machConvectionVelocityExponent;
  [JsonProperty("NewtonianDensityExponent")]
  private double _newtonianDensityExponent;
  [JsonProperty("NewtonianConvectionFactorBase")]
  private double _newtonianConvectionFactorBase;
  [JsonProperty("NewtonianConvectionFactorTotal")]
  private double _newtonianConvectionFactorTotal;
  [JsonProperty("NewtonianVelocityExponent")]
  private double _newtonianVelocityExponent;
  [JsonProperty("BlackBodyRadiationMin")]
  private float _blackBodyRadiationMin;
  [JsonProperty("BlackBodyRadiationMax")]
  private float _blackBodyRadiationMax;
  [JsonProperty("BlackBodyRadiationAlphaMult")]
  private float _blackBodyRadiationAlphaMult;
  [JsonProperty("ThermalDataDisplay")]
  private bool _thermalDataDisplay;
  [JsonProperty("ThermalColorsDebug")]
  private bool _thermalColorsDebug;
  [JsonProperty("TemperatureGaugeThreshold")]
  private float _temperatureGaugeThreshold;
  [JsonProperty("TemperatureGaugeHighlightThreshold")]
  private float _temperatureGaugeHighlightThreshold;
  [JsonProperty("RadiationFactor")]
  private double _radiationFactor;
  [JsonProperty("MachConvectionFactor")]
  private double _machConvectionFactor;
  [JsonProperty("MachConvectionConstant")]
  private double _machConvectionConstant;
  [JsonProperty("ConductionFactor")]
  private double _conductionFactor;
  [JsonProperty("ConvectionFactorSplashed")]
  private double _convectionFactorSplashed;
  [JsonProperty("FullToCrossSectionLerpStart")]
  private double _fullToCrossSectionLerpStart;
  [JsonProperty("NewtonianMachTempLerpEndMach")]
  private double _newtonianMachTempLerpEndMach;
  [JsonProperty("NewtonianMachTempLerpStartMach")]
  private double _newtonianMachTempLerpStartMach;
  [JsonProperty("NewtonianMachTempLerpExponent")]
  private double _newtonianMachTempLerpExponent;
  [JsonProperty("MachTemperatureScalar")]
  private double _machTemperatureScalar;
  [JsonProperty("MachTemperatureVelocityExponent")]
  private double _machTemperatureVelocityExponent;
  [JsonProperty("TurbulentConvectionStart")]
  private double _turbulentConvectionStart;
  [JsonProperty("TurbulentConvectionEnd")]
  private double _turbulentConvectionEnd;
  [JsonProperty("TurbulentConvectionMult")]
  private double _turbulentConvectionMult;
  [JsonProperty("FullConvectionAreaMin")]
  private double _fullConvectionAreaMin;
  [JsonProperty("FullToCrossSectionLerpEnd")]
  private double _fullToCrossSectionLerpEnd;
  [JsonProperty("InternalHeatProductionFactor")]
  private double _internalHeatProductionFactor;
  [JsonProperty("NewtonianTemperatureFactor")]
  private double _newtonianTemperatureFactor;
  [JsonProperty("ShieldedConductionFactor")]
  private double _shieldedConductionFactor;
  [JsonProperty("ThermalRadiationEnabled")]
  private bool _thermalRadiationEnabled;
  [JsonProperty("ThermalConductionEnabled")]
  private bool _thermalConductionEnabled;
  [JsonProperty("ThermalConvectionEnabled")]
  private bool _thermalConvectionEnabled;
  [JsonProperty("StandardSpecificHeatCapacity")]
  private double _standardSpecificHeatCapacity;
  [JsonProperty("SkinSkinConductionFactor")]
  private double _skinSkinConductionFactor;
  [JsonProperty("SkinInternalConductionFactor")]
  private double _skinInternalConductionFactor;
  [JsonProperty("ThermalIntegrationMinStep")]
  private double _thermalIntegrationMinStep;
  [JsonProperty("ThermalIntegrationMaxTimeOnePass")]
  private double _thermalIntegrationMaxTimeOnePass;
  [JsonProperty("ThermalIntegrationAlwaysRk2")]
  private bool _thermalIntegrationAlwaysRk2;
  [JsonProperty("OcclusionMinStep")]
  private double _occlusionMinStep;
  [JsonProperty("ThermalIntegrationHighMaxPasses")]
  private int _thermalIntegrationHighMaxPasses;
  [JsonProperty("ThermalIntegrationHighMinPasses")]
  private int _thermalIntegrationHighMinPasses;
  [JsonProperty("ThermalConvergenceFactor")]
  private double _thermalConvergenceFactor;
  [JsonProperty("AnalyticLerpRateSkin")]
  private double _analyticLerpRateSkin;
  [JsonProperty("AnalyticLerpRateInternal")]
  private double _analyticLerpRateInternal;
  [JsonProperty("AnalyticConvectionSensitivityBase")]
  private double _analyticConvectionSensitivityBase;
  [JsonProperty("AnalyticConvectionSensitivityFinal")]
  private double _analyticConvectionSensitivityFinal;
  [JsonProperty("TemperaturePropertyID")]
  private int _temperaturePropertyID;
  [JsonProperty("MinThermalMass")]
  private double _minThermalMass;
  [JsonProperty("ThermalMassIncludesResources")]
  private bool _thermalMassIncludesResources;
  [JsonProperty("BuoyancyScalar")]
  private double _buoyancyScalar;
  [JsonProperty("BuoyancyUseCoBOffset")]
  private bool _buoyancyUseCoBOffset;
  [JsonProperty("BuoyancyApplyForceOnDie")]
  private bool _buoyancyApplyForceOnDie;
  [JsonProperty("BuoyancyForceOffsetLerp")]
  private float _buoyancyForceOffsetLerp;
  [JsonProperty("BuoyancyWaterDragScalar")]
  private double _buoyancyWaterDragScalar;
  [JsonProperty("BuoyancyWaterDragScalarEnd")]
  private double _buoyancyWaterDragScalarEnd;
  [JsonProperty("BuoyancyWaterDragScalarLerp")]
  private double _buoyancyWaterDragScalarLerp;
  [JsonProperty("BuoyancyWaterDragScalarLerpDotMultBase")]
  private double _buoyancyWaterDragScalarLerpDotMultBase;
  [JsonProperty("BuoyancyWaterDragScalarLerpDotMult")]
  private double _buoyancyWaterDragScalarLerpDotMult;
  [JsonProperty("BuoyancyWaterLiftScalarEnd")]
  private double _buoyancyWaterLiftScalarEnd;
  [JsonProperty("BuoyancyWaterDragMinVel")]
  private double _buoyancyWaterDragMinVel;
  [JsonProperty("BuoyancyWaterDragMinVelMult")]
  private double _buoyancyWaterDragMinVelMult;
  [JsonProperty("BuoyancyWaterDragMinVelMultCobOff")]
  private double _buoyancyWaterDragMinVelMultCobOff;
  [JsonProperty("BuoyancyWaterDragPartVelGreaterVesselMult")]
  private double _buoyancyWaterDragPartVelGreaterVesselMult;
  [JsonProperty("BuoyancyWaterDragTimer")]
  private double _buoyancyWaterDragTimer;
  [JsonProperty("BuoyancyWaterDragMultMinForMinDot")]
  private double _buoyancyWaterDragMultMinForMinDot;
  [JsonProperty("BuoyancyWaterAngularDragScalar")]
  private double _buoyancyWaterAngularDragScalar;
  [JsonProperty("BuoyancyAngularDragMinControlSqrMag")]
  private double _buoyancyAngularDragMinControlSqrMag;
  [JsonProperty("BuoyancyWaterAngularDragSlow")]
  private float _buoyancyWaterAngularDragSlow;
  [JsonProperty("BuoyancyWaterDragSlow")]
  private float _buoyancyWaterDragSlow;
  [JsonProperty("BuoyancyWaterDragExtraRbDragAboveDot")]
  private double _buoyancyWaterDragExtraRbDragAboveDot;
  [JsonProperty("BuoyancyScaleAboveDepth")]
  private double _buoyancyScaleAboveDepth;
  [JsonProperty("BuoyancyDefaultVolume")]
  private double _buoyancyDefaultVolume;
  [JsonProperty("BuoyancyMinCrashMult")]
  private float _buoyancyMinCrashMult;
  [JsonProperty("BuoyancyCrashToleranceMult")]
  private float _buoyancyCrashToleranceMult;
  [JsonProperty("MinBuoyancyHeight")]
  private double _minBuoyancyHeight;
  [JsonProperty("MaxBuoyancyHeight")]
  private double _maxBuoyancyHeight;
  [JsonProperty("BuoyancyKerbals")]
  private float _buoyancyKerbals;
  [JsonProperty("BuoyancyKerbalsRagdoll")]
  private double _buoyancyKerbalsRagdoll;
  [JsonProperty("CameraDepthToUnlock")]
  private float _cameraDepthToUnlock;
  [JsonProperty("JointBreakForceFactor")]
  private float _jointBreakForceFactor;
  [JsonProperty("JointBreakTorqueFactor")]
  private float _jointBreakTorqueFactor;
  [JsonProperty("JointForce")]
  private float _jointForce;
  [JsonProperty("RigidJointBreakForceFactor")]
  private float _rigidJointBreakForceFactor;
  [JsonProperty("RigidJointBreakTorqueFactor")]
  private float _rigidJointBreakTorqueFactor;
  [JsonProperty("JointDampingFactor")]
  private float _jointDampingFactor;
  [JsonProperty("EnableGravityEase")]
  private bool _enableGravityEase;
  [JsonProperty("GravityEaseFrames")]
  private double _gravityEaseFrames;
  [JsonProperty("MaxAngularVelocity")]
  private float _maxAngularVelocity;
  [JsonProperty("BuildingImpactDamageMaxVelocityMult")]
  private float _buildingImpactDamageMaxVelocityMult;
  [JsonProperty("BuildingImpactDamageUseMomentum")]
  private bool _buildingImpactDamageUseMomentum;
  [JsonProperty("BuildingEasingInvulnerableTime")]
  private float _buildingEasingInvulnerableTime;
  [JsonProperty("OrbitDriftFramesToWait")]
  private int _orbitDriftFramesToWait;
  [JsonProperty("OrbitDriftSqrThreshold")]
  private double _orbitDriftSqrThreshold;
  [JsonProperty("OrbitDriftAltThreshold")]
  private double _orbitDriftAltThreshold;
  [JsonProperty("ApplyDragToNonPhysicsParts")]
  private bool _applyDragToNonPhysicsParts;
  [JsonProperty("ApplyDragToNonPhysicsPartsAtParentCoM")]
  private bool _applyDragToNonPhysicsPartsAtParentCoM;
  [JsonProperty("DragMultiplier")]
  private float _dragMultiplier;
  [JsonProperty("BodyLiftMultiplier")]
  private float _bodyLiftMultiplier;
  [JsonProperty("DragCubeMultiplier")]
  private float _dragCubeMultiplier;
  [JsonProperty("AngularDragMultiplier")]
  private float _angularDragMultiplier;
  [JsonProperty("KerbalEvaDragCubeString")]
  private string _kerbalEvaDragCubeString;
  [JsonProperty("KerbalCrewMass")]
  private float _kerbalCrewMass;
  [JsonProperty("KerbalGOffset")]
  private double _kerbalGOffset;
  [JsonProperty("KerbalGPower")]
  private double _kerbalGPower;
  [JsonProperty("KerbalGDecayPower")]
  private double _kerbalGDecayPower;
  [JsonProperty("KerbalGBraveMult")]
  private double _kerbalGBraveMult;
  [JsonProperty("KerbalGBadMult")]
  private double _kerbalGBadMult;
  [JsonProperty("KerbalGClamp")]
  private double _kerbalGClamp;
  [JsonProperty("KerbalGThresholdWarn")]
  private double _kerbalGThresholdWarn;
  [JsonProperty("KerbalGThresholdLoc")]
  private double _kerbalGThresholdLoc;
  [JsonProperty("KerbalGlocTimeMult")]
  private double _kerbalGlocTimeMult;
  [JsonProperty("KerbalGlocMaxTimeIncrement")]
  private double _kerbalGlocMaxTimeIncrement;
  [JsonProperty("KerbalGlocBaseTime")]
  private double _kerbalGlocBaseTime;
  [JsonProperty("KerbalGClampGExperienced")]
  private bool _kerbalGClampGExperienced;
  [JsonProperty("CommNetQTimesVelForBlackoutMin")]
  private double _commNetQTimesVelForBlackoutMin;
  [JsonProperty("CommNetQTimesVelForBlackoutMax")]
  private double _commNetQTimesVelForBlackoutMax;
  [JsonProperty("CommNetTempForBlackout")]
  private double _commNetTempForBlackout;
  [JsonProperty("CommNetDensityForBlackout")]
  private double _commNetDensityForBlackout;
  [JsonProperty("CommNetDotForBlackoutMin")]
  private double _commNetDotForBlackoutMin;
  [JsonProperty("CommNetDotForBlackoutMax")]
  private double _commNetDotForBlackoutMax;
  [JsonProperty("CommNetBlackoutThreshold")]
  private double _commNetBlackoutThreshold;
  [JsonProperty("ApplyDrag")]
  private bool _applyDrag;
  [JsonProperty("DragUsesAcceleration")]
  private bool _dragUsesAcceleration;
  [JsonProperty("DragCubesUseSpherical")]
  private bool _dragCubesUseSpherical;
  [JsonProperty("DragCurveTip")]
  private FloatCurve _dragCurveTip;
  [JsonProperty("DragCurveSurface")]
  private FloatCurve _dragCurveSurface;
  [JsonProperty("DragCurveTail")]
  private FloatCurve _dragCurveTail;
  [JsonProperty("DragCurveMultiplier")]
  private FloatCurve _dragCurveMultiplier;
  [JsonProperty("DragCurveCd")]
  private FloatCurve _dragCurveCd;
  [JsonProperty("DragCurveCdPower")]
  private FloatCurve _dragCurveCdPower;
  [JsonProperty("DragCurvePseudoReynolds")]
  private FloatCurve _dragCurvePseudoReynolds;
  public static PhysicsSettings.SurfaceCurvesList SurfaceCurves;
  [JsonProperty("LiftMultiplier")]
  private float _liftMultiplier;
  [JsonProperty("LiftDragMultiplier")]
  private float _liftDragMultiplier;
  [JsonProperty("REENTRY_FX_ATMOSPHERIC_DENSITY_THRESHOLD")]
  private float _reentryFXAtmosphericDensityThreshold;
  [JsonProperty("REENTRY_FX_MINIMUM_FLUX")]
  private float _reentryFXMinimumFlux;
  [JsonProperty("REENTRY_FX_MAXIMUM_FLUX")]
  private float _reentryFXMaximumFlux;
  [JsonProperty("REENTRY_FX_VERTICAL_SPEED_THRESHOLD")]
  private float _reentryFXVerticalSpeedThreshold;
  [JsonProperty("REENTRY_FX_TUNING_CONSTANT")]
  private float _reentryFXTuningConstant;
  [JsonProperty("VAPORCONE_FX_MACH_THRESHOLD")]
  private float _vaporconeFXMachThreshold;
  [JsonProperty("VAPORCONE_FX_MACH_MINIMUM")]
  private float _vaporconeFXMachMinimum;
  [JsonProperty("VAPORCONE_FX_MACH_MAXIMUM")]
  private float _vaporconeFXMachMaximum;
  [JsonProperty("AutoStrutTechRequired")]
  private string _autoStrutTechRequired;
  [JsonProperty("StagingCooldownTimer")]
  private float _stagingCooldownTimer;
  [JsonProperty("SolarOrbitHeatTolerance")]
  private float _solarOrbitHeatTolerance;
  public const float EngineDefaultAtmDensity = 1.225f;
  [JsonProperty("SecondsInMinute")]
  private int _secondsInMinute;
  [JsonProperty("MinutesInHour")]
  private int _minutesInHour;
  [JsonProperty("HoursInDay")]
  private int _hoursInDay;
  [JsonProperty("DaysInYear")]
  private int _daysInYear;
  private int _secondsInHour;
  private int _secondsInDay;
  private int _secondsInYear;
  private double _yearsInSecond;

  protected override string CurrentVersionString
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public PhysicsSettings() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void Initialize(PhysicsSettings physicsSettings) => throw null;

  public static TimeWarp.TimeWarpLevel[] TimeWarpLevels
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public static double GLOBAL_ENVIRONMENT_FLUX_SCALE
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double GLOBAL_ATMOSPHERE_FLUX_SCALE
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double GLOBAL_BODY_LOCAL_FLUX_SCALE
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double GLOBAL_BODY_SURFACE_FLUX_SCALE
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double GLOBAL_POSITIVE_PART_TEMPERATURE_CHANGE_RATE_SCALE
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double GLOBAL_NEGATIVE_PART_TEMPERATURE_CHANGE_RATE_SCALE
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double GLOBAL_BACKGROUND_PART_TEMPERATURE_CHANGE_RATE_SCALE
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double GLOBAL_ENGINE_EXHAUST_FLUX_SCALE
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double GLOBAL_REENTRY_FLUX_SCALE
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double PHYSX_RB_SQR_MAG_THRESHOLD
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static float PHYSX_MASS_TOLERANCE
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double PHYSX_MINIMUM_PART_MASS
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static float JOINT_RIGIDITY
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static float JOINT_SURFACE_NODE_FACTOR
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static float JOINT_STACK_NODE_FACTOR
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static float JOINT_STACK_ATTACH_STIFFNESS
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static float JOINT_SURFACE_ATTACH_STIFFNESS
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static bool ENABLE_MULTI_JOINT
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static bool ENABLE_SCALED_SOLVER_ITERATION
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static bool ENABLE_PART_TO_PART_COLLISIONS
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static bool ENABLE_RIGIDBODY_SLEEPING
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static bool ENABLE_INERTIA_TENSOR_SCALING
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double KSC_COMM_NET_RANGE_METERS
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static float GLOBAL_TENSOR_SCALAR
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static float GLOBAL_LOWMASS_TENSOR_SCALAR
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static float GLOBAL_LOWMASS_TENSOR_LIMIT
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static float GLOBAL_EJECTION_FORCE_SCALING_LOWMASS_LIMIT
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static float GLOBAL_EJECTION_FORCE_SCALE
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static bool ENABLE_DYNAMIC_TENSOR_SOLUTION
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static bool DEBUG_DISABLE_JOINTS
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static PhysicsSettings.LiftingSurfaceCurve BodyLiftLiftingSurfaceCurve
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public static PhysicsSettings.LiftingSurfaceCurve CapsuleBottomLiftingSurfaceCurve
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public static PhysicsSettings.LiftingSurfaceCurve DefaultLiftingSurfaceCurve
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public static PhysicsSettings.LiftingSurfaceCurve SpeedBrakeLiftingSurfaceCurve
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public static bool AeroDataDisplay
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static bool AeroForceDisplay
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static bool AeroGUIDisplay
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static float AeroForceDisplayScale
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static bool AutoStrutDisplay
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static bool DisableTimeWarpWhileUnderThrust
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double IdealGasConstant
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public static double BoltzmannConstant
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public static double StefanBoltzmanConstant
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public static double AvogadroConstant
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public static bool ThermoGUIDisplay
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double ThermalMaxIntegrationWarp
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double SpaceTemperature
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double SolarLuminosity
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double SolarLuminosityAtHome
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double SolarInsolationAtHome
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double MachConvectionDensityExponent
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double MachConvectionVelocityExponent
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double NewtonianDensityExponent
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double NewtonianConvectionFactorBase
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double NewtonianConvectionFactorTotal
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double NewtonianVelocityExponent
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static float BlackBodyRadiationMin
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static float BlackBodyRadiationMax
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static float BlackBodyRadiationAlphaMult
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static bool ThermalDataDisplay
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static bool ThermalColorsDebug
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static float TemperatureGaugeThreshold
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static float TemperatureGaugeHighlightThreshold
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double RadiationFactor
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double MachConvectionFactor
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double MachConvectionConstant
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double ConductionFactor
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double ConvectionFactorSplashed
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double FullToCrossSectionLerpStart
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double NewtonianMachTempLerpEndMach
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double NewtonianMachTempLerpStartMach
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double NewtonianMachTempLerpExponent
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double MachTemperatureScalar
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double MachTemperatureVelocityExponent
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double TurbulentConvectionStart
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double TurbulentConvectionEnd
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double TurbulentConvectionMult
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double FullConvectionAreaMin
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double FullToCrossSectionLerpEnd
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double InternalHeatProductionFactor
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double NewtonianTemperatureFactor
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double ShieldedConductionFactor
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static bool ThermalRadiationEnabled
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static bool ThermalConductionEnabled
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static bool ThermalConvectionEnabled
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double StandardSpecificHeatCapacity
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double SkinSkinConductionFactor
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double SkinInternalConductionFactor
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double ThermalIntegrationMinStep
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double ThermalIntegrationMaxTimeOnePass
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static bool ThermalIntegrationAlwaysRk2
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double OcclusionMinStep
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static int ThermalIntegrationHighMaxPasses
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static int ThermalIntegrationHighMinPasses
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double ThermalConvergenceFactor
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double AnalyticLerpRateSkin
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double AnalyticLerpRateInternal
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double AnalyticConvectionSensitivityBase
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double AnalyticConvectionSensitivityFinal
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static int TemperaturePropertyID
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double MinThermalMass
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static bool ThermalMassIncludesResources
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double BuoyancyScalar
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static bool BuoyancyUseCoBOffset
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static bool BuoyancyApplyForceOnDie
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static float BuoyancyForceOffsetLerp
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double BuoyancyWaterDragScalar
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double BuoyancyWaterDragScalarEnd
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double BuoyancyWaterDragScalarLerp
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double BuoyancyWaterDragScalarLerpDotMultBase
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double BuoyancyWaterDragScalarLerpDotMult
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double BuoyancyWaterLiftScalarEnd
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double BuoyancyWaterDragMinVel
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double BuoyancyWaterDragMinVelMult
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double BuoyancyWaterDragMinVelMultCobOff
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double BuoyancyWaterDragPartVelGreaterVesselMult
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double BuoyancyWaterDragTimer
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double BuoyancyWaterDragMultMinForMinDot
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double BuoyancyWaterAngularDragScalar
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double BuoyancyAngularDragMinControlSqrMag
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static float BuoyancyWaterAngularDragSlow
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static float BuoyancyWaterDragSlow
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double BuoyancyWaterDragExtraRbDragAboveDot
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double BuoyancyScaleAboveDepth
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double BuoyancyDefaultVolume
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static float BuoyancyMinCrashMult
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static float BuoyancyCrashToleranceMult
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double MinBuoyancyHeight
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double MaxBuoyancyHeight
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static float BuoyancyKerbals
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double BuoyancyKerbalsRagdoll
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static float CameraDepthToUnlock
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static float JointBreakForceFactor
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static float JointBreakTorqueFactor
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static float JointForce
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static float RigidJointBreakForceFactor
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static float RigidJointBreakTorqueFactor
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static float JointDampingFactor
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static bool EnableGravityEase
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double GravityEaseFrames
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static float MaxAngularVelocity
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static float BuildingImpactDamageMaxVelocityMult
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static bool BuildingImpactDamageUseMomentum
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static float BuildingEasingInvulnerableTime
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static int OrbitDriftFramesToWait
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double OrbitDriftSqrThreshold
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double OrbitDriftAltThreshold
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static bool ApplyDragToNonPhysicsParts
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static bool ApplyDragToNonPhysicsPartsAtParentCoM
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static float DragMultiplier
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static float BodyLiftMultiplier
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static float DragCubeMultiplier
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static float AngularDragMultiplier
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static string KerbalEvaDragCubeString
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static float KerbalCrewMass
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double KerbalGOffset
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double KerbalGPower
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double KerbalGDecayPower
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double KerbalGBraveMult
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double KerbalGBadMult
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double KerbalGClamp
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double KerbalGThresholdWarn
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double KerbalGThresholdLoc
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double KerbalGlocTimeMult
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double KerbalGlocMaxTimeIncrement
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double KerbalGlocBaseTime
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static bool KerbalGClampGExperienced
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double CommNetQTimesVelForBlackoutMin
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double CommNetQTimesVelForBlackoutMax
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double CommNetTempForBlackout
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double CommNetDensityForBlackout
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double CommNetDotForBlackoutMin
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double CommNetDotForBlackoutMax
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static double CommNetBlackoutThreshold
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static bool ApplyDrag
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static bool DragUsesAcceleration
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static bool DragCubesUseSpherical
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static FloatCurve DragCurveTip
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public static FloatCurve DragCurveSurface
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public static FloatCurve DragCurveTail
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public static FloatCurve DragCurveMultiplier
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public static FloatCurve DragCurveCd
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public static FloatCurve DragCurveCdPower
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public static FloatCurve DragCurvePseudoReynolds
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static float DragCurveValue(
    PhysicsSettings.SurfaceCurvesList curvesList,
    float dotNormalized,
    float mach)
  {
    throw null;
  }

  public static float LiftMultiplier
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static float LiftDragMultiplier
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static Dictionary<string, PhysicsSettings.LiftingSurfaceCurve> LiftingSurfaceCurves
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static PhysicsSettings.LiftingSurfaceCurve GetLiftingSurfaceCurve(string name) => throw null;

  public static float REENTRY_FX_ATMOSPHERIC_DENSITY_THRESHOLD
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static float REENTRY_FX_MINIMUM_FLUX
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static float REENTRY_FX_MAXIMUM_FLUX
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static float REENTRY_FX_VERTICAL_SPEED_THRESHOLD
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static float REENTRY_FX_TUNING_CONSTANT
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static float VAPORCONE_FX_MACH_THRESHOLD
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static float VAPORCONE_FX_MACH_MINIMUM
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static float VAPORCONE_FX_MACH_MAXIMUM
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static string AutoStrutTechRequired
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static float StagingCooldownTimer
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static float SolarOrbitHeatTolerance
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static int SecondsInMinute
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static int MinutesInHour
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static int HoursInDay
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static int DaysInYear
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static int SecondsInHour
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public static int SecondsInDay
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public static int SecondsInYear
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public static double YearsInSecond
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void RecalcCalendarValues() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static PhysicsSettings() => throw null;

  public struct SurfaceCurvesList
  {
    public FloatCurve DragCurveTail;
    public FloatCurve DragCurveSurface;
    public FloatCurve DragCurveMultiplier;
    public FloatCurve DragCurveTip;
  }

  [Serializable]
  public class LiftingSurfaceCurve
  {
    public string name;
    public FloatCurve liftCurve;
    public FloatCurve liftMachCurve;
    public FloatCurve dragCurve;
    public FloatCurve dragMachCurve;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LiftingSurfaceCurve() => throw null;
  }
}
