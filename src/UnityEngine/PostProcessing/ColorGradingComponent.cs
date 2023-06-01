// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.ColorGradingComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace UnityEngine.PostProcessing
{
  public sealed class ColorGradingComponent : PostProcessingComponentRenderTexture<ColorGradingModel>
  {
    private const int k_InternalLogLutSize = 32;
    private const int k_CurvePrecision = 128;
    private const float k_CurveStep = 0.0078125f;
    private Texture2D m_GradingCurves;
    private Color[] m_pixels;

    public override bool active
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float StandardIlluminantY(float x) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3 CIExyToLMS(float x, float y) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3 CalculateColorBalance(float temperature, float tint) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static Color NormalizeColor(Color c) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static Vector3 ClampVector(Vector3 v, float min, float max) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 GetLiftValue(Color lift) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 GetGammaValue(Color gamma) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 GetGainValue(Color gain) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void CalculateLiftGammaGain(
      Color lift,
      Color gamma,
      Color gain,
      out Vector3 outLift,
      out Vector3 outGamma,
      out Vector3 outGain)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 GetSlopeValue(Color slope) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 GetPowerValue(Color power) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 GetOffsetValue(Color offset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void CalculateSlopePowerOffset(
      Color slope,
      Color power,
      Color offset,
      out Vector3 outSlope,
      out Vector3 outPower,
      out Vector3 outOffset)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private TextureFormat GetCurveFormat() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Texture2D GetCurveTexture() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsLogLutValid(RenderTexture lut) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private RenderTextureFormat GetLutFormat() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GenerateLut() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Prepare(Material uberMaterial) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnGUI() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ColorGradingComponent() => throw null;

    private static class Uniforms
    {
      internal static readonly int _LutParams;
      internal static readonly int _NeutralTonemapperParams1;
      internal static readonly int _NeutralTonemapperParams2;
      internal static readonly int _HueShift;
      internal static readonly int _Saturation;
      internal static readonly int _Contrast;
      internal static readonly int _Balance;
      internal static readonly int _Lift;
      internal static readonly int _InvGamma;
      internal static readonly int _Gain;
      internal static readonly int _Slope;
      internal static readonly int _Power;
      internal static readonly int _Offset;
      internal static readonly int _ChannelMixerRed;
      internal static readonly int _ChannelMixerGreen;
      internal static readonly int _ChannelMixerBlue;
      internal static readonly int _Curves;
      internal static readonly int _LogLut;
      internal static readonly int _LogLut_Params;
      internal static readonly int _ExposureEV;

      [MethodImpl(MethodImplOptions.NoInlining)]
      static Uniforms() => throw null;
    }
  }
}
