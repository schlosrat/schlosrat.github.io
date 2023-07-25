// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ObjectAssemblyCameraManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Messages;
using KSP.Sim;
using KSP.Sim.impl;
using KSP.Utilities;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace KSP.OAB
{
  public class ObjectAssemblyCameraManager : KerbalCameraBehaviour, ICameraGimbalStateProvider
  {
    private const float ORBIT_TARGET_TRANSFORM_MOVED_THRESHOLD_SQR = 0.00250000018f;
    [Tooltip("The settings to copy when spawning camera")]
    public Camera cameraSettingsPrefab;
    [Tooltip("How far the camera is away from pivot when spawned")]
    public float initialCameraPivotDistance;
    [Tooltip("The duration in seconds for Camera Reset blend duration.")]
    public float CameraResetBlendDuration;
    [Tooltip("The duration in seconds for Camera Orbit Target blend duration.")]
    public float CameraOrbitTargetBlendDuration;
    public float MinZoom;
    public float OrthoMinZoom;
    public float OrthoMaxZoom;
    public AutoFocusActionBind PartAutoFocusAction;
    [Header("Camera to Part Position Adjustment")]
    [Tooltip("Whether or not the feature to adjust the Camera position to Part position, when a Part is considered off Screen, is enabled.\nThis adjustment is attempted when a Part is placed or deleted.")]
    public bool EnableCameraToPartPositionAdjustment;
    [Tooltip("Part HalfHeight Percentage in range [0, 1], such that 0 is the Part Center, and 1 is the Part Height Extent.\nWe check whether or not this resultant Part position is on Screen.\nIf the Camera is above the Part, we get this resultant Part position by moving downwards from Part Center.\nIf the Camera is below the Part, we get this resultant Part position by moving upwards from Part Center.")]
    [Range(0.0f, 1f)]
    public float PartHalfHeightPercentage;
    [Range(0.0f, 1f)]
    [Tooltip("Screen HalfWidth Percentage in range [0, 1], such that 0 is the Screen Center, and 1 is the Screen Width Extent.\nIf the resultant Part position is outside this Screen dimension, the Part will be considered off Screen and we will perform the Camera adjustment.")]
    public float ScreenHalfWidthPercentage;
    [Range(0.0f, 1f)]
    [Tooltip("Screen HalfHeight Percentage in range [0, 1], such that 0 is the Screen Center, and 1 is the Screen Height Extent.\nIf the resultant Part position is outside this Screen dimension, the Part will be considered off Screen and we will perform the Camera adjustment.")]
    public float ScreenHalfHeightPercentage;
    private ObjectAssemblyBuilderEvents _events;
    private ObjectAssemblyUIEvents _uiEvents;
    private bool _inOrthoMode;
    private Camera _unityCamera;
    [HideInInspector]
    public Quaternion TargetCameraRotation;
    [HideInInspector]
    public Vector3 TargetCameraPosition;
    [HideInInspector]
    public Quaternion currentCubeOrientation;
    [HideInInspector]
    public float VerticalPanOffset;
    [HideInInspector]
    public float OrthogonalPanOffset;
    [HideInInspector]
    public Vector3 CurrentCameraTargetPosition;
    [HideInInspector]
    public Vector3 CurrentCameraTargetPositionNoPanOffset;
    [HideInInspector]
    public bool ForceOrbitTargetMoved;
    [HideInInspector]
    public bool IsCameraRotateInputActive;
    [HideInInspector]
    public Quaternion DefaultHorizontalCameraRotation;
    [HideInInspector]
    public Quaternion DefaultVerticalCameraRotation;
    private OABOrientation _previousOABOrientation;
    private IObjectAssemblyPart CurrentOrbitTargetPart;
    private IGGuid CurrentOrbitTargetPartGuid;
    private OABSessionInformation _stats;
    private Collider _cameraCollider;
    private PostProcessLayer _postProcessLayer;
    private Vector3 _cameraBlendSourcePivotPos;
    private Vector3 _cameraBlendSourceGimbalPos;
    private Quaternion _cameraBlendSourceGimbalRot;
    private Vector3 _cameraBlendTargetPivotPos;
    private Vector3 _cameraBlendTargetGimbalPos;
    private Quaternion _cameraBlendTargetGimbalRot;
    private SimpleTimer _cameraBlendTimer;
    private bool _cameraResetForceEnvironmentCenter;

    public Transform pivotTransform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Transform gimbalTransform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Transform CameraTransform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Camera Camera
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 CameraWorldPosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GameObject CameraManagerRoot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float InitialCameraPivotDistance
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Transform CameraGimbal
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Transform CameraPivot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float CurCameraPivotDistance
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool IsCameraBlending
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool IsValidCameraRotation(Quaternion rot) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void BlendCameraTo(
      Vector3 position,
      Quaternion rotation,
      float distance,
      float duration)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void BlendCameraToTransform(
      Transform transform,
      float stickLengthOverride = 0.0f,
      float duration = 0.0f)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ProcessCameraBlend(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ProcessOrbitTargetMoved() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetEvents(ObjectAssemblyBuilderEvents builder, ObjectAssemblyUIEvents ui) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetForwardNormal() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResetCameraSettings(bool toggle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitCameraDrivers() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Ray GetCameraRay() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDrawGizmos() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetOrthoMode(bool on) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CameraOrthoMode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ApplyZoom(float dZoom, bool omitCameraZoomedMessages) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPartPlacedMessage(MessageCenterMessage partPlacedMessage) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnFirstPartPlaced(MessageCenterMessage partPlacedMessage) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetGimbalState(out GimbalState cameraGimbalState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateCameraOrbitTargetTransform(Transform targetTransform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateCameraOrbitTargetPart(IObjectAssemblyPart targetPart) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateCameraOrbitTargetTransformBounds(
      Transform targetTransform,
      Bounds targetBounds)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RefreshCameraOrbitTarget() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void FixupCameraOrbitTargetPart() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetCamera(bool instant) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TryCameraOrbitTargetPart(IObjectAssemblyPart partToOrbit) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RecomputeCameraOrbitTargetPosition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void StartCameraOrbitTargetBlend() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPartDeleted(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnNewVessel(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessPartPositionAdjustment(Bounds targetBounds, ref Vector3 targetCameraPos) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnStartCameraRotate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnStopCameraRotate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TriggerCameraResetEvent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PostProcessLayer GetPostProcessLayer() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Quaternion ComputeCameraRotation(Vector3 forward, Vector3 fallbackUp) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectAssemblyCameraManager() => throw null;
  }
}
