// Decompiled with JetBrains decompiler
// Type: KSP.Map.MapManeuverGizmo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Api.CoreTypes;
using KSP.Game;
using KSP.UI.Binding;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Map
{
  public class MapManeuverGizmo : KerbalMonoBehaviour
  {
    private const string INIT_ASSERT_MESSAGE = "MapManevuerGizmo instance has not been initialized with Configure(...)!";
    private readonly Vector3 TARGET_FULL_UI_SCALE;
    private const float SCALE_CHANGE_RATE = 8f;
    public Guid DataID;
    public Action<Guid, ManeuverGizmoInputType, float> GizmoManeuvered;
    public Action<Guid> GizmoTrashed;
    public Action<Guid> GizmoWarp;
    public Action<Guid> GizmoMoved;
    public Action<MapManeuverGizmo> GizmoExpanded;
    public Action<MapManeuverGizmo> GizmoCollapsed;
    [SerializeField]
    [Header("Connections")]
    private MapManeuverGizmo3DExpanded _expandedGizmo;
    [SerializeField]
    private MapManeuverGizmo2DCollapsed _collapsedGizmo;
    [SerializeField]
    private GameObject _movementGizmo;
    [SerializeField]
    private ContextBindRoot _gizmoBindRoot;
    [Header("Input")]
    [SerializeField]
    private MapManeuverInputTarget _mouseoverTarget;
    [Min(0.01f)]
    [Tooltip("This value is inversed - lower values will have greater effects")]
    [SerializeField]
    private float _handleAdjustmentStrengthInv;
    [Header("Debug")]
    [SerializeField]
    private List<LineRenderer> _debugLines;
    [SerializeField]
    private Camera _DEBUGOrtho;
    private bool _initialized;
    private Camera _camera;
    private List<MapLookAtCamera> _billboards;
    private List<GameObject> _hideWhenExpanded;
    private List<GameObject> _hideWhenCollapsedIdle;
    private List<GameObject> _hideWhenCollapsedMenu;
    private List<GameObject> _hideWhenMoving;
    private bool _isManipulating;
    private Vector2 _manipBeginPos;
    private ManeuverGizmoInputType _moveType;
    private ManeuverGizmoState _gizmoState;
    private ManeuverGizmoState _requestedGizmoState;
    private bool _isMoving;
    private DataContext _gizmoData;

    public MapManeuverGizmo3DExpanded ExpandedGizmo
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ManeuverGizmoInputType MoveType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsMoving
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsManipulating
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Configure(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ConfigureDataContext() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCamera(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RequestExpanded() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RequestCollapsedIdle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RequestCollapsedMenu() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RequestMovement() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ManeuverGizmoState GetCurrentState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameObject ExpandedGizmoCenter() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void BeginManipulation(
      MapManeuverManipulator manipulator,
      Vector2 referenceStartPosition)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EndManipulation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void BeginMovement() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EndMovement() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InterpolateToState(
      GameObject enlarging,
      List<GameObject> shrinking,
      ManeuverGizmoState stateOnFinish)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Orient(Vector3 maneuverPoint, Vector3 progradeDir, Vector3? normal = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClearActions() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ManipulateManeuver(ManeuverGizmoInputType inputType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double ScaleInputsForDistance(float x, float numInches) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3 DEBUG_OrthoV3(Vector2 screenPos) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ReferenceForMissions() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MapManeuverGizmo() => throw null;
  }
}
