// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtVector3D
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
  public struct SgtVector3D
  {
    public double x;
    public double y;
    public double z;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SgtVector3D(double newX, double newY, double newZ) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SgtVector3D(Vector3 v) => throw null;

    public double sqrMagnitude
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double magnitude
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public SgtVector3D normalized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Dot(SgtVector3D a, SgtVector3D b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SgtVector3D Cross(SgtVector3D a, SgtVector3D b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Overlap(
      SgtVector3D a,
      SgtVector3D b,
      SgtVector3D c,
      SgtVector3D d,
      double eps = 0.001)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Overlap(SgtVector3D a, SgtVector3D b, SgtVector3D p, float eps = 0.001f) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double SquareDistance(SgtVector3D a, SgtVector3D b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SgtVector3D operator -(SgtVector3D a) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SgtVector3D operator -(SgtVector3D a, SgtVector3D b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SgtVector3D operator +(SgtVector3D a, SgtVector3D b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SgtVector3D operator /(SgtVector3D a, long b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SgtVector3D operator /(SgtVector3D a, double b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SgtVector3D operator *(SgtVector3D a, long b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SgtVector3D operator *(SgtVector3D a, double b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SgtVector3D operator *(long a, SgtVector3D b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static explicit operator Vector3(SgtVector3D a) => throw null;
  }
}
