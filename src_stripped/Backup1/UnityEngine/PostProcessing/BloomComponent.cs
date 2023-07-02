// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.BloomComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace UnityEngine.PostProcessing
{
  public sealed class BloomComponent : PostProcessingComponentRenderTexture<BloomModel>
  {
    private const int k_MaxPyramidBlurLevel = 16;
    private readonly RenderTexture[] m_BlurBuffer1;
    private readonly RenderTexture[] m_BlurBuffer2;

    public override bool active
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Prepare(RenderTexture source, Material uberMaterial, Texture autoExposure) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BloomComponent() => throw null;

    private static class Uniforms
    {
      internal static readonly int _AutoExposure;
      internal static readonly int _Threshold;
      internal static readonly int _Curve;
      internal static readonly int _PrefilterOffs;
      internal static readonly int _SampleScale;
      internal static readonly int _BaseTex;
      internal static readonly int _BloomTex;
      internal static readonly int _Bloom_Settings;
      internal static readonly int _Bloom_DirtTex;
      internal static readonly int _Bloom_DirtIntensity;

      [MethodImpl(MethodImplOptions.NoInlining)]
      static Uniforms() => throw null;
    }
  }
}
