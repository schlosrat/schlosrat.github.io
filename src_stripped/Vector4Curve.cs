// Decompiled with JetBrains decompiler
// Type: Vector4Curve
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class Vector4Curve
{
  [SerializeField]
  private AnimationCurve x;
  [SerializeField]
  private AnimationCurve y;
  [SerializeField]
  private AnimationCurve z;
  [SerializeField]
  private AnimationCurve w;

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
  public Vector4Curve() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Add(float time, Vector4 value) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Add(float time, Color value) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Vector4 EvaluateVector(float time) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Color EvaluateColor(float time) => throw null;
}
