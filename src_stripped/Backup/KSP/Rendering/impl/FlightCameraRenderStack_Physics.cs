// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.impl.FlightCameraRenderStack_Physics
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace KSP.Rendering.impl
{
  public class FlightCameraRenderStack_Physics : CameraRenderStackBase, ICameraRenderStack
  {
    public BasicCameraRig FlightCamRig;
    private GameObject cameraRoot;
    [SerializeField]
    private Camera physicsMainCamera;
    [SerializeField]
    private Camera physicsCubemapCamera;
    [SerializeField]
    private PostProcessLayer _postProcessLayer;
    [SerializeField]
    private CameraEffectsSystem _cameraEffectsSystem;
    private Camera[] _renderCameras;
    private Camera[] _renderCamerasWithDebug;

    private Camera MainCamera
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private Camera CubemapCamera
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public override RenderSpaceType RenderSpace
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void InternalApplyShotToRenderCamera(ICameraShot cameraShot, Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAssemblyActive(bool isActive) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Camera[] GetRenderCameras(bool includeDebugCameras) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Camera GetMainRenderCamera() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Camera GetCubemapRenderCamera() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Camera GetDebugRenderCamera() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override PostProcessLayer GetPostProcessLayer() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override CameraEffectsSystem GetCameraEffectsSystem() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Ray ScreenPointToRay(Vector3 position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Vector3 ScreenToViewportPoint(Vector3 position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Vector3 ScreenToWorldPoint(Vector3 position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Ray ViewportPointToRay(Vector3 position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Vector3 ViewportToScreenPoint(Vector3 position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Vector3 ViewportToWorldPoint(Vector3 position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Vector3 WorldToScreenPoint(Vector3 position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Vector3 WorldToViewportPoint(Vector3 position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Cleanup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FlightCameraRenderStack_Physics() => throw null;
  }
}
