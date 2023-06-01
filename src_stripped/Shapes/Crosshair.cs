// Decompiled with JetBrains decompiler
// Type: Shapes.Crosshair
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace Shapes
{
  public class Crosshair : MonoBehaviour
  {
    [Header("Style")]
    [Range(0.0f, 0.05f)]
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
