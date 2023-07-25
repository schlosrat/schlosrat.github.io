// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.impl.BasicCameraRigSolution
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Messages;
using KSP.Sim;
using KSP.Sim.impl;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering.impl
{
  public class BasicCameraRigSolution : ICameraRigSolution, ICameraShotInGimbal, ICameraShot
  {
    public static GimbalState DEFAULT_GIMBALSTATE;
    public static GimbalState DEFAULT_FLIGHT_GIMBALSTATE;
    private CameraTweakables _tweakablesDefault;
    private CameraTweakables _tweakablesOverride;
    private UniverseCameraManager _universeCameraManager;
    private GameInstance _game;
    private IGimbalPositionProvider _gimbalPositionProvider;
    private IDynamicFrameRotationProvider _gimbalRotationProvider;
    private RectTransform _rectTransformUnderCursor;
    private CameraInputState _lastInputs;
    private MessageCenter _gameMessageCenter;
    [SerializeField]
    private GimbalState _prevGimbalState;
    private GimbalState _targetGimbalState;
    private GimbalState _sourceGimbalState;
    private Vector3d _cameraPositionInUnitySpace;
    private LayerMask _raycastMask;
    private bool _lerpToTargetGimbalState;
    private float _gimbalStateInterpolationTimer;
    private float _gimbalStateInterpolationDuration;
    private float _terrainCollisionTimer;
    private double _targetGimbalDistance;
    public float VesselSwitchBackoffFOVFactor;
    public float VesselSwitchBackoffPadding;
    private Position _targetGimbalPos;
    private Position _sourceGimbalPos;
    private Rotation _targetGimbalRot;
    private Rotation _sourceGimbalRot;
    private float _gimbalTransformInterpolationTimer;
    private bool _lerpToTargetGimbalTransform;
    private float _gamepadYaw;
    private float _gamepadPitch;
    private bool _isCameraFineMovementEnabled;
    private Vector3d _prevCameraPosition;
    private bool _enableSurfaceCollisionSurfing;
    private bool _enableEaseOutAfterGroundCollision;
    private bool _isPitchingAtMinDist;
    private double _pitchBeforeMinDist;
    private bool warned;

    private CameraTweakables Tweakables
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ICameraShotInGimbal CameraShot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Position CameraPosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Rotation CameraRotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector CameraForward
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector CameraUp
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsOrthographic
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double FieldOfView
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double OrthographicSize
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public GimbalState GimbalState
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public ITransformFrame AnchorFrame
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ITransformFrame CameraFrame
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ITransformFrame GimbalFrame
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Position GimbalPosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Rotation GimbalRotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector GimbalAxis
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private TransformModel _gimbalTransform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private TransformModel _cameraTransform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InitGimbalState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetGimbalAndCamera(bool shouldLerp = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDefaultGimbalState(GimbalState gimbalState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetGimbalAndCamera(GimbalState state, bool shouldLerp = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BasicCameraRigSolution(string solutionGuid, CameraTweakables cameraTweakables) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnViewControllerFlowFinished(MessageCenterMessage viewControllerMessage) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AnchorToRig(ICameraRigAnchorProvider anchorProvider) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetTargetGimbalTransform(
      Position targetPosition,
      Rotation targetRotation,
      bool shouldLerp = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetGimbalState(GimbalState state, bool shouldLerp = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ModifyGimbalState(GimbalStateIncremental change) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ModifyGimbalStateIncremental(GimbalStateIncremental change) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCameraFieldOfView(double newFieldOfView) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCameraIsOrthographic(bool newIsOrthographic) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCameraOrthographicSize(double newSize) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCameraOrbitTarget(Transform newTransform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetGimbalPositionProvider(IGimbalPositionProvider positionProvider) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetGimbalRotationProvider(IDynamicFrameRotationProvider rotationProvider) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetTweakablesOverride(ICameraTweakablesProvider tweakablesOverride) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FlightCameraContext GetCameraContext() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double UpdateDefaultGimbalStateDistance() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RefreshShot() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateShot(double universeDeltaTime, CameraInputState newInputs) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateGimbalTransform(double universeDeltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateAndValidateGimbalState(double universeDeltaTime, CameraInputState newInputs) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateCameraWithGimbalState(
      double deltaTime,
      bool interpolate,
      bool checkForCollisions)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EaseOutCameraAfterCollision() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool DoesCameraCollide(
      Vector3d relSurfaceNormal,
      Vector3d oldPosition,
      Vector3d newPosition,
      out RaycastHit hit)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void MoveCameraToSafePosition(RaycastHit hit, Vector3d relSurfaceNormal) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CalculateDistanceAndPitch(
      Vector3d newPos,
      Vector3d camPos,
      Vector3d camDir,
      Vector3d relSurfaceNormal,
      out double distance,
      out double pitch)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCameraYawGamepad(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCameraPitchGamepad(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private GimbalState ValidateGimbalState(GimbalState state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool BlockZoomOverUI(CameraInputState newInputs) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static BasicCameraRigSolution() => throw null;
  }
}
