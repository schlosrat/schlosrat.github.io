// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.impl.CameraRenderStackBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Sim;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace KSP.Rendering.impl
{
  public abstract class CameraRenderStackBase : KerbalMonoBehaviour, ICameraRenderStack
  {
    [SerializeField]
    protected Camera debugCamera;

    public abstract RenderSpaceType RenderSpace
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected abstract void InternalApplyShotToRenderCamera(ICameraShot shot, Camera renderCamera) => throw null;

    public Transform RenderCameraGimbal
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Transform RenderCameraMount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract Camera[] GetRenderCameras(bool includeDebugCameras = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract Camera GetMainRenderCamera() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract Camera GetCubemapRenderCamera() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract Camera GetDebugRenderCamera() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract PostProcessLayer GetPostProcessLayer() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract CameraEffectsSystem GetCameraEffectsSystem() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRenderCamerasEnabled(bool enabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void ApplyCameraShot(ICameraShot cameraShot) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void RenderShotToTexture(ICameraShot cameraShot, RenderTexture renderTarget) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Ray ScreenPointToRay(Vector3 position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Vector3 ScreenToViewportPoint(Vector3 position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Vector3 ScreenToWorldPoint(Vector3 position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Ray ViewportPointToRay(Vector3 position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Vector3 ViewportToScreenPoint(Vector3 position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Vector3 ViewportToWorldPoint(Vector3 position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Vector3 WorldToScreenPoint(Vector3 position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Vector3 WorldToViewportPoint(Vector3 position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected CameraRenderStackBase() => throw null;
  }
}
