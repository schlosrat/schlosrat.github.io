// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.UniverseObserver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Messages;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class UniverseObserver : TransformModel, IUniverseObserver
  {
    private readonly UniverseModel _universeModel;
    private CelestialBodyComponent _oldReferenceBody;
    private CelestialBodyComponent _referenceBody;
    private SimulationObjectModel _observingSimObj;
    private SubscriptionHandle _handleOnSOIEntered;

    public ITransformFrame ObservationFrame
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Velocity Velocity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public CelestialBodyComponent ReferenceBody
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ITransformFrame SimObjectParentFrame
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ITransformFrame SimSOIBodyParentFrame
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public SimulationObjectModel ObservingSimObj
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetObservingSimObj(SimulationObjectModel observingSimObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UniverseObserver(
      UniverseModel universeModel,
      SimulationObjectModel initialObservedSimObject,
      string debugGuid)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Cleanup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateReferenceBody() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnSOIEntered(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetSquaredDistanceTo(Position targetPosition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ObserveSimObject(IGGuid simObjectGuid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ObserveSimObject(SimulationObjectModel simObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ObserveSimTransformModel(ITransformModel transformModel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ObserveSimTransformFrame(ITransformFrame frame) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ObserveVessel(VesselComponent vessel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyLaunchSiteCameraGimbalState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ObserveCelestialBody(CelestialBodyComponent body) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ZeroOutLocalVelocities() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RegisterCoMChange(VesselComponent vessel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UnregisterCoMChange() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnObservedVesselCenterOfMassChanged(Position centerOfMass) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private CelestialBodyComponent GetReferenceBody() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static CelestialBodyComponent GetSOICelestialBody(ITransformModel simTransform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void StoreObservedCameraGimbal(SimulationObjectModel observedObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void RestoreObservedCameraGimbal(SimulationObjectModel objectToObserve) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UniverseModel_onSimulationObjectRemoved(SimulationObjectModel obj) => throw null;
  }
}
