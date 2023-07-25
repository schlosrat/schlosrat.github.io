// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.VesselComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Logging;
using KSP.Messages;
using KSP.Modules;
using KSP.Sim.Converters;
using KSP.Sim.Definitions;
using KSP.Sim.DeltaV;
using KSP.Sim.Maneuver;
using KSP.Sim.ResourceSystem;
using KSP.Sim.State;
using KSP.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.impl
{
  public class VesselComponent : ObjectComponent, IPhysicsOwner
  {
    private const LogFilter LOGFLAG = (LogFilter) 8388608;
    private const string ELECTRIC_CHARGE_RESOURCE_NAME = "ElectricCharge";
    private static readonly string LOGTAG_BASE;
    private static readonly string CMDTAG_BASE;
    private const int TELEPORT_CLOSE_ENOUGH_ALTITUDE = 5000;
    private const double PRELAUNCH_MOVEMENT_VELOCITY_THRESHOLD = 2.5;
    private const double OUT_OF_ELECTRIC_CHARGE_TOLERANCE = 0.0001;
    private string logTag;
    private string cmdTag;
    private ResourceDefinitionID _electricChargeResourceID;
    private double _electricityPercentage;
    private bool _isVesselOutOFEC;
    private bool? _autopilotState;
    private AutopilotMode? _autopilotMode;
    private UniverseModel _universeModel;
    private int _numBurnPatches;
    private int _currentBurnIndex;
    private PhysicsMode _physicsMode;
    private NotificationData _insufficientVesselControlNotification;
    private List<PartComponentModule_Command> _reusableCommandModuleStorage;
    private Dictionary<IGGuid, VesselComponent.SubVesselData> _subVesselDatas;
    private List<IGGuid> _allVesselTravelIDs;
    private IGGuid _travelObjectId;
    private double _convectiveMachLerp;
    private CelestialBodyComponent _mainBody;
    private SpeedDisplayMode _autoSpeedMode;
    private SpeedDisplayMode speedDisplayModeInternal;
    private AltimeterDisplayMode altimeterModeInternal;
    private FlightControlsMode flightControlsModeInternal;
    private Vector _targetVelocity;
    public Vector lastOrbitalVel;
    public Vector lastSurfaceVel;
    private static int _accelSmoothingMaxNumSamples;
    private SimpleMovingAverage _orbitalAccelSmoother;
    private SimpleMovingAverage _surfaceAccelSmoother;
    private static float minRotThresholdForMessageSending;
    private double lastYawHorizonRelative;
    private double lastPitchHorizonRelative;
    private double lastRollHorizonRelative;
    private double _launchTime;
    private TravelObjectVesselUpdateData _travelLogStatistics;
    private VesselSituations _situation;
    private VesselSituations _lastSituation;
    private bool _resetVesselSituationReady;
    private bool _isVesselSituationReady;
    private int _vesselSituationReadyFramesDelay;
    private int _vesselSituationReadyFrameNumber;
    private bool _hasLandedAtRestFired;
    private bool _hasSplashedAtRestFired;
    private bool _landed;
    private bool _hasLaunched;
    private bool _hasTeleported;
    private int _totalCommandCrewCapacity;
    private static double NullHorizonRelative;
    private bool _loadedFromSave;
    private bool _splashed;
    private bool _isControllable;
    private VesselControlState _vesselControlState;
    private VesselControlState _lastVesselControlState;
    private CommandControlState _commandControlState;
    private CommandControlState _lastCommandControlState;
    private bool _hasCommandModule;
    private bool _isVesselBeingRecovered;
    private SubscriptionHandle _commandChangedHandle;
    private PartComponent _lastPartActivated;
    private DictionaryValueList<IGGuid, List<(Camera, int)>> _cameraLookupByPart;
    public string landedAt;
    public string displaylandedAt;
    public string landedAtLast;
    public OABProvider.LaunchLocation OriginalLaunchLocation;
    private VesselStatus _state;
    private FlightCtrlState _flightCtrlState;
    private VesselActionGroups _actionGroupList;
    private FlightCameraContext _cameraContext;
    private SimulationObjectModel targetObjectInternal;
    private IGGuid _targetIdForPostStartSet;
    private bool _targetSpeedModeForPostStartSet;
    private TransformModel controlTransform;
    private List<Data_Drag> _dragData;
    private PartComponent controlTransformOwner;
    private IGGuid _controlOwnerPartIdForPostStartSet;
    private Dictionary<ResourceDefinitionID, ContainedResourceData> fuelCapacity;
    private bool _fuelNeedsRecalculating;

    [TypeConverterIgnore]
    public override System.Type Type
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public override System.Type DefinitionType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public override System.Type StateType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public override System.Type ViewObjectComponentType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IGGuid TravelObjectId
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float OffsetToGround
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool IsOrbitalPhysicsUnderThrustActive
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PhysicsMode Physics
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ParentToInertialReferenceFrame() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsChildOfInertialReferenceFrame() => throw null;

    public event Action<PhysicsMode> PhysicsChanged
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event Action OnOrbitalPhysicsUnderThrustStart
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event Action OnOrbitalPhysicsUnderThrustEnd
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public CelestialBodyComponent mainBody
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public event Action<SpeedDisplayMode> speedModeChanged
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public SpeedDisplayMode speedMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public event Action<AltimeterDisplayMode> altimeterModeChanged
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public AltimeterDisplayMode altimeterMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public event Action<FlightControlsMode> flightControlsModeChanged
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public FlightControlsMode flightControlsMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    private TelemetryComponent _telemetryComponent
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double Longitude
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double Latitude
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double AltitudeFromRadius
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double AltitudeFromTerrain
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double AltitudeFromSeaLevel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double AltitudeFromScenery
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double AltitudeFromSurface
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector OrbitalVelocity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector SurfaceVelocity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector TargetVelocity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double TargetSpeed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double OrbitalSpeed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector AccelerationOrbitalSmoothed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Vector AccelerationOrbital
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Vector AccelerationSurfaceSmoothed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Vector AccelerationSurface
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Vector PerturbationSmoothed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Vector Perturbation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double specificAcceleration
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Position CenterOfMass
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector MOI
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Velocity Velocity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public AngularVelocity AngularVelocity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public AngularVelocity angularMomentum
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public AngularVelocity AngularVelocityMassAvg
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Velocity VelocityMassAvg
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double geeForce
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double geeForce_immediate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double gravityMultiplier
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Vector graviticAcceleration
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Vector gravityForPos
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector gravityTrue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool frameWasRotating
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double VerticalSrfSpeed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double HorizontalSrfSpeed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double VerticalSrfSpeedMagnitude
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double SrfSpeedMagnitude
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double ExternalTemperature
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double AtmosphericTemperature
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double StaticPressure_kPa
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double DynamicPressure_kPa
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double AtmDensity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double SoundSpeed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double MachNumber
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsInAtmosphere
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double DragCoefficient
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double ExposedArea
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double DistanceToSun
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool IsAeroActive
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double Heading
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double Zenith
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double Yaw_HorizonRelative
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double Pitch_HorizonRelative
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double Roll_HorizonRelative
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double ReEntryMaximumFlux
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double convectiveMachFlux
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double convectiveCoefficient
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double solarFlux
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool directSunlight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double totalMass
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double waterOffset
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double launchTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string landedAtBase
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double landedAtBaseTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Vector3 CurrentCoM
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public VesselSituations Situation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool HasLaunched
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool HasTeleported
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool justLaunched
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool HasLaunchedOrTeleported
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool LoadedFromSave
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public event Action<bool, bool> landedSituationChanged
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public bool Landed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool Splashed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool IsControllable
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public VesselControlState ControlStatus
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool HasCommandModule
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsVesselRecoverable
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int TotalCommandCrewCapacity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool LandedOrSplashed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsFlying
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public List<(Camera, int)> AllCrewCamerasInVessel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double TimeSinceLaunch
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public VesselStatus state
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public FlightCtrlState flightCtrlState
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ApplyFlightCtrlState(FlightCtrlStateIncremental stateDiff) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetFlightControlState(FlightCtrlState state, bool isRemote = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SetTargetByID(IGGuid targetId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearTarget() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsDebris() => throw null;

    public event Action<IReadOnlyList<(Camera, int)>> OnLiveCamerasUpdated
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPartsRemoved(List<PartComponent> parts) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryRemoveLiveCamerasFromVessel(IGGuid partGuid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddPartCamerasToVesselCameraList(
      IGGuid partGuid,
      List<(Camera, int)> updatedPartCameras)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SendPortaitViewsToUIOnVesselChange(MessageCenterMessage msm) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EnsureValidPortraitViews() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ActivateNextStage() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RecoverVessel(IGGuid recoveryLocation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasControlForEditingManeuvers() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasControlForEditingStagingStack() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasControlForManualYawPitchRoll() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasControlForThrottleMinMax() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasControlForThrottleDelta() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void NotifyInsufficientVesselControl() => throw null;

    public VesselAutopilot Autopilot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public AutopilotStatus AutopilotStatus
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SetAutopilotMode(AutopilotMode mode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SetAutopilotEnableDisable(bool state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsUnderThrust() => throw null;

    public bool IsKerbalEVA
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool IsRCSEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnLateUpdate(double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnUpdate(double universalTime, double deltaUniversalTime) => throw null;

    public IGGuid TargetObjectId
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public SimulationObjectModel TargetObject
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public event Action<SimulationObjectModel> OnTargetObjectChanged
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public bool HasTargetObject
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public event Action<bool> OnHasTargetChanged
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public ITransformModel ControlTransform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetControlOwner(IGGuid partId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetControlOwner(PartComponent part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetControlOwnerToDefault() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartComponent GetControlOwner() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LoadedFromSaveFile() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetControlTransformDefault() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPartControlPointChanged(MessageCenterMessage msg) => throw null;

    [TypeConverterIgnore]
    public OrbiterComponent Orbiter
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public VesselDeltaVComponent VesselDeltaV
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public PatchedConicsOrbit Orbit
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VesselComponent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VesselComponent(AssemblyDefinition vesselDefinition, UniverseModel universeModel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SetDefinition(object definitionData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string RevealName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string RevealDisplayName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double RevealSpeed() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double RevealAltitude() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string RevealSituationString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string RevealType() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float RevealMass() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetSubVesselDataByRootPartId(
      IGGuid rootPartId,
      out VesselComponent.SubVesselData result)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetSubVesselDataByAttachPartId(
      IGGuid attachPartId,
      out VesselComponent.SubVesselData result)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddSubVesselData(VesselComponent.SubVesselData subVesselData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool RemoveSubVesselData(VesselComponent.SubVesselData subVesselData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<IGGuid> GetAllVesselTravelIds() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void RestoreTravelObjectId(IGGuid replacementId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselDestroyed(bool notifyObservers) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLandedAtBase(string baseID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object GetDefinition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object GetState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool ValidateState(object stateData, ISimulationModelMap simulationModelMap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAutopilotState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object SetState(object stateData, ISimulationModelMap modelMap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnStart(double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnAdded(SimulationObjectModel simulationObject, double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnRemoved(SimulationObjectModel simulationObject, double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SimulationObject_onComponentAdded(System.Type componentType, ObjectComponent component) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SimulationObject_onComponentRemoved(System.Type componentType, ObjectComponent component) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SimulationObject_onStarted() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnOrbiterComponentAdded(OrbiterComponent orbiter) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnOrbiterComponentRemoved(OrbiterComponent orbiter) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnManeuverPlanComponentAdded(ManeuverPlanComponent maneuverPlan) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnManeuverPlanComponentRemoved(ManeuverPlanComponent maneuverPlan) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPartOwnerComponentAdded() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPartOwnerComponentRemoved() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OrbiterReferenceBodyChange(
      OrbiterComponent orbiter,
      CelestialBodyComponent newReferenceBody)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnManeuverNodeAdded(System.Guid nodeId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnManeuverNodesRemoved(List<ManeuverNodeData> nodes) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnManeuverNodeBurnChanged(System.Guid nodeId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnManeuverNodePositionChanged(System.Guid nodeId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPartsChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnUpdateHeadingDirections() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateHorizonRelativeRotations() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnUpdateTargetVelocities() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnUpdateOrbit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnUpdateOrbitUnderThrust() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IPatchedOrbit GetEndBurnOrbit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnUpdateTargeting() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnUpdateSpeedMode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnUpdateAutoCameraMode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnUpdateAeroStats() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnUpdateTravelLogData(double universalTime, double deltaUniversalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void ClearVesselPreLaunch() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateVesselSituation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleVesselLaunchedMessages() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleVesselLandedMessages() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleVesselSplashedMessages() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RefreshDragData() => throw null;

    public double FuelPercentage
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double StageFuelPercentage
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RecalculateFuel() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RefreshFuelPercentages() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double CalculateVesselFuel() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double CalculateVesselStageFuel() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double CalculateVesselElectricity() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnFixedUpdate(double universalTime, double deltaUniversalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateAcceleration(double deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnUpdateControllableStatus(MessageCenterMessage msgRaw) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateControllableStatus() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetKerbalEVA(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetRCSEnabled(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual double CalculateConvectiveCoefficient() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual double CalculateConvectiveCoefficientNewtonian() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual double CalculateConvectiveCoefficientMach() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetModelPhysicsMode(PhysicsMode physics) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleOrbitalPhysicsUnderThrustStart() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleOrbitalPhysicsUnderThrustEnd() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private PatchTransitionType GetPatchEndTransitionType(PatchedNBodyOrbit patchedNBodyOrbit) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsVesselAtRest() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<CrewMemberComponent> GetVesselCrew() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RebuildActionGroups() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool AddActionToActionGroup(ModuleActionGroupAction action, KSPActionGroup group) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool RemoveActionFromActionGroup(ModuleActionGroupAction action, KSPActionGroup group) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TriggerActionGroup(KSPActionGroup group) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetActionGroup(KSPActionGroup group, bool newState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KSPActionGroupState GetActionGroupState(KSPActionGroup group) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetActionGroupPartCount(KSPActionGroup group) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetDecouplerCount() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPartBehaviourDestroyed(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselUndocked(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselDecouple(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartComponent LastPartActivated() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPartModuleActionActivated(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselChangedMessage(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCameraModeChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool HasSourceOfControl(
      out PartComponent firstCommandPart,
      out Data_Command dataCommand)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void AutoPopulateCrewPartIfNeeded() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AutoPopulatePart(PartComponent partToPopulate, Data_Command dataCommand) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Debug_TeleportToOrbit(string celestialBodyGuid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Debug_TeleportToOrbit(
      string celestialBodyGuid,
      double inclination,
      double eccentricity,
      double semiMajorAxis,
      double longitudeOfAscendingNode,
      double argumentOfPeriapsis,
      double meanAnomalyAtEpoch,
      double epoch)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Debug_TeleportToSurface(string celestialBodyGuid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Debug_TeleportToSurface(
      string celestialBodyGuid,
      double altitude,
      double latitude,
      double longitude,
      double localVerticalSpeed)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator Debug_TeleportToSurfaceCoroutine(
      string celestialBodyGuid,
      double altitude,
      double latitude,
      double longitude,
      double localVerticalSpeed)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Debug_TeleportToSurfaceInternal(
      string celestialBodyGuid,
      double altitude,
      double latitude,
      double longitude,
      double localVerticalSpeed)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Debug_TeleportToRendezvous(
      SimulationObjectModel targetObject,
      Vector3d offset,
      Vector3d rotationDeg)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    static VesselComponent() => throw null;

    [Serializable]
    public struct SubVesselData
    {
      public IGGuid AttachPartId;
      public IGGuid VesselId;
      public string VesselName;
      public IGGuid RootPartId;
      public IGGuid ControlPointPartId;
      public int PartCount;
      public double UniverseTimeGenerated;
      public IGGuid TravelObjectId;
    }
  }
}
