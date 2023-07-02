// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.ShadowConfig
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering
{
  [Serializable]
  public class ShadowConfig
  {
    [Header("LIGHT SETTINGS")]
    [Range(0.0f, 1f)]
    public float ShadowStrength;
    [Range(0.0f, 2f)]
    public float Bias;
    [Range(0.0f, 3f)]
    public float NormalBias;
    [Range(0.0f, 10f)]
    public float NearPlane;
    [Tooltip("Used to test blocker search and early bail out algorithms. Keep it as low as possible, might lead to white noise if too low.\nRecommended values: Mobile = 8, Consoles & VR = 16, Desktop = 24")]
    [Header("NGSS SHADOW SETTINGS")]
    [Range(4f, 32f)]
    public int NgssSamplingTest;
    [Range(8f, 128f)]
    [Tooltip("Number of samplers per pixel used for PCF and PCSS shadows algorithms.\nRecommended values: Mobile = 16, Consoles & VR = 32, Desktop Med = 48, Desktop High = 64, Desktop Ultra = 128")]
    public int NgssSamplingFilter;
    [Tooltip("Overall shadows softness.")]
    [Range(0.0f, 3f)]
    [Header("SHADOW SOFTNESS")]
    public float NgssShadowsSoftness;
    [Header("PCSS")]
    [Tooltip("PCSS Requires inline sampling and SM3.5.\nProvides Area Light soft-shadows.\nDisable it if you are looking for PCF filtering (uniform soft-shadows) which runs with SM3.0.")]
    public bool NgssPcssEnabled;
    [Tooltip("How soft shadows are when close to caster.")]
    [Range(0.0f, 2f)]
    public float NgssPcssSoftnessNear;
    [Range(0.0f, 2f)]
    [Tooltip("How soft shadows are when far from caster.")]
    public float NgssPcssSoftnessFar;
    [Header("NOISE")]
    [Tooltip("If zero = 100% noise.\nIf one = 100% dithering.\nUseful when fighting banding.")]
    [Range(0.0f, 1f)]
    public int NgssNoiseToDitheringScale;
    [Header("DENOISER")]
    [Tooltip("How many iterations the Denoiser algorithm should do.\nRequires NGSS Shadows Libraries to be installed and Cascaded Shadows to be enabled in the Editor Graphics Settings.")]
    [Range(1f, 3f)]
    public int NgssDenoiserIterations;
    [Tooltip("Overall Denoiser softness.")]
    [Range(0.0f, 1f)]
    public float NgssDenoiserBlur;
    [Range(0.05f, 1f)]
    [Tooltip("The amount of shadow edges the Denoiser can tolerate during denoising.")]
    public float NgssDenoiserEdgeTolerance;
    [Tooltip("This estimates receiver slope using derivatives and tries to tilt the filtering kernel along it.\nHowever, when doing it in screenspace from the depth texture can leads to shadow artifacts.\nThus it is disabled by default.")]
    [Header("BIAS")]
    public bool NgssReceiverPlaneBias;
    [Header("GLOBAL SETTINGS")]
    [Tooltip("Shadows projection.\nRecommeded StableFit as it helps stabilizing shadows as camera moves.")]
    public ShadowProjection GlobalShadowsProjection;
    [Tooltip("Sets the maximum distance at wich shadows are visible from camera.\nThis option affects your shadow distance in Quality Settings.")]
    public float GlobalShadowsDistance;
    [Tooltip("Used for the cascade stitching algorithm.\nThese values set the cascade distances as well as number of cascades.")]
    public ShadowCascadeSplits GlobalCascades;
    [Tooltip("Blends cascades at seams intersection.\nAdditional overhead required for this option.")]
    [Header("CASCADES")]
    public bool NgssCascadesBlending;
    [Tooltip("Tweak this value to adjust the blending transition between cascades.")]
    [Range(0.0f, 2f)]
    public float NgssCascadesBlendingValue;
    [Tooltip("If one, softness across cascades will be matched using splits distribution, resulting in realistic soft-ness over distance.\nIf zero the softness distribution will be based on cascade index, resulting in blurrier shadows over distance thus less realistic.")]
    [Range(0.0f, 1f)]
    public float NgssCascadesSoftnessNormalization;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyConfig(ShadowConfig other) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ShadowConfig() => throw null;
  }
}
