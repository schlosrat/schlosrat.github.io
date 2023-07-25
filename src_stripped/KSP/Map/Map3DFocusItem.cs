// Decompiled with JetBrains decompiler
// Type: KSP.Map.Map3DFocusItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Messages;
using KSP.Sim;
using KSP.UI;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Map
{
  public class Map3DFocusItem : KerbalMonoBehaviour, IContextPanelTarget
  {
    private const int DEFAULT_UNLOAD_TIME_SECONDS = 1;
    private const float VERTICAL_VIEWPORT_PERCENTAGE_CULLING_THRESHOLD = 0.002f;
    public const float CELESTIAL_BODY_SCALE_OVERSIZE_FACTOR = 2f;
    public const float SELECTION_SCALE_OVERSIZE_FACTOR = 2.2f;
    private const string SET_TARGET_LOC_PATH = "Map/SetTarget";
    private const string CLEAR_TARGET_LOC_PATH = "Map/ClearTarget";
    private const string CONTROL_LOC_PATH = "Menu/TrackingStation/Tooltips/VesselControl";
    private const string FOCUS_LOC_PATH = "Menu/TrackingStation/Tooltips/Focus";
    private const string DESTROY_LOC_PATH = "Menu/TrackingStation/Tooltips/Destroy";
    [HideInInspector]
    public ITransformModel model;
    [HideInInspector]
    public double radiusInMeters;
    [HideInInspector]
    public double? soiRadiusInMeters;
    public Map3DFocusItemIcon icon;
    public GameObject soi;
    public Map3DSpaceProviderTarget view3DSelection;
    public MapItemHierarchy MapItemHierarchy;
    public bool ForceLoad3DVisual;
    private Map3DSpaceProviderTarget _view3DVisual;
    private Map3DView _map3DView;
    private bool _isInFrustum;
    private float _unloadTimer;
    private bool _isLoading3DVisual;
    private bool _isVisible;
    private KSP.Map.MapItem _mapItem;
    private MapCamera _mapCamera;
    private readonly List<Map3DSpaceProviderTarget> _relatedSpaceProviderTargets;
    private static readonly Vector3[] s_aabbPlaneCenterPositions;
    private Vector4 _rippleEntryPoint;
    private Vector4 _rippleExitPoint;
    private string RIPPLE_ENTRY_PROPERTY_NAME;
    private string RIPPLE_EXIT_PROPERTY_NAME;
    private bool _isValidTarget;
    private bool _ignoreTarget;
    private ContextPanelDataContext _targetData;

    public KSP.Map.MapItem AssociatedMapItem
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Map3DSpaceProviderTarget View3DVisual
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ContextPanelDataContext TargetData
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsValidTarget
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IgnoreTarget
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GameObject ParentObject
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LinkItem(
      KSP.Map.MapItem item,
      Map3DView map3DView,
      Map3DSpaceProvider provider,
      MapCamera mapCamera,
      ITransformModel model,
      Color? itemColor = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetTarget() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClearTarget() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PopDestroyConfirmationDialog() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DestroySimObject() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FocusSimObject() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ControlVessel() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateTargetData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetView3DVisual(Map3DSpaceProviderTarget view3DVisual) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerable<Map3DSpaceProviderTarget> SpaceProviderTargets() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KSP.Map.MapItem MapItem() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool DetermineLOD() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ToggleIconVisibility() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateSOIEntryExitPoints() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void CalculateEntryExitPositions(
      IPatchedOrbit patch,
      ITransformFrame mapOriginFrame,
      out Vector3d entryPos,
      out Vector3d exitPos)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsFlat() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetViewportPercentage() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float Get3DVisualScaleFactor() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnMapCameraVisibilityChanged(bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnActiveVesselChanged(MessageCenterMessage message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RequestView3DLoad() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DestroyView3D() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Map3DFocusItem() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static Map3DFocusItem() => throw null;
  }
}
