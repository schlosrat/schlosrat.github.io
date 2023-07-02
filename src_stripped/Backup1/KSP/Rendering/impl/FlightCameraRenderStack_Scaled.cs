// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.impl.FlightCameraRenderStack_Scaled
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace KSP.Rendering.impl
{
  public class FlightCameraRenderStack_Scaled : CameraRenderStackBase, ICameraRenderStack
  {
    private GameObject cameraRoot;
    [SerializeField]
    private Camera scaledMainCamera;
    [SerializeField]
    private Camera scaledCubemapCamera;
    [SerializeField]
    private PostProcessLayer _postProcessLayer;
    [SerializeField]
    private CameraEffectsSystem _cameraEffectsSystem;
    private RenderTexture scaledCubemap;
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
    protected override void InternalApplyShotToRenderCamera(ICameraShot shot, Camera camera) => throw null;

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
    public FlightCameraRenderStack_Scaled() => throw null;
  }
}
