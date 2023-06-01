// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.UniverseView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.Messages;
using KSP.Sim.Debugging;
using KSP.Sim.ViewActions;
using KSP.Utilities;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.impl
{
  public class UniverseView : 
    KerbalMonoBehaviour,
    IUniverseView,
    IViewActionQueue,
    IInternalSpaceProvider,
    IFixedUpdate,
    IUpdate,
    IPriorityOverride
  {
    private const float DEFAULT_PROXIMITY_LOAD_RANGE_METERS = 100000f;
    private const float DEFAULT_QUERY_INTERVAL_SECONDS = 1f;
    private CelestialBodyAssetLoader _assetLoader;
    private bool _proximityViewObjectEnabled;
    private float _proximityViewObjectRangeMeters;
    private float _queryIntervalSeconds;
    private float _queryTimeRemaining;
    private bool _performScaledSpaceLoadUnload;
    private bool _isAutomaticCelestialBodyLoadEnabled;
    private readonly List<SimulationObjectModel> _tempSimObjectList;
    private int _remainingProximityViewObjectsToLoad;
    private Action<bool> _proximityViewObjectsLoadingFinishedCallback;
    private bool _isDestroyInProgress;
    private List<IViewAction> pendingActions;
    private List<IViewAction> activeActions;
    private List<IViewAction> actionsScratchPad;
    private SubscriptionHandle _handleFloatingOriginSnap;
    private int currentSample;
    private float[] frameTimes;
    private float[] fpsHistory;

    public UniverseModel Model
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public IUniverseObserver FlightObserver
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public IScaledSpaceProvider ScaledSpace
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public IPhysicsSpaceProvider PhysicsSpace
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public IInternalSpaceProvider InternalSpace
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Transform ScaledSpaceTransform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Transform PhysicsSpaceTransform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Transform InternalSpaceTransform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Transform PhysXReferenceTransform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Transform PhysXCounterRotatingTransform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Transform CelestialTransform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public CelestialUtilities CelestialUtilities
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    Transform IInternalSpaceProvider.transform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public IViewActionQueue ViewActionQueue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public CelestialBodyAssetLoader AssetLoader
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ILuaDebugInjector ScriptInjector
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public UniverseTime UniverseTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float PhysicsDeltaTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsDestroyInProgress
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float QueryIntervalSeconds
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool IsProximityLoadUnloadEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float ProximityViewObjectRangeMeters
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool IsAutomaticCelestialBodyLoadEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    int IPriorityOverride.ExecutionPriorityOverride
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnFixedUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IUpdate.OnUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnFloatingOriginSnapped(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Destroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SubmitViewAction(IViewAction action) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SubmitViewActions(IEnumerable<IViewAction> actions) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void FlushViewActionQueue(IModelViewMap modelViewMap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearViewActionQueue() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InstantiateViewObjectAsync(
      SimulationObjectModel simObject,
      Action<SimulationObjectView> finishedCallback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InstantiateViewObjectAsync(
      SimulationObjectModel simObject,
      Vector3 worldSpacePosition,
      Quaternion worldSpaceRotation,
      Action<SimulationObjectView> finishedCallback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimulationObjectView InstantiateViewObject(SimulationObjectModel simObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void SyncViewObjectToSimObject(
      SimulationObjectView viewObject,
      SimulationObjectModel simObject)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LoadUnloadProximityViewObjects(Position position, Action<bool> loadFinishedCallback = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LoadUnloadProximityViewObjects(
      Position position,
      double rangeMeters,
      Action<bool> loadFinishedCallback = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnViewObjectInstantiateFinished(SimulationObjectView newViewObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static UniverseView New(
      UniverseModel model,
      IModelViewMap modelViewMap,
      ILuaDebugInjector scriptDebugger)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGUI() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UniverseView() => throw null;
  }
}
