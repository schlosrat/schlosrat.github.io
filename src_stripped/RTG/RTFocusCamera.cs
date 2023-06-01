// Decompiled with JetBrains decompiler
// Type: RTG.RTFocusCamera
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class RTFocusCamera : MonoSingleton<RTFocusCamera>
  {
    [SerializeField]
    private Camera _targetCamera;
    private Transform _targetTransform;
    [SerializeField]
    private float _fieldOfView;
    private WorldTransformSnapshot _worldTransformSnapshot;
    private CameraPrjSwitchTransition _prjSwitchTranstion;
    private bool _isDoingFocus;
    private IEnumerator _focusCrtn;
    private bool _isDoingRotationSwitch;
    private IEnumerator _genricCamTransformCrtn;
    private bool _isObjectVisibilityDirty;
    private List<GameObject> _visibleObjects;
    private float _focusPointOffset;
    private Vector3 _lastFocusPoint;
    private bool[] _moveDirFlags;
    private float _currentAcceleration;
    [SerializeField]
    private CameraSettings _settings;
    [SerializeField]
    private CameraMoveSettings _moveSettings;
    [SerializeField]
    private CameraPanSettings _panSettings;
    [SerializeField]
    private CameraLookAroundSettings _lookAroundSettings;
    [SerializeField]
    private CameraOrbitSettings _orbitSettings;
    [SerializeField]
    private CameraZoomSettings _zoomSettings;
    [SerializeField]
    private CameraFocusSettings _focusSettings;
    [SerializeField]
    private CameraRotationSwitchSettings _rotationSwitchSettings;
    [SerializeField]
    private CameraProjectionSwitchSettings _projectionSwitchSettings;
    [SerializeField]
    private CameraHotkeys _hotkeys;

    public event CameraProjectionSwitchBeginHandler PrjSwitchTransitionBegin
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event CameraProjectionSwitchUpdateHandler PrjSwitchTransitionUpdate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event CameraProjectionSwitchBeginHandler PrjSwitchTransitionEnd
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event CameraCanProcessInputHandler CanProcessInput
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event CameraCanUseScrollWheelHandler CanUseScrollWheel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public Camera TargetCamera
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsDoingProjectionSwitch
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public CameraPrjSwitchTransition.Type PrjSwitchTransitionType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsDoingRotationSwitch
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float PrjSwitchProgress
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float PrjSwitchDurationInSeconds
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsDoingFocus
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 WorldPosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Quaternion WorldRotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector3 Right
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 Up
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 Look
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsMovingForward
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsMovingBackwards
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsMovingLeft
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsMovingRight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsMovingUp
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsMovingDown
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public CameraSettings Settings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public CameraMoveSettings MoveSettings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public CameraPanSettings PanSettings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public CameraLookAroundSettings LookAroundSettings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public CameraOrbitSettings OrbitSettings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public CameraZoomSettings ZoomSettings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public CameraFocusSettings FocusSettings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public CameraRotationSwitchSettings RotationSwitchSettings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public CameraProjectionSwitchSettings ProjectionSwitchSettings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public CameraHotkeys Hotkeys
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsViewportHoveredByDevice() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetTargetCamera(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetFieldOfView(float fov) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetObjectVisibilityDirty() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetVisibleObjects(List<GameObject> visibleObjects) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PerformRotationSwitch(Quaternion targetRotation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PerformProjectionSwitch() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Focus(List<GameObject> gameObjects) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Focus(AABB focusAABB) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Update_SystemCall() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleMouseAndKeyboardInput() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool CanUseMouseScrollWheel() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool CanCameraProcessInput() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Zoom(float zoomAmount) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3 GetFocusPoint() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float CalculateScrollZoomAmount(float deviceScroll) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Pan(Vector2 panAmount) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LookAround(float degreesLocalX, float degreesWorldY) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Orbit(float degreesLocalX, float degreesWorldY) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PerformInstantFocus(CameraFocus.Data focusData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PerformInstantProjectionSwitch() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector2 CalculateLookAroundRotation(float deviceAxisX, float deviceAxisY) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector2 CalculateOrbitRotation(float deviceAxisX, float deviceAxisY) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector2 CalculatePanAmount(float deviceAxisX, float deviceAxisY) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void StopCamTransform() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void StopFocus() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetFocusPoint(Vector3 focusPoint) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AdjustOrthoSizeForFocusPt() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator DoSmoothPan(float deviceAxisX, float deviceAxisY) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator DoSmoothLookAround(float deviceAxisX, float deviceAxisY) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator DoSmoothOrbit(float deviceAxisX, float deviceAxisY) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator DoSmoothZoom(float deviceScroll) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator DoConstantRotationSwitch(Quaternion targetRotation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator DoSmoothRotationSwitch(Quaternion targetRotation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator DoConstantFocus(CameraFocus.Data focusData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator DoSmoothFocus(CameraFocus.Data focusData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPrjSwitchTransitionBegin(CameraPrjSwitchTransition.Type transitionType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPrjSwitchTransitionUpate(CameraPrjSwitchTransition.Type transitionType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPrjSwitchTransitionEnd(CameraPrjSwitchTransition.Type transitionType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RTFocusCamera() => throw null;

    private enum MoveDirection
    {
      Left,
      Right,
      Up,
      Down,
      Forward,
      Backwards,
    }
  }
}
