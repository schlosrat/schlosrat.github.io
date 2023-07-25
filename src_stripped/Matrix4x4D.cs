// Decompiled with JetBrains decompiler
// Type: Matrix4x4D
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;

public struct Matrix4x4D
{
  private double4x4 matrix;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  private double det2x2(double a, double b, double c, double d) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  private double det3x3(
    double a1,
    double a2,
    double a3,
    double b1,
    double b2,
    double b3,
    double c1,
    double c2,
    double c3)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static Matrix4x4D TRS(Vector3d translation, QuaternionD rotation, Vector3d scale) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static Matrix4x4D TRS(Vector3d translation, QuaternionD rotation) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public static Matrix4x4D Translate(Vector3d translation) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static Matrix4x4D Rotate(QuaternionD rotation) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public static Matrix4x4D Scale(Vector3d scale) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public Matrix4x4D SetTranslationScale(Vector3d scale) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public Matrix4x4D SetTranslate(double dx, double dy, double dz) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public Matrix4x4D SetRotateXaxis(double angle) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public Matrix4x4D SetRotateYaxis(double angle) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public Matrix4x4D SetRotateZaxis(double angle) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public Matrix4x4D SetRotateXaxis(double sina, double cosa) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public Matrix4x4D SetRotateYaxis(double sina, double cosa) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public Matrix4x4D SetRotateZaxis(double sina, double cosa) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public Matrix4x4D SetScale(double factor) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public Matrix4x4D SetScale(double sx, double sy, double sz) => throw null;

  public double m00
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public double m10
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public double m20
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public double m30
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public double m01
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public double m11
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public double m21
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public double m31
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public double m02
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public double m12
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public double m22
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public double m32
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public double m03
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public double m13
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public double m23
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public double m33
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public static Matrix4x4D Identity() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Matrix4x4D(
    double p00,
    double p01,
    double p02,
    double p03,
    double p10,
    double p11,
    double p12,
    double p13,
    double p20,
    double p21,
    double p22,
    double p23,
    double p30,
    double p31,
    double p32,
    double p33)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Matrix4x4D(double4x4 matrix) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Matrix4x4D(Matrix4x4 m) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public static explicit operator Matrix4x4D(Matrix4x4 m) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public static explicit operator Matrix4x4(Matrix4x4D m) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public bool IsIdentity() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public Matrix4x4D GetTranslation() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public Matrix4x4D GetRotateScale() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public Matrix4x4D SetZero() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public Matrix4x4D SetIdentity() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public Matrix4x4D SetInverse() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public Matrix4x4D GetInverse() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public Matrix4x4D GetTranspose() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public double Det() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public Vector3d TransformVector(Vector3d v) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public Vector3d TransformPoint(Vector3d v) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public static Matrix4x4D Multiply(Matrix4x4D first, Matrix4x4D second) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public static void MultiplyWithRef(ref Matrix4x4D first, Matrix4x4D second) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public static void GetInverseWithRef(ref Matrix4x4D matrixToInvert) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static Matrix4x4D ChainMultiply(Matrix4x4D m1, Matrix4x4D m2, Matrix4x4D m3) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static Matrix4x4D ChainMultiply(
    Matrix4x4D m1,
    Matrix4x4D m2,
    Matrix4x4D m3,
    Matrix4x4D m4)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public void TransformPlane(ref Vector3d normal, ref double distance) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public Plane TransformPlane(Plane plane) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static Matrix4x4D operator +(Matrix4x4D m1, Matrix4x4D m2) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static Matrix4x4D operator -(Matrix4x4D m1, Matrix4x4D m2) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override string ToString() => throw null;
}
