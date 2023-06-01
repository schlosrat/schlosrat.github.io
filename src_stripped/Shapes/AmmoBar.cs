// Decompiled with JetBrains decompiler
// Type: Shapes.AmmoBar
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace Shapes
{
  public class AmmoBar : MonoBehaviour
  {
    public int totalBullets;
    public int bullets;
    [Range(0.0f, 1f)]
    [Header("Style")]
    public float bulletThicknessScale;
    [Range(0.0f, 0.5f)]
    public float bulletEjectScale;
    [Header("Animation")]
    public float bulletDisappearTime;
    [Range(0.0f, 6.28318548f)]
    public float bulletEjectAngSpeed;
    [Range(0.0f, 6.28318548f)]
    public float ejectRotSpeedVariance;
    public AnimationCurve bulletEjectX;
    public AnimationCurve bulletEjectY;
    private float[] bulletFireTimes;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector2 GetBulletEjectPos(Vector2 origin, float t) => throw null;

    public bool HasBulletsLeft
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Fire() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Reload() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DrawBar(FpsController fpsController, float barRadius) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AmmoBar() => throw null;
  }
}
