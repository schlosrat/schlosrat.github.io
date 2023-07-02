// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.EyeAdaptationComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace UnityEngine.PostProcessing
{
  public sealed class EyeAdaptationComponent : 
    PostProcessingComponentRenderTexture<EyeAdaptationModel>
  {
    private ComputeShader m_EyeCompute;
    private ComputeBuffer m_HistogramBuffer;
    private readonly RenderTexture[] m_AutoExposurePool;
    private int m_AutoExposurePingPing;
    private RenderTexture m_CurrentAutoExposure;
    private RenderTexture m_DebugHistogram;
    private static uint[] s_EmptyHistogramBuffer;
    private int m_FrameCount;
    private const int k_HistogramBins = 64;
    private const int k_HistogramThreadX = 16;
    private const int k_HistogramThreadY = 16;

    public override bool active
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetHistory() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector4 GetHistogramScaleOffsetRes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Texture Prepare(RenderTexture source, Material uberMaterial) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnGUI() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public EyeAdaptationComponent() => throw null;

    private static class Uniforms
    {
      internal static readonly int _Params;
      internal static readonly int _Speed;
      internal static readonly int _ScaleOffsetRes;
      internal static readonly int _ExposureCompensation;
      internal static readonly int _AutoExposure;
      internal static readonly int _DebugWidth;

      [MethodImpl(MethodImplOptions.NoInlining)]
      static Uniforms() => throw null;
    }
  }
}
