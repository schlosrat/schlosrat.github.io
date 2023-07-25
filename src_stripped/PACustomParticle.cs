// Decompiled with JetBrains decompiler
// Type: PACustomParticle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
