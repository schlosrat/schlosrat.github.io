// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.AmbientOcclusionComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine.Rendering;

namespace UnityEngine.PostProcessing
{
  public sealed class AmbientOcclusionComponent : 
    PostProcessingComponentCommandBuffer<AmbientOcclusionModel>
  {
    private const string k_BlitShaderString = "Hidden/Post FX/Blit";
    private const string k_ShaderString = "Hidden/Post FX/Ambient Occlusion";
    private readonly RenderTargetIdentifier[] m_MRT;

    private AmbientOcclusionComponent.OcclusionSource occlusionSource
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private bool ambientOnlySupported
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public override bool active
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override DepthTextureMode GetCameraFlags() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string GetName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override CameraEvent GetCameraEvent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void PopulateCommandBuffer(CommandBuffer cb) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AmbientOcclusionComponent() => throw null;

    private static class Uniforms
    {
      internal static readonly int _Intensity;
      internal static readonly int _Radius;
      internal static readonly int _FogParams;
      internal static readonly int _Downsample;
      internal static readonly int _SampleCount;
      internal static readonly int _OcclusionTexture1;
      internal static readonly int _OcclusionTexture2;
      internal static readonly int _OcclusionTexture;
      internal static readonly int _MainTex;
      internal static readonly int _TempRT;

      [MethodImpl(MethodImplOptions.NoInlining)]
      static Uniforms() => throw null;
    }

    private enum OcclusionSource
    {
      DepthTexture,
      DepthNormalsTexture,
      GBuffer,
    }
  }
}
