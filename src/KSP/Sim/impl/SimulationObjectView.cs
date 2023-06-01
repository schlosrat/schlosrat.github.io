// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.SimulationObjectView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using Newtonsoft.Json;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.impl
{
  public class SimulationObjectView : KerbalMonoBehaviour, ISimulationObjectView
  {
    public const string TAG_DUMMY_VIEW_OBJECT = "Dummy ViewObject";
    private bool _positionTrackSimObject;
    private bool _hasDummyCheckOccured;
    private bool _isDummyViewObject;
    private bool _isDestroying;
    private CelestialBodyBehavior _celestialBodyViewObjectComponent;
    private ColonyBehavior _colonyViewObjectComponent;
    private CrewMemberBehavior _crewMemberViewObjectComponent;
    private KerbalBehavior _kerbalViewObjectComponent;
    private PartBehavior _partViewObjectComponent;
    private PartOwnerBehavior _partOwnerViewObjectComponent;
    private RigidbodyBehavior _rigidbodyViewObjectComponent;
    private VesselBehavior _vesselViewObjectComponent;
    private ThermalBehavior _thermalViewObjectComponent;
    private Transform _transform;
    private GameObject _gameObjectAxis;

    public SimulationObjectModel Model
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public IUniverseView Universe
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [JsonIgnore]
    public GameObject GameObjectAxis
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsDummy
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public CelestialBodyBehavior CelestialBody
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ColonyBehavior Colony
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public CrewMemberBehavior CrewMember
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public KerbalBehavior Kerbal
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public PartBehavior Part
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public PartOwnerBehavior PartOwner
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public RigidbodyBehavior Rigidbody
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public VesselBehavior Vessel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ThermalBehavior ThermalBehavior
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T GetViewObjectComponent<T>() where T : ViewObjectComponent => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetViewObjectComponent<T>(out T viewObjectComponent) => throw null;

    public Vector3 position
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Quaternion rotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool PositionTrackSimObject
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetGameObjectAxis(GameObject gameObjectAxisNew) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Destroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CacheViewObjectComponent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void CreateNewViewObjectAsync(
      IUniverseView universe,
      SimulationObjectModel model,
      Action<SimulationObjectView> resultCallback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void CreateNewViewObjectAsync(
      IUniverseView universe,
      SimulationObjectModel model,
      Vector3 position,
      Quaternion rotation,
      Action<SimulationObjectView> resultCallback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SimulationObjectView CreateNewViewObject(
      IUniverseView universe,
      SimulationObjectModel model)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static SimulationObjectView InitializeView(
      GameObject instance,
      IUniverseView universe,
      SimulationObjectModel model)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RefreshViewTransform() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnSimObjectPositionUpdated(Position newPosition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnSimObjectRotationUpdated(Rotation newRotation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PerformCleanup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimulationObjectView() => throw null;

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    GameObject ISimulationObjectView.get_gameObject() => throw null;

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    Transform ISimulationObjectView.get_transform() => throw null;
  }
}
