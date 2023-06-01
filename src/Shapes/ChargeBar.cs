// Decompiled with JetBrains decompiler
// Type: Shapes.ChargeBar
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Shapes
{
  public class ChargeBar : MonoBehaviour
  {
    [SerializeField]
    [Header("Gameplay")]
    private float chargeSpeed;
    [SerializeField]
    private float chargeDecaySpeed;
    [NonSerialized]
    public bool isCharging;
    private float charge;
    [Header("Style")]
    public Color tickColor;
    public Gradient chargeFillGradient;
    [Range(0.0f, 0.1f)]
    public float tickSizeSmol;
    [Range(0.0f, 0.1f)]
    public float tickSizeLorge;
    [Range(0.0f, 0.05f)]
    public float tickTickness;
    [Range(0.0f, 0.5f)]
    public float fontSize;
    [Range(0.0f, 0.5f)]
    public float fontSizeLorge;
    [Range(0.0f, 0.1f)]
    public float percentLabelOffset;
    [Range(0.0f, 0.4f)]
    public float fontGrowRangePrev;
    [Range(0.0f, 0.4f)]
    public float fontGrowRangeNext;
    [Header("Animation")]
    public AnimationCurve chargeFillCurve;
    public AnimationCurve animChargeShakeMagnitude;
    [Range(0.0f, 0.05f)]
    public float chargeShakeMagnitude;
    public float chargeShakeSpeed;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateCharge() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DrawBar(FpsController fpsController, float barRadius) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ChargeBar() => throw null;
  }
}
