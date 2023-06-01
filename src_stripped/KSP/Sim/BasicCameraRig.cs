// Decompiled with JetBrains decompiler
// Type: KSP.Sim.BasicCameraRig
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Logging;
using KSP.Sim.impl;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  public class BasicCameraRig : 
    ICameraRig,
    ICameraRigAnchorProvider,
    ICameraShotProvider,
    ICameraTweakablesProvider
  {
    private const LogFilter LOG_FILTER = LogFilter.Camera;
    private Dictionary<CameraMode, ICameraRigSolution> ModeSolutions;
    private const string AUTO_CAMERA_MODE_KEY = "Flight/CameraMode/Auto";
    private const string BODY_CAMERA_MODE_KEY = "Flight/CameraMode/Body";
    private const string HORIZON_CAMERA_MODE_KEY = "Flight/CameraMode/Horizon";
    private const string CELESTIAL_CAMERA_MODE_KEY = "Flight/CameraMode/Celestial";
    private const string CHASE_CAMERA_MODE_KEY = "Flight/CameraMode/Chase";
    private const string CAPTURE_CAMERA_MODE_KEY = "Flight/CameraMode/Capture";

    public CameraMode Mode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public ICameraShot Shot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ICameraRigSolution ActiveSolution
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private IUniverseObserver Observer
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private TransformModel Anchor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    ITransformModel ICameraRigAnchorProvider.Anchor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public CameraTweakables Tweakables
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BasicCameraRig(
      string name,
      IUniverseObserver observer,
      CameraMode startMode,
      CameraTweakables cameraTweakables)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraMode[] GetAvailableCameraModes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ICameraRigSolution GetCameraModeSolution(CameraMode mode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetCameraTweakables() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterCameraMode(CameraMode mode, ICameraRigSolution gimbal) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SelectCameraMode(
      CameraMode newMode,
      bool shouldInterpolate = true,
      bool sendPassiveNotification = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void NotifyNewCameraMode(CameraMode cameraMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateRig(double universeDeltaTime, CameraInputState inputs) => throw null;
  }
}
