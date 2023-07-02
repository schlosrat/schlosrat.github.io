// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.TaaComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.PostProcessing
{
  public sealed class TaaComponent : PostProcessingComponentRenderTexture<AntialiasingModel>
  {
    private const string k_ShaderString = "Hidden/Post FX/Temporal Anti-aliasing";
    private const int k_SampleCount = 8;
    private readonly RenderBuffer[] m_MRT;
    private int m_SampleIndex;
    private bool m_ResetHistory;
    private RenderTexture m_HistoryTexture;

    public override bool active
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override DepthTextureMode GetCameraFlags() => throw null;

    public Vector2 jitterVector
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetHistory() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetProjectionMatrix(Func<Vector2, Matrix4x4> jitteredFunc) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Render(RenderTexture source, RenderTexture destination) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetHaltonValue(int index, int radix) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector2 GenerateRandomOffset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Matrix4x4 GetPerspectiveProjectionMatrix(Vector2 offset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Matrix4x4 GetOrthographicProjectionMatrix(Vector2 offset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TaaComponent() => throw null;

    private static class Uniforms
    {
      internal static int _Jitter;
      internal static int _SharpenParameters;
      internal static int _FinalBlendParameters;
      internal static int _HistoryTex;
      internal static int _MainTex;

      [MethodImpl(MethodImplOptions.NoInlining)]
      static Uniforms() => throw null;
    }
  }
}
