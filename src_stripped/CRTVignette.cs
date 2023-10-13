// Decompiled with JetBrains decompiler
// Type: CRTVignette
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[PostProcess]
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
  [Tooltip("Smoothness of the vignette borders.")]
  [Range(0.01f, 1f)]
  public FloatParameter smoothness;
  [Range(0.0f, 1f)]
  [Tooltip("Lower values will make a square-ish vignette.")]
  public FloatParameter roundness;
  [Tooltip("Set to true to mark the vignette to be perfectly round. False will make its shape dependent on the current aspect ratio.")]
  public BoolParameter rounded;
  [Range(0.0f, 256f)]
  [Header("CRT Subpixels")]
  [Tooltip("Number of subpixels.")]
  public IntParameter subpixelTiling;
  [Tooltip("Brightness of the subpixels.")]
  [Range(0.0f, 50f)]
  public FloatParameter subpixelIntensity;
  [Range(0.0f, 1f)]
  [Tooltip("Distortion of the subpixels.")]
  public FloatParameter subpixelDistortion;
  [Tooltip("Power of the scanline's gradient.")]
  [Header("Scanlines")]
  [Range(0.0f, 1f)]
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
