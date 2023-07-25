// Decompiled with JetBrains decompiler
// Type: RTG.Vector3Ex
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public static class Vector3Ex
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void OffsetPoints(List<Vector3> points, Vector3 offset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector2 ConvertDirTo2D(Vector3 start, Vector3 end, Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 Abs(this Vector3 v) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 GetSignVector(this Vector3 v) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float GetMaxAbsComp(this Vector3 v) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float Dot(this Vector3 v1, Vector3 v2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float AbsDot(this Vector3 v1, Vector3 v2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 FromValue(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float SignedAngle(Vector3 from, Vector3 to, Vector3 axis) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float GetDistanceToSegment(this Vector3 point, Vector3 point0, Vector3 point1) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 ProjectOnSegment(this Vector3 point, Vector3 point0, Vector3 point1) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int GetPointClosestToPoint(List<Vector3> points, Vector3 pt) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 GetPointCloudCenter(IEnumerable<Vector3> ptCloud) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 GetInverse(this Vector3 vector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsAligned(this Vector3 vector, Vector3 other, bool checkSameDirection) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool PointsSameDir(this Vector3 vector, Vector3 other) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int GetMostAligned(Vector3[] vectors, Vector3 dir, bool checkSameDirection) => throw null;
  }
}
