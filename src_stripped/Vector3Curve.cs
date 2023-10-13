// Decompiled with JetBrains decompiler
// Type: Vector3Curve
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class Vector3Curve
{
  [SerializeField]
  private AnimationCurve x;
  [SerializeField]
  private AnimationCurve y;
  [SerializeField]
  private AnimationCurve z;

  public float minTime
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
  }

  public float maxTime
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Vector3Curve() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Add(float time, Vector3 value) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Add(float time, Color value) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Vector3 EvaluateVector(float time) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Color EvaluateColor(float time) => throw null;
}
