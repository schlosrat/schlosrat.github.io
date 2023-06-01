// Decompiled with JetBrains decompiler
// Type: PACustomParticle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class PACustomParticle
{
  public Vector3 originDirection;
  public float size;
  public Color color;
  public float speed;
  public float spinSpeed;
  public Rect uv;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetDefaultValuesIfUninitialized() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public PACustomParticle() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public PACustomParticle(
    Vector3 originDirection,
    Color color,
    float size,
    float speed,
    float spinSpeed,
    Rect uv)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public PACustomParticle(
    Vector3 originDirection,
    Color color,
    float size = 1f,
    float speed = 0.0f,
    float spinSpeed = 0.0f)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public PACustomParticle(Vector3 originDirection) => throw null;
}
