// Decompiled with JetBrains decompiler
// Type: Shapes.Crosshair
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace Shapes
{
  public class Crosshair : MonoBehaviour
  {
    [Range(0.0f, 0.05f)]
    [Header("Style")]
    public float crosshairCrossInnerRad;
    [Range(0.0f, 0.05f)]
    public float crosshairCrossOuterRad;
    [Range(0.0f, 0.05f)]
    public float crosshairCrossThickness;
    [Range(0.0f, 0.05f)]
    public float crosshairHitCrossInnerRad;
    [Range(0.0f, 0.05f)]
    public float crosshairHitCrossOuterRad;
    [Range(0.0f, 0.05f)]
    public float crosshairHitCrossThickness;
    [Range(0.0f, 1f)]
    [Header("Animation")]
    public float scaleFire;
    public Decayer fireDecayer;
    public Decayer hitDecayer;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Fire() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void FireHit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateCrosshairDecay() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DrawCrosshair() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Crosshair() => throw null;
  }
}
