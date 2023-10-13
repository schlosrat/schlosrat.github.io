// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ICameraRig
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
