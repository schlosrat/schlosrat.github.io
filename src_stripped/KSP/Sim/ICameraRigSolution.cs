// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ICameraRigSolution
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using UnityEngine;

namespace KSP.Sim
{
  public interface ICameraRigSolution
  {
    ICameraShotInGimbal CameraShot { get; }

    GimbalState GimbalState { get; }

    void ResetGimbalAndCamera(bool shouldLerp = false);

    void ResetGimbalAndCamera(GimbalState state, bool shouldLerp = false);

    void SetCameraFieldOfView(double fieldOfView);

    void SetCameraIsOrthographic(bool isOrthographic);

    void SetCameraOrthographicSize(double orthographicSize);

    void SetCameraOrbitTarget(Transform newTransform);

    void SetGimbalRotationProvider(IDynamicFrameRotationProvider rotationProvider);

    void SetTargetGimbalTransform(
      Position targetPosition,
      Rotation targetRotation,
      bool shouldLerp = false);

    void SetGimbalState(GimbalState state, bool shouldLerp = false);

    void SetDefaultGimbalState(GimbalState gimbalState);

    void ModifyGimbalState(GimbalStateIncremental change);

    void ModifyGimbalStateIncremental(GimbalStateIncremental change);

    void SetTweakablesOverride(ICameraTweakablesProvider tweakablesOverride);

    void UpdateShot(double universeDeltaTime, CameraInputState newInputs);

    void RefreshShot();

    void AnchorToRig(ICameraRigAnchorProvider anchorProvider);

    FlightCameraContext GetCameraContext();
  }
}
