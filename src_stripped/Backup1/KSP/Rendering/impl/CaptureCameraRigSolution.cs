// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.impl.CaptureCameraRigSolution
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.impl;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering.impl
{
  public class CaptureCameraRigSolution : ICameraRigSolution, ICameraShotInGimbal, ICameraShot
  {
    private static GimbalState DEFAULT_GIMBALSTATE;
    private const double DEFAULT_FOV = 60.0;
    private const double DEFAULT_SIZE = 5.0;
    private CameraInputState lastInputs;
    private CameraTweakables _tweakablesDefault;
    private CameraTweakables _tweakablesOverride;
    private IGimbalPositionProvider _gimbalPositionProvider;
    private IDynamicFrameRotationProvider _gimbalRotationProvider;
    private bool warned;

    public ICameraShotInGimbal CameraShot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GimbalState GimbalState
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
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

    public Position CameraPosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
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

    public ITransformFrame AnchorFrame
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ITransformFrame CameraFrame
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

    private TransformModel GimbalTransform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private TransformModel CameraTransform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private CameraTweakables Tweakables
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CaptureCameraRigSolution(string solutionGuid, CameraTweakables cameraTweakables) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AnchorToRig(ICameraRigAnchorProvider anchorProvider) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ModifyGimbalState(GimbalStateIncremental change) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ModifyGimbalStateIncremental(GimbalStateIncremental change) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RefreshShot() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetGimbalAndCamera(bool shouldLerp = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetGimbalAndCamera(GimbalState gimbalState, bool shouldLerp = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCameraFieldOfView(double fieldOfView) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCameraIsOrthographic(bool isOrthographic) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCameraOrthographicSize(double orthographicSize) => throw null;

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
    public void UpdateShot(double universeDeltaTime, CameraInputState newInputs) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateGimbalTransform(double universeDeltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateAndValidateGimbalState(double universeDeltaTime, CameraInputState newInputs) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateGimbalWithGimbalState(double deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateCameraWithGimbalState(double deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDefaultGimbalState(GimbalState gimbalState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static CaptureCameraRigSolution() => throw null;
  }
}
