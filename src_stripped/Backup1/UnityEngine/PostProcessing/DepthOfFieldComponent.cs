// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.DepthOfFieldComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace UnityEngine.PostProcessing
{
  public sealed class DepthOfFieldComponent : PostProcessingComponentRenderTexture<DepthOfFieldModel>
  {
    private const string k_ShaderString = "Hidden/Post FX/Depth Of Field";
    private RenderTexture m_CoCHistory;
    private const float k_FilmHeight = 0.024f;

    public override bool active
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override DepthTextureMode GetCameraFlags() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float CalculateFocalLength() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float CalculateMaxCoCRadius(int screenHeight) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool CheckHistory(int width, int height) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private RenderTextureFormat SelectFormat(
      RenderTextureFormat primary,
      RenderTextureFormat secondary)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Prepare(
      RenderTexture source,
      Material uberMaterial,
      bool antialiasCoC,
      Vector2 taaJitter,
      float taaBlending)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DepthOfFieldComponent() => throw null;

    private static class Uniforms
    {
      internal static readonly int _DepthOfFieldTex;
      internal static readonly int _DepthOfFieldCoCTex;
      internal static readonly int _Distance;
      internal static readonly int _LensCoeff;
      internal static readonly int _MaxCoC;
      internal static readonly int _RcpMaxCoC;
      internal static readonly int _RcpAspect;
      internal static readonly int _MainTex;
      internal static readonly int _CoCTex;
      internal static readonly int _TaaParams;
      internal static readonly int _DepthOfFieldParams;

      [MethodImpl(MethodImplOptions.NoInlining)]
      static Uniforms() => throw null;
    }
  }
}
