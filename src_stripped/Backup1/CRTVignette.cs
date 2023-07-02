// Decompiled with JetBrains decompiler
// Type: CRTVignette
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[PostProcess(typeof (CRTVignetteRenderer), PostProcessEvent.AfterStack, "KSP/CRT Vignette", true)]
[Serializable]
public sealed class CRTVignette : PostProcessEffectSettings
{
  [Tooltip("Vignette color.")]
  [Header("Vignette")]
  public ColorParameter color;
  [Tooltip("Sets the vignette center point (screen center is [0.5, 0.5]).")]
  public Vector2Parameter center;
  [Range(0.0f, 1f)]
  [Tooltip("Amount of vignetting on screen.")]
  public FloatParameter intensity;
  [Tooltip("Smoothness of the vignette borders.")]
  [Range(0.01f, 1f)]
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
  [Range(0.0f, 1f)]
  [Header("Scanlines")]
  [Tooltip("Power of the scanline's gradient.")]
  public FloatParameter scanlinePower;
  [Tooltip("Amount of vignetting on screen.")]
  [Range(0.0f, 1f)]
  public FloatParameter scanlineIntensity;
  [Range(0.01f, 1f)]
  [Tooltip("Smoothness of the vignette borders.")]
  public FloatParameter scanlineSmoothness;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public CRTVignette() => throw null;
}
