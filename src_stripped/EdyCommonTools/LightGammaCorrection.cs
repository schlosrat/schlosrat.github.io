// Decompiled with JetBrains decompiler
// Type: EdyCommonTools.LightGammaCorrection
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace EdyCommonTools
{
  [RequireComponent(typeof (Light))]
  public class LightGammaCorrection : MonoBehaviour
  {
    public ColorSpace intendedColorSpace;
    [Range(0.5f, 1.5f)]
    public float extraCorrectionFactor;
    private Light m_light;
    private float m_originalIntensity;
    private Color m_originalColor;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float LinearToGamma(float l) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GammaToLinear(float g) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LightGammaCorrection() => throw null;
  }
}
