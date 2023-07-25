// Decompiled with JetBrains decompiler
// Type: KSP.Map.Map3DManeuvers
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Game;
using KSP.Messages;
using KSP.Sim.impl;
using KSP.Sim.Maneuver;
using KSP.UI.Binding;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace KSP.Map
{
  [Serializable]
  public class Map3DManeuvers
  {
    private const string INIT_ASSERT_MESSAGE = "Map3DManeuvers has not been initialized with Configure(...)!";
    private const float MANEUVER_SCRUB_SMOOTHING = 0.5f;
    private const string IGNORED_UI_TAG = "OrbitalUIElement";
    [SerializeField]
    [Header("Maneuver Planning")]
    private float _closeBeginTrigger;
    [SerializeField]
    private float _farLeaveTrigger;
    [SerializeField]
    private CanvasGroup _maneuverScrubTemplate;
    [SerializeField]
    private ContextBindRoot _maneuverPopupTemplate;
    private bool _initialized;
    private MapCamera _mapCamera;
    private OrbitRenderer _orbitRenderer;
    private Map3DSpaceProvider _spaceProvider;
    private Transform _mapParentFor3DObjects;
    private GameInstance _game;
    private List<Map3DFocusItem> _maneuverableItems;
    private Dictionary<Guid, GizmoData> _lookupGizmo;
    private List<MapManeuverGizmo> _poolGizmo;
    private Queue<GizmoData> _removalQueue;
    private CanvasGroup _maneuverScrubInstance;
    private CanvasGroup _maneuverPopupInstance;
    private bool _maneuverScrubVisible;
    private PropertyExternal<double> _timeToPoint;
    private Property<bool> _addManeuverActive;
    private bool _isManeuverPopupShowing;
    private UnityEngine.Ray _mouseRay;
    private RaycastHit[] _raycastHits;
    private List<RaycastResult> _uiRaycastHits;
    private IReadOnlyList<GeneratedPointsData> _pointsData;
    private Matrix4x4D _localToWorldForOrbitFOR;
    private Matrix4x4D _worldToLocalForOrbitFOR;
    private Utils.SegmentInfo _closestSegment;
    private bool _isCloseToManeuverPreview;
    private MapManeuverGizmo _activeGizmo;
    private double _representedOrbitParameter;
    private IGGuid _representedOrbiterID;
    private OrbitRenderer.CameraRenderInstance.RenderData _representedRenderData;
    private DataContext _maneuverContext;
    private SubscriptionHandle _onVesselChangeHandle;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Configure(
      MapCamera mapCamera,
      OrbitRenderer orbitRenderer,
      Map3DSpaceProvider spaceProvider,
      Transform parent,
      List<Map3DFocusItem> maneuverableItems)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveAll() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Shutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnWarpTo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void WarpToGizmo(Guid dataID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double GetTimeToPoint() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnAddManeuver() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HideManeuverPopup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ShowManeuverPopup(
      IGGuid targetID,
      OrbitRenderer.CameraRenderInstance.RenderData renderData,
      double parameter)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetNodeDataForVessels() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GenerateGizmosForNodes(List<ManeuverNodeData> nodes) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateAll() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateManeuverPopup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ManeuverInputListener() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetItemUnderCursor<T>(out T item) where T : Component => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetParentItemUnderCursor<T>(out T item) where T : Component => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsManeuverPopupHovered() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsOtherUIHovered() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsManipulating() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CreateGizmoForLocation(ManeuverNodeData nodeData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyGizmoChange(Guid dataID, ManeuverGizmoInputType inputType, float inputAmount) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdatePositionForGizmo(Guid dataID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddToLookup(GizmoData toAdd) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateManevuerDetection(IGGuid orbitingSimObjectID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RequestGizmoRemoval(Guid dataID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpkeepGizmos() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private MapManeuverGizmo AcquireRawGizmoObject() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetPositionUIFromWorldPoint(
      RectTransform targetUIRectTransform,
      Vector3 worldLocation,
      Camera worldCamera)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PositionUIFromWorldPoint(
      RectTransform targetUIRectTransform,
      Vector3 worldLocation,
      Camera worldCamera)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PositionUIFromWorldPoint(
      Transform targetUIRectTransform,
      Vector3 worldLocation,
      Camera worldCamera)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdatePositionUIFromWorldPoint(
      RectTransform targetUIRectTransform,
      Vector3 worldLocation,
      Camera worldCamera,
      float positionSmoothing)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdatePositionUIFromWorldPoint(
      Transform targetUIRectTransform,
      Vector3 worldLocation,
      Camera worldCamera,
      float positionSmoothing)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Map3DManeuvers() => throw null;
  }
}
