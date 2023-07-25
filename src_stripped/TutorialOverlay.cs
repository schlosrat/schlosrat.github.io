// Decompiled with JetBrains decompiler
// Type: TutorialOverlay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[PostProcess]
[Serializable]
public sealed class TutorialOverlay : PostProcessEffectSettings
{
  [Header("Line")]
  [Range(0.0f, 5f)]
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
