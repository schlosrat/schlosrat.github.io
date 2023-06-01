// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.ShadowConfig
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering
{
  [Serializable]
  public class ShadowConfig
  {
    [Range(0.0f, 1f)]
    [Header("LIGHT SETTINGS")]
    public float ShadowStrength;
    [Range(0.0f, 2f)]
    public float Bias;
    [Range(0.0f, 3f)]
    public float NormalBias;
    [Range(0.0f, 10f)]
    public float NearPlane;
    [Tooltip("Used to test blocker search and early bail out algorithms. Keep it as low as possible, might lead to white noise if too low.\nRecommended values: Mobile = 8, Consoles & VR = 16, Desktop = 24")]
    [Range(4f, 32f)]
    [Header("NGSS SHADOW SETTINGS")]
    public int NgssSamplingTest;
    [Tooltip("Number of samplers per pixel used for PCF and PCSS shadows algorithms.\nRecommended values: Mobile = 16, Consoles & VR = 32, Desktop Med = 48, Desktop High = 64, Desktop Ultra = 128")]
    [Range(8f, 128f)]
    public int NgssSamplingFilter;
    [Range(0.0f, 3f)]
    [Tooltip("Overall shadows softness.")]
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
    [Range(0.0f, 1f)]
    [Tooltip("If zero = 100% noise.\nIf one = 100% dithering.\nUseful when fighting banding.")]
    [Header("NOISE")]
    public int NgssNoiseToDitheringScale;
    [Range(1f, 3f)]
    [Tooltip("How many iterations the Denoiser algorithm should do.\nRequires NGSS Shadows Libraries to be installed and Cascaded Shadows to be enabled in the Editor Graphics Settings.")]
    [Header("DENOISER")]
    public int NgssDenoiserIterations;
    [Range(0.0f, 1f)]
    [Tooltip("Overall Denoiser softness.")]
    public float NgssDenoiserBlur;
    [Tooltip("The amount of shadow edges the Denoiser can tolerate during denoising.")]
    [Range(0.05f, 1f)]
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
    [Header("CASCADES")]
    [Tooltip("Blends cascades at seams intersection.\nAdditional overhead required for this option.")]
    public bool NgssCascadesBlending;
    [Range(0.0f, 2f)]
    [Tooltip("Tweak this value to adjust the blending transition between cascades.")]
    public float NgssCascadesBlendingValue;
    [Range(0.0f, 1f)]
    [Tooltip("If one, softness across cascades will be matched using splits distribution, resulting in realistic soft-ness over distance.\nIf zero the softness distribution will be based on cascade index, resulting in blurrier shadows over distance thus less realistic.")]
    public float NgssCascadesSoftnessNormalization;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyConfig(ShadowConfig other) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ShadowConfig() => throw null;
  }
}
