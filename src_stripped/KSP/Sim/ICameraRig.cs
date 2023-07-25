// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ICameraRig
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

namespace KSP.Sim
{
  public interface ICameraRig : 
    ICameraRigAnchorProvider,
    ICameraShotProvider,
    ICameraTweakablesProvider
  {
    CameraMode Mode { get; }

    ICameraRigSolution ActiveSolution { get; }

    void SelectCameraMode(CameraMode newMode, bool shouldInterpolate = true, bool sendPassiveNotification = true);

    void RegisterCameraMode(CameraMode mode, ICameraRigSolution gimbal);

    ICameraRigSolution GetCameraModeSolution(CameraMode mode);

    CameraMode[] GetAvailableCameraModes();

    void UpdateRig(double universeDeltaTime, CameraInputState inputs);

    void ResetCameraTweakables();
  }
}
