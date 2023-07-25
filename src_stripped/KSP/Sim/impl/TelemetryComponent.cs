// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.TelemetryComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Logging;
using KSP.Rendering.Planets;
using KSP.Sim.Converters;
using KSP.Sim.Definitions;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class TelemetryComponent : ObjectComponent
  {
    private const LogFilter LOGFLAG = (LogFilter) 4194304;
    private static readonly string LOGTAG;
    private static readonly string CMDTAG;
    private string logTag;
    private string cmdTag;
    private IUniverseModel universeModel;
    private ITransformModel rootTransformInternal;
    private OrbiterComponent orbiter;
    private CelestialBodyComponent mainBody;
    private ITransformModel soiTransformInternal;
    private ITransformModel observationTransformInternal;
    private ITransformModel horizonTransformInternal;
    private Vector3d surfaceLocalVelocity;
    private Vector3d surfaceUpRef;
    private ITransformModel orbitMovementTransformInternal;
    public Position HighlightTarget;
    public Vector OrbitHighlightDirection;
    private ITransformModel targetTransformInternal;
    private Vector _targetOrbitalVelocity;
    public double VesselAtmosphericPressureKpa;
    private ConnectionGraphNode _commNetControlSourceNode;
    private TransformModel _commNetControlSourceTransform;
    private Vector3d _positionFromCommNetControlSource;
    private ConnectionNodeStatus _commNetConnectionStatus;
    private ConnectionGraphNode _commNetNode;
    private double _commNetRangeMeters;
    private NotificationData _outOfRangeNotificationData;

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

    public event Action TelemetryUpdated
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event Action TelemetryDisplayUpdated
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public ITransformFrame RootFrameBody
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ITransformFrame RootFrameCelestial
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Position RootPosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Rotation RootRotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Velocity RootVelocity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public AngularVelocity RootVelocityAngular
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ITransformFrame SOIFrameBody
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ITransformFrame SOIFrameCelestial
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Position SOIPosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector SOIUp
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ITransformFrame ObservationFrame
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Rotation ObservationRotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Position ObservationPosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector ObservationForward
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector ObservationRight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector ObservationUp
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ITransformFrame HorizonFrame
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Rotation HorizonRotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector HorizonNorth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector HorizonSouth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector HorizonUp
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector HorizonDown
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector HorizonWest
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector HorizonEast
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Rotation GetNavballRotationForForward(Vector viewerForward) => throw null;

    public Vector SurfaceMovementVelocity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Vector SurfaceMovementPrograde
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Vector SurfaceMovementRetrograde
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double SurfaceMovementSpeed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double SurfaceVerticalSpeed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double SurfaceHorizontalSpeed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double SurfaceVerticalSpeedMagnitude
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double SurfaceHorizontalSpeedMagnitude
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double Latitude
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double Longitude
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double AltitudeFromRadius
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double AltitudeFromSeaLevel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double AltitudeFromTerrain
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double AltitudeFromScenery
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double AltitudeFromSurface
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PQSData.BiomeSurfaceData SurfaceBiome
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double StaticPressure_kPa
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double DynamicPressure_kPa
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double AtmosphericTemperature
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double ExternalTemperature
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double AtmosphericDensity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double AtmosphericDensityNormalized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double AtmosphericHumidityPercentage
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double SoundSpeed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double MachNumber
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool IsInAtmosphere
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public ITransformFrame OrbitMovementFrame
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Rotation OrbitMovementRotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector OrbitMovementPrograde
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector OrbitMovementRetrograde
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector OrbitMovementNormal
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector OrbitMovementAntiNormal
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector OrbitMovementRadialOut
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector OrbitMovementRadialIn
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector OrbitalMovementVelocity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double OrbitalMovementSpeed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public ITransformFrame TargetFrame
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector TargetDirection
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Vector AntiTargetDirection
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Vector TargetVelocity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double TargetDistance
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double TargetSpeed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double TargetSpeedMagnitude
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Vector TargetPrograde
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Vector TargetRetrograde
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool HasTargetObject
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector ManeuverDirection
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool HasManeuver
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TelemetryComponent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TelemetryComponent(TelemetryDefinition telemetryDefinition, IUniverseModel universeModel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TelemetryComponent(UniverseModel universeModel) => throw null;

    public double CommNetRangeMeters
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public ConnectionGraphNode CommNetNode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ConnectionNodeStatus CommNetConnectionStatus
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnAdded(SimulationObjectModel simulationObject, double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnRemoved(SimulationObjectModel simulationObject, double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnStart(double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnUpdate(double universalTime, double deltaUniversalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnTransmitterActivated() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnTransmitterDeactivated() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RefreshCommNetNode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double GetMaxTransmitterDistanceFromParts(out bool hasActiveNode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object GetDefinition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object GetState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool ValidateState(object stateData, ISimulationModelMap simulationModelMap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object SetState(object state, ISimulationModelMap simulationModelMap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateSOIFrame() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InvokeTelemetryUpdated() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetObservationFrame(ITransformFrame newObservationFrame) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetObservationFrame(ITransformFrame newRootFrame, QuaternionD localRotationOffset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetTarget(ITransformModel newTargetTransform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearTarget() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateAllTelemetry() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateTelemetryDisplay() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateHorizonTelemetry() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateSurfaceMovementTelemetry() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateEnvironmentTelemetry() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateVesselAtmosphericPressure() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateOrbitMovementTelemetry() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateTargetTelemetry() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateManeuverTelemetry() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateNavballHighlightPosition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static TelemetryComponent() => throw null;
  }
}
