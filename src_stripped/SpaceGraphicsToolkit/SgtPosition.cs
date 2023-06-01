// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtPosition
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
  public struct SgtPosition
  {
    public static readonly double CellSize;
    public double LocalX;
    public double LocalY;
    public double LocalZ;
    public long GlobalX;
    public long GlobalY;
    public long GlobalZ;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SgtPosition(Vector3 localXYZ, double scale = 1.0) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Distance(ref SgtPosition a, ref SgtPosition b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double SqrDistance(ref SgtPosition a, ref SgtPosition b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SgtPosition Delta(ref SgtPosition a, ref SgtPosition b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Equal(ref SgtPosition a, ref SgtPosition b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 Direction(ref SgtPosition a, ref SgtPosition b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SgtPosition Lerp(SgtPosition a, SgtPosition b, double t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 Vector(ref SgtPosition a, ref SgtPosition b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SnapLocal() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SgtPosition operator +(SgtPosition a, SgtPosition b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SgtPosition operator +(SgtPosition a, Vector3 b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SgtPosition operator +(Vector3 a, SgtPosition b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private long CalculateShift(double coordinate, double cellSize) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static SgtPosition() => throw null;
  }
}
