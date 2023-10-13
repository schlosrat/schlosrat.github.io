// Decompiled with JetBrains decompiler
// Type: ObjectAssemblyViewCube
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Game;
using KSP.OAB;
using KSP.Utilities;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ObjectAssemblyViewCube : KerbalMonoBehaviour
{
  private const float MAX_RAY_LENGTH = 1700f;
  private const float DEGREES_90 = 90f;
  private const double PERPERDICULAR_DOT_PRODUCT_THRESHOLD = 1E-05;
  public float OrthoClickTransTime;
  public int ClickThresholdInPixels;
  [Tooltip("3D Model of the Airplane/Vessel shown within the Orientation Cube.")]
  public Transform CubeVessel;
  [Tooltip("Transforms of the Quads representing the Orientation Cube. These Quads are assumed to have localized text as child objects.")]
  public List<Transform> QuadTransforms;
  [Tooltip("Transforms of the Boxes representing the neighboring Orthographic Views. These Boxes are meant to be separate from the Orientation Cube itself. Their visibility will be dynamically changed based on current Orthographic View direction.")]
  public List<Transform> BoxTransforms;
  [SerializeField]
  private Transform _rotationParent;
  private Coroutine clickTransition;
  private ObjectAssemblyUIEvents uiEvents;
  private ObjectAssemblyBuilderEvents builderEvents;
  private ObjectAssemblyAssets builderAssets;
  private Camera cameraMain;
  private RaycastHit mouseClickHitInfo;
  private UnityEngine.Ray clickRay;
  private Transform cameraPivotPosTransform;
  private Transform cameraGimbalRotTransform;
  private Quaternion lastCameraRotation;
  private Quaternion lastOrthoRot;
  private ObjectAssemblyCameraManager objectAssemblyCameraManager;
  private int UILayer;
  private Vector3 lastMouseClickPos;
  private ObjectAssemblyViewCube.ProjectionMatrixBlender projectionMatrixBlender;
  private Matrix4x4 ortho;
  private Matrix4x4 perspective;
  private bool blueprintModeEnabled;
  private bool _isMouseHovering;
  private Vector2 _lastMousePos;
  private List<MeshRenderer> _renderers;

  private Vector2 centerPoint
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Initialize(
    ObjectAssemblyUIEvents _uiEvents,
    ObjectAssemblyBuilderEvents _builderEvents,
    ObjectAssemblyAssets _builderAssets)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Shutdown() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetEvents() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void RemoveEvents() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void CalculateOrthoMatrix(float orthographicSize) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetCameraMain(Camera cam) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnUpdate() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private bool DidRaycastHitChildTransform() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private bool ShouldProcessInput() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateMouseHovering() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void EnableBlueprintMode(bool enable) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private bool GetPositionAndDistanceWithinCollider(
    Vector3 posToCheck,
    Vector3 orbitTargetPos,
    out Vector3 posWithinCollider,
    ref float cameraDistance)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool IsPositionOutsideBuildArea(Vector3 posToCheck) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnLateUpdate() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void StartOrthographicViewCameraTransition(Quaternion desiredRotation, bool instant) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void StartPerspectiveViewCameraTransition(bool instant, bool fromCameraReset) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void StartViewCubeCameraTransition(
    Quaternion overrideRotation,
    bool toOrtho,
    bool instant,
    bool fromCameraReset)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void AlignViewCubeToCamera() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void BlendCameraToOrbitTarget(Quaternion cameraTargetRot, float duration, bool toOrtho) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ProcessVisibilityBoxTransforms(Vector3 desiredDir, bool toOrtho) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private IEnumerator BlendCameraOverTime(
    Quaternion targetRot,
    float duration,
    bool toOrtho,
    bool fromCameraReset)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void StopTransition() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnUserWorldRotateStart() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnOrthoSizeChanged(float size) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void EnterOrthoView(Quaternion desiredRotation, bool instant, bool force) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void ExitOrthoView(bool instant) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnCameraReset(bool instant) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void ChangeCubeVesselOrientationToAirplane(bool AirplaneOrientation) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnBlueprintModeGamepad() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static bool IsAllowedOrthographicRotation(Quaternion desiredRotation) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public ObjectAssemblyViewCube() => throw null;

  private class ProjectionMatrixBlender
  {
    private Matrix4x4 _srcMatrix;
    private Matrix4x4 _destMatrix;
    private Camera _curCamera;
    private SimpleTimer _blendTimer;
    private float _destOrthographicSize;
    private bool _isDestOrthographic;
    private ObjectAssemblyCameraManager _objectAssemblyCameraManager;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCameraManager(
      ObjectAssemblyCameraManager objectAssemblyCameraManager)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void StartLerpFromTo(
      Camera camera,
      Matrix4x4 src,
      Matrix4x4 dest,
      float duration,
      float destOrthographicSize,
      bool isDestOrtho)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateLerp() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void StopLerp() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCompleteLerp() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static Matrix4x4 MatrixLerp(Matrix4x4 from, Matrix4x4 to, float lerpT) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ProjectionMatrixBlender() => throw null;
  }
}
