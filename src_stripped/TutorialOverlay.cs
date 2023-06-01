// Decompiled with JetBrains decompiler
// Type: TutorialOverlay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[PostProcess(typeof (TutorialOverlayRenderer), PostProcessEvent.BeforeStack, "KSP/TutorialOverlay", true)]
[Serializable]
public sealed class TutorialOverlay : PostProcessEffectSettings
{
  [Range(0.0f, 5f)]
  [Header("Line")]
  public FloatParameter thickness;
  [Range(0.0f, 10f)]
  public FloatParameter depthMultiplier;
  [Range(0.0f, 5f)]
  public FloatParameter depthBias;
  public ColorParameter lineColor;
  [Header("Background")]
  public ColorParameter tintColor;
  [Range(0.0f, 1f)]
  public FloatParameter tintBlend;
  [Range(0.0f, 1f)]
  public FloatParameter backgroundBlend;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public TutorialOverlay() => throw null;
}
