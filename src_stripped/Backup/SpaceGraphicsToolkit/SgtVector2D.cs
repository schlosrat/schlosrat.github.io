﻿// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtVector2D
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SpaceGraphicsToolkit
{
  [Serializable]
  public struct SgtVector2D
  {
    public double x;
    public double y;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SgtVector2D(double newX, double newY) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SgtVector2D(Vector2 v) => throw null;

    public double sqrMagnitude
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double magnitude
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public SgtVector2D normalized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SgtVector2D operator -(SgtVector2D a, SgtVector2D b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SgtVector2D operator +(SgtVector2D a, SgtVector2D b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SgtVector2D operator /(SgtVector2D a, long b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SgtVector2D operator /(SgtVector2D a, double b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SgtVector2D operator *(SgtVector2D a, long b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SgtVector2D operator *(SgtVector2D a, double b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SgtVector2D operator *(long a, SgtVector2D b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static explicit operator Vector2(SgtVector2D a) => throw null;
  }
}
