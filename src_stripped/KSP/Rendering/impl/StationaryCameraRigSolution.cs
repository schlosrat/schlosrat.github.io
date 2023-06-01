// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.impl.StationaryCameraRigSolution
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.impl;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering.impl
{
  public class StationaryCameraRigSolution : ICameraRigSolution, ICameraShotInGimbal, ICameraShot
  {
    private const double DEFAULT_FOV = 60.0;
    private CameraTweakables _tweakablesDefault;
    private CameraTweakables _tweakablesOverride;
    private IGimbalPositionProvider gimbalPositionProvider;
    private IDynamicFrameRotationProvider gimbalRotationProvider;
    private CameraInputState lastInputs;
    private GameObject CameraRoot;
    private StationaryCameraRigSolution.CurrentStationaryCameraMode currentMode;
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

    private TransformModel GimbalTransform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private TransformModel CameraTransform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private IPhysicsSpaceProvider PhysicsSpace
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private ViewController ViewController
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private IModelViewMap ModelViewMap
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private ISimulationObjectView ActiveSimVesselView
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private GameObject ActiveVesselViewGameObject
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private Rigidbody ActiveVesselViewRigidbody
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsPaused() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetGimbalAndCamera(bool shouldLerp = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetGimbalAndCamera(GimbalState gimbalState, bool shouldLerp = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StationaryCameraRigSolution(string solutionGuid, CameraTweakables cameraTweakables) => throw null;

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
    public void RefreshShot() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateShot(double universeDeltaTime, CameraInputState newInputs) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateGimbalTransform(double universeDeltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateAndValidateGimbalState(double universeDeltaTime, CameraInputState newInputs) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateCameraWithGimbalState(double deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static double PositiveMod(double dividend, int divisor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static double Clamp(double value, double min, double max) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDefaultGimbalState(GimbalState gimbalState) => throw null;

    private class CurrentStationaryCameraMode
    {
      private StationaryCameraRigSolution.StationaryCameraMode currentMode;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public CurrentStationaryCameraMode(
        StationaryCameraRigSolution.StationaryCameraMode Invar)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public bool ApplyCamerMode(
        ref StationaryCameraRigSolution.CurrentStationaryCameraMode inVar,
        Vector3 vesselPosition,
        Vector3 vesselVelocity,
        out Vector3 cameraPosition,
        out Quaternion cameraRotation)
      {
        throw null;
      }
    }

    private abstract class StationaryCameraMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)]
      public abstract bool ModeUpdate(
        ref StationaryCameraRigSolution.CurrentStationaryCameraMode inVar,
        Vector3 vesselPosition,
        Vector3 vesselVelocity,
        out Vector3 cameraPosition,
        out Quaternion cameraRotation)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      protected StationaryCameraMode() => throw null;
    }

    private class StationaryCameraFirstMode : StationaryCameraRigSolution.StationaryCameraMode
    {
      private Vector3 vectorVesselToVirtualCamera;
      private float randomCameraOffset;
      private float maxDistanceVesselToVirtualCamera;
      private float maxDistanceCameraOffset;
      private float maxDistanceVesselToTarget;
      private float maxDistanceCameraToVirtualCamera;
      private float percent;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public StationaryCameraFirstMode(Vector3 vesselVelocity) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override bool ModeUpdate(
        ref StationaryCameraRigSolution.CurrentStationaryCameraMode inVar,
        Vector3 vesselPosition,
        Vector3 vesselVelocity,
        out Vector3 cameraPosition,
        out Quaternion cameraRotation)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void CalculateCameraTransform(
        float fixedCameraOffset,
        Vector3 fixedVerticalDistanceVesselToCamera,
        float percentOfProgress,
        Vector3 vesselPosition,
        Vector3 vesselVelocity,
        out Vector3 cameraPosition,
        out Quaternion cameraRotation)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      private Vector3 GetRandomVerticalVectorWithVesselVelocity(Vector3 vesselVelocity) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private Vector3 GetRandomVerticalVector(Vector3 vector) => throw null;
    }

    private class StationaryCameraSecondMode : StationaryCameraRigSolution.StationaryCameraMode
    {
      private const float percentAbs = 1f;
      private const float thetaAbs = 45f;
      private const float alphaMin = 30f;
      private float alphaMax;
      private const float distanceMin = 5f;
      private const float distanceMax = 100f;
      private float percent;
      private float randomPositionOffset;
      private float randomRotationOffset;
      private Vector3 axisVertical;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public StationaryCameraSecondMode(Vector3 vesselVelocity) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override bool ModeUpdate(
        ref StationaryCameraRigSolution.CurrentStationaryCameraMode inVar,
        Vector3 vesselPosition,
        Vector3 vesselVelocity,
        out Vector3 cameraPosition,
        out Quaternion cameraRotation)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void CalculateCameraTransform(
        float percentOfProgress,
        Vector3 verticalAxis,
        Vector3 vesselPosition,
        Vector3 vesselVelocity,
        out Vector3 cameraPosition,
        out Quaternion cameraRotation)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      private float ThetaBetweenVesselAndCamera(float percentOfProgress) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private float DistanceBetweenVesselAndCamera(float percentOfProgress) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private float AlphaBetweenVesselAndCamera(float percentOfProgress) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private Vector3 GetRandomVerticalVector(Vector3 vector) => throw null;
    }
  }
}
