// Decompiled with JetBrains decompiler
// Type: FloatCurve
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using Newtonsoft.Json;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[JsonObject]
[Serializable]
public class FloatCurve
{
  [SerializeField]
  private AnimationCurve fCurve;
  [SerializeField]
  private float _minTime;
  [SerializeField]
  private float _maxTime;
  private static char[] delimiters;
  private static int findCurveMinMaxInterations;

  public AnimationCurve Curve
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public float minTime
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public float maxTime
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override bool Equals(object obj) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override int GetHashCode() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public FloatCurve() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public FloatCurve(Keyframe[] keyframes) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public FloatCurve(float min, float max) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Add(float time, float value) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Add(float time, float value, float inTangent, float outTangent) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public float Evaluate(float time) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void FindMinMaxValue(out float min, out float max) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void FindMinMaxValue(out float min, out float max, out float tMin, out float tMax) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static FloatCurve() => throw null;
}
