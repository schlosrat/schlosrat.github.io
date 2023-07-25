// Decompiled with JetBrains decompiler
// Type: UnityMathematicsUtils
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;

public static class UnityMathematicsUtils
{
  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public static double3 ToDouble3(Vector3 v) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public static double3 ToDouble3(Vector2 v) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public static double2 ToDouble2(Vector3 v) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public static double2 ToDouble2(Vector2 v) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public static double2 ToDouble2(float v) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public static double3 ToDouble3(float v) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public static Vector3 ToVector3(double3 v) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public static Vector3 ToVector3(double2 v) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public static Vector2 ToVector2(double3 v) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public static Vector2 ToVector2(double2 v) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public static Vector2 ToVector2(double v) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public static Vector3 ToVector3(double v) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public static double4x4 ToDouble4x4(Matrix4x4 matrix) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public static double3 DoMultiplyPoint3x4(double4x4 transformation, Vector3 point) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public static double4x4 GetLocalTransformMatrix(Transform transform) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public static double4x4 GetLocalTransformationMatrix(
    double3 localPosition,
    quaternion localRotation)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public static double4x4 GetTranslate(double3 pos) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public static double4x4 GetScale(double3 scale) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public static double4x4 GetScale(double scale) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public static double4x4 GetRotate(quaternion rot) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public static double FModAngleDegrees(double angle) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public static double2 FModAngleDegrees(double2 v) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  public static double3 FModAngleDegrees(double3 v) => throw null;

  public static class FloatingPointPrecision
  {
    public const int DOUBLE_MANTISA_BITS = 52;
    public const int FLOAT_MANTISA_BITS = 23;
    public const double COB_10TO2 = 0.3010299956639812;
    public static readonly double3 COB_10TO2_DOUBLE3;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public static double GetMaxDoubleValueForDesiredPrecision(double desiredPrecision) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public static double GetMaxFloatValueForDesiredPrecision(double desiredPrecision) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public static double GetPrecisionForDoubleValue(double doubleValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public static double3 GetPrecisionForDoubleValue(double3 doubleValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public static double GetPrecisionForFloatValue(float floatValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public static double3 GetPrecisionForFloatValue(float3 floatValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public static double GetPrecisionExponentBase2ForDoubleValue(double doubleValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public static double3 GetPrecisionExponentBase2ForDoubleValue(double3 doubleValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public static double GetPrecisionExponentBase2ForFloatValue(float floatValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public static double3 GetPrecisionExponentBase2ForFloatValue(float3 doubleValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public static double GetPrecisionExponentBase10ForDoubleValue(double doubleValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public static double3 GetPrecisionExponentBase10ForDoubleValue(double3 doubleValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public static double3 GetPrecisionExponentBase10ForFloatValue(float3 floatValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static FloatingPointPrecision() => throw null;
  }
}
