// Decompiled with JetBrains decompiler
// Type: QuaternionD
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using Newtonsoft.Json;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[JsonObject]
[DebuggerDisplay("QuaternionD = {x},{y},{z},{w}")]
public struct QuaternionD
{
  public static readonly QuaternionD Zero;
  public double x;
  public double y;
  public double z;
  public double w;

  public double this[int index]
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public Vector3d xyz
  {
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void FrameVectors(out Vector3d frameX, out Vector3d frameY, out Vector3d frameZ) => throw null;

  public QuaternionD swizzle
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static implicit operator Quaternion(QuaternionD q) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static implicit operator QuaternionD(Quaternion q) => throw null;

  public static QuaternionD identity
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public QuaternionD(double x, double y, double z, double w) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public QuaternionD(Vector3d v, double w) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static bool operator ==(QuaternionD lhs, QuaternionD rhs) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static bool operator !=(QuaternionD lhs, QuaternionD rhs) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public QuaternionD(Vector3d X, Vector3d Y, Vector3d Z) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static double Dot(QuaternionD a, QuaternionD b) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static QuaternionD Inverse(QuaternionD q) => throw null;

  public double Length
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public double LengthSquared
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Normalize() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void Normalize(ref QuaternionD q, out QuaternionD result) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static QuaternionD Normalize(QuaternionD q) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static Vector3d NormalizeAngles(Vector3d angles) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static double NormalizeAngle(double angle) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static Vector3d orthogonal(Vector3d v) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static QuaternionD FromToRotation(Vector3d fromDirection, Vector3d toDirection) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetFromToRotation(Vector3d fromDirection, Vector3d toDirection) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static QuaternionD LookRotation(Vector3d forward, Vector3d up) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static QuaternionD LookRotation(Vector3d forward) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetLookRotation(Vector3d view) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetLookRotation(Vector3d view, Vector3d up) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static QuaternionD Slerp(QuaternionD from, QuaternionD to, double t) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static QuaternionD UnclampedSlerp(QuaternionD from, QuaternionD to, double t) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static QuaternionD Lerp(QuaternionD from, QuaternionD to, double t) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static QuaternionD RotateTowards(QuaternionD from, QuaternionD to, double maxDegreesDelta) => throw null;

  public Vector3d eulerAngles
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static QuaternionD Euler(double x, double y, double z) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static QuaternionD Euler(Vector3d euler) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static QuaternionD Internal_FromEulerRad(Vector3d euler) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static Vector3d Internal_ToEulerRad(QuaternionD rotation) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static double Angle(QuaternionD a, QuaternionD b) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static QuaternionD AngleAxis(double angle, Vector3d axis) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void ToAngleAxis(out double angle, out Vector3d axis) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static void Internal_ToAxisAngleRad(QuaternionD q, out Vector3d axis, out double angle) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static QuaternionD RotateToNewUp(QuaternionD toRotate, Vector3d up) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override int GetHashCode() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override bool Equals(object other) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static QuaternionD operator *(QuaternionD lhs, QuaternionD rhs) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static Vector3d operator *(QuaternionD rotation, Vector3d point) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static Vector3d MulRef(in QuaternionD rotation, double x, double y, double z) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override string ToString() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public string ToString(string format) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static QuaternionD() => throw null;
}
