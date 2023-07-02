// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.impl.CubemapViewBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace KSP.Rendering.impl
{
  public abstract class CubemapViewBase
  {
    protected GameInstance Game;
    protected PrevisGameInstance PrevisGame;
    protected bool _previsScene;
    protected GraphicsManager GraphicsManager;
    protected CubemapViewBase.CubemapViewType _type;
    protected Camera _cubemapCamera;
    private int targetResolution;
    private Material _cubemapBlitMaterial;
    protected bool _renderingActive;
    protected bool _initialized;
    private RenderTexture _renderLoopActiveRT;
    protected bool _renderLoopToggleTexture;
    private Dictionary<string, float> _transitionValueMap;
    protected CommandBuffer _cmdBuffer;
    public RenderTexture CubemapTexture;
    private RenderTexture _cubemapTemp01;
    private RenderTexture _cubemapTemp02;
    private static RenderTexture _cubemapRenderFace;
    private RenderTexture _faceRenderTarget;
    private RenderTexture _faceDepthTarget;
    private static readonly int FACE_COUNT;
    private static int CUBEMAPVIEW_TRANSPARENT_ONLY_ID;
    private static int CUBEMAPVIEW_TRANSPARENT_RT_ID;
    private static int CUBEMAPVIEW_PACKED_RT_ID;
    private static int CAMERA_DEPTH_TEX_ID;
    private static readonly string SAMPLER_RENDER_OPAQUE;
    private static readonly string SAMPLER_RENDER_TRANSPARENT;
    private static readonly string SAMPLER_RENDER_TRANSPARENT_DEPTH;
    private static readonly string[] SAMPLER_RENDER_CUBEMAP_FACE;
    protected static Quaternion[] axes;

    public abstract string CommandBufferName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public abstract string CubemapTextureName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public abstract string CubemapTemp01Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public abstract string CubemapTemp02Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public abstract string CubemapFaceName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public abstract string FaceRenderTargetName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public abstract string FaceDepthTargetName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private int CurrentRenderFace
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Cleanup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EnableRendering() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DisableRendering() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsActive() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCubemapResolution(int resolution) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void RenderCubemap(
      Camera camera,
      List<Renderer> opaqueRenderers,
      List<Renderer> transparentRenderers)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void RenderCubemapFace(
      Camera camera,
      ref RenderTexture currentFaceTex,
      int face,
      List<Renderer> opaqueRenderers,
      List<Renderer> transparentRenderers)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPreRenderFace() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPostRenderFace() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void CreateCubemapViewTextures(int resolution) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void DisposeRenderTextures() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetCameraShaderVariables(ref CommandBuffer cmd, Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RenderGeometry(string samplerTag, ref CommandBuffer cmd, List<Renderer> renderers) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected CubemapViewBase() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static CubemapViewBase() => throw null;

    public enum CubemapViewType
    {
      Observer,
      CelestialBody,
    }
  }
}
