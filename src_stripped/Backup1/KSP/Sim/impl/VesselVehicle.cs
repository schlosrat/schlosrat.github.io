// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.VesselVehicle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Controllability;
using KSP.Sim.State;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class VesselVehicle : 
    IVehicle,
    IControllableInput,
    IControlInput,
    IVehicleControlsReader,
    IFlightControllableInput,
    IFlightControlInput,
    IFlightControlReader,
    IOrbitControllableInput,
    IOrbitControlInput,
    IOrbitControlReader,
    IOrbitTelemetry,
    IFlightTelemetry,
    IVehicleTelemetry,
    IControllableActionGroups,
    IActionGroups
  {
    private readonly UniverseModel _universeModel;
    private VesselComponent _vessel;
    private SimulationObjectModel _simulationObjectModel;
    private TelemetryComponent _telemetry;
    private ActionGroupStates actionGroups;
    private bool landedOrSplashed;
    private bool patchedConicsAttached;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private VesselComponent InternalGetSimVessel() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    private static bool IsSimVesselValid(VesselComponent vessel, bool requireValidInSim = true) => throw null;

    public IGGuid Guid
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsValidInSim
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public SimulationObjectModel SimulationObject
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimulationObjectModel GetSimulationObject(bool requireValidInSim = true) => throw null;

    public bool IsLandedOrSplashed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public bool TryGetSimVessel(out VesselComponent vessel, bool requireValidInSim = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public VesselComponent GetSimVessel(bool requireValidInSim = true) => throw null;

    public bool HaveTarget
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public SimulationObjectModel Target
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IFlightControlInput FlightControlInput
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IOrbitControlInput OrbitControlInput
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public CelestialBodyComponent MainBody
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IVehicleTelemetry VehicleTelemetry
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IFlightTelemetry FlightTelemetry
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IOrbitTelemetry OrbitTelemetry
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public SpeedDisplayMode SpeedDisplayMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public event Action<SpeedDisplayMode> OnSpeedDisplayModeChange
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSpeedDisplayMode(SpeedDisplayMode mode, Action<string> callback = null) => throw null;

    public AltimeterDisplayMode AltimeterDisplayMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public event Action<AltimeterDisplayMode> OnAltimeterDisplayModeChange
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAltimeterDisplayMode(AltimeterDisplayMode value, Action<string> callback = null) => throw null;

    public FlightControlsMode FlightControlsMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public event Action<FlightControlsMode> OnFlightControlsModeChange
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetFlightControlsMode(FlightControlsMode value, Action<string> callback = null) => throw null;

    public IControllableInput ControllableInput
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public IFlightControllableInput FlightControllableInput
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public IOrbitControllableInput OrbitControllableInput
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public IControllableActionGroups ControllableActionGroups
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float wheelSteer
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float wheelSteerTrim
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float wheelThrottle
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float wheelThrottleTrim
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool headlight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool brakes
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float mainThrottle
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float roll
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float yaw
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float pitch
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float rollTrim
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float yawTrim
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float pitchTrim
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool killRot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool gearUp
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool gearDown
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float X
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float Y
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float Z
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAutopilotMode(AutopilotMode value, Action<string> callback = null) => throw null;

    public ActionGroupStates ActionGroups
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public event Action<KSPActionGroup, bool> OnActionGroupChanged
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetGroup(KSPActionGroup group, bool value, Action<string> callback = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TriggerGroup(KSPActionGroup group, Action<string> callback = null) => throw null;

    public ITransformFrame ObservationFrame
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector ObservationForward
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Rotation GetNavballRotationForForward(Vector viewerForward) => throw null;

    public Vector TargetVelocity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double TargetSpeed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double SpecificAcceleration
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public AngularVelocity AngularVelocity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Position Position
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Position CenterOfMass
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector MomentOfInertia
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Vector AngularMomentum
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Rotation Rotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Velocity Velocity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double Heading
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    Vector IVehicleTelemetry.GetDisplayVelocityVector() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetDisplayAltitude() => throw null;

    public Vector SurfacePrograde
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector SurfaceRetrograde
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector North
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector East
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector Up
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector SurfaceVelocity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double SurfaceSpeed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double VerticalSpeed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double HorizontalSpeed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double Latitude
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double Longitude
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double AltitudeFromRadius
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double AltitudeFromSeaLevel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double AltitudeFromTerrain
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

    public double StaticPressurekPa
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double DynamicPressurekPa
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double AtmosphericTemperature
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double ExternalTemperature
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double AtmosphericDensity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double AtmosphericDensityNormalized
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

    public double GeeForce
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool LandedOrSplashed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool PatchedConicsAttached
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector OrbitPrograde
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector OrbitRetrograde
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector OrbitNormal
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector OrbitAntiNormal
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector OrbitRadialIn
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector OrbitRadialOut
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector OrbitalVelocity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double OrbitalSpeed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IOrbit Orbit
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VesselVehicle(
      SpaceSimulation spaceSimulation,
      IModelViewMap modelViewMap,
      VesselComponent vessel,
      UniverseModel universeModel,
      IViewController viewController,
      bool controllable)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CanPlayerControl(byte playerId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SyncTo(VesselComponent vessel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AtomicSet(
      float? wheelSteer,
      float? wheelSteerTrim,
      float? wheelThrottle,
      float? wheelThrottleTrim,
      bool? headlight)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AtomicSet(
      float? mainThrottle,
      float? roll,
      float? yaw,
      float? pitch,
      float? rollTrim,
      float? yawTrim,
      float? pitchTrim,
      float? wheelSteer,
      float? wheelSteerTrim,
      float? wheelThrottle,
      float? wheelThrottleTrim,
      bool? killRot,
      bool? gearUp,
      bool? gearDown,
      bool? headlight)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AtomicSet(
      float? mainThrottle,
      float? roll,
      float? yaw,
      float? pitch,
      float? rollTrim,
      float? yawTrim,
      float? pitchTrim,
      float? wheelSteer,
      float? wheelSteerTrim,
      float? wheelThrottle,
      float? wheelThrottleTrim,
      float? X,
      float? Y,
      float? Z,
      bool? killRot,
      bool? gearUp,
      bool? gearDown,
      bool? headlight)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AtomicSet(FlightCtrlStateIncremental flightControlUpdate) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetGroup(KSPActionGroup group) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ActionGroupStates GetGroupStates() => throw null;
  }
}
