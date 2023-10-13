// Decompiled with JetBrains decompiler
// Type: Shapes.Crosshair
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
