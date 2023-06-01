// Decompiled with JetBrains decompiler
// Type: CRTVignette
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[PostProcess(typeof (CRTVignetteRenderer), PostProcessEvent.AfterStack, "KSP/CRT Vignette", true)]
[Serializable]
public sealed class CRTVignette : PostProcessEffectSettings
{
  [Header("Vignette")]
  [Tooltip("Vignette color.")]
  public ColorParameter color;
  [Tooltip("Sets the vignette center point (screen center is [0.5, 0.5]).")]
  public Vector2Parameter center;
  [Tooltip("Amount of vignetting on screen.")]
  [Range(0.0f, 1f)]
  public FloatParameter intensity;
  [Range(0.01f, 1f)]
  [Tooltip("Smoothness of the vignette borders.")]
  public FloatParameter smoothness;
  [Range(0.0f, 1f)]
  [Tooltip("Lower values will make a square-ish vignette.")]
  public FloatParameter roundness;
  [Tooltip("Set to true to mark the vignette to be perfectly round. False will make its shape dependent on the current aspect ratio.")]
  public BoolParameter rounded;
  [Header("CRT Subpixels")]
  [Range(0.0f, 256f)]
  [Tooltip("Number of subpixels.")]
  public IntParameter subpixelTiling;
  [Range(0.0f, 50f)]
  [Tooltip("Brightness of the subpixels.")]
  public FloatParameter subpixelIntensity;
  [Tooltip("Distortion of the subpixels.")]
  [Range(0.0f, 1f)]
  public FloatParameter subpixelDistortion;
  [Tooltip("Power of the scanline's gradient.")]
  [Range(0.0f, 1f)]
  [Header("Scanlines")]
  public FloatParameter scanlinePower;
  [Range(0.0f, 1f)]
  [Tooltip("Amount of vignetting on screen.")]
  public FloatParameter scanlineIntensity;
  [Range(0.01f, 1f)]
  [Tooltip("Smoothness of the vignette borders.")]
  public FloatParameter scanlineSmoothness;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public CRTVignette() => throw null;
}
