// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ICameraRig
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
