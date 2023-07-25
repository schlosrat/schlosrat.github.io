// Decompiled with JetBrains decompiler
// Type: UtilMath
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class UtilMath
{
  public const double Rad2Deg = 57.295779513082323;
  public const double Deg2Rad = 0.017453292519943295;
  public const double SQRT_TWO = 1.41421356237;
  public const float EQUAL_DOT_PRODUCT_THRESHOLD = 0.999998f;
  public const float DEGREES_360 = 360f;
  public const float DEGREES_180 = 180f;
  public const float DEGREES_90 = 90f;
  public static double TwoPI;
  public static float TwoPIf;
  public static double HalfPI;
  public static float HalfPIf;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void SwapValues(ref double a, ref double b) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static double Lerp(double a, double b, double t) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static double LerpUnclamped(double a, double b, double t) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static double InverseLerp(double a, double b, double t) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static double DegreesToRadians(double degrees) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static double RadiansToDegrees(double radians) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static double ASinh(double x) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static double ACosh(double x) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static double ATanh(double x) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static double ACoth(double x) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static double ASech(double x) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static double ACsch(double x) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static double Sech(double x) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static double Csch(double x) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static double Coth(double x) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static float WrapAround(float value, float min, float max) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static double WrapAround(double value, double min, double max) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static int WrapAround(int value, int min, int max) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static double Clamp(double value, double min, double max) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static double Clamp01(double value) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static float ClampAngle180(float angle) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static float ClampAngle360(float angle) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static double Flatten(double z, double midPoint, double easing) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static bool Approximately(double a, double b) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static double Max(params double[] values) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static double Min(params double[] values) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static T MaxFrom<T>(Func<T, double> getValue, params T[] values) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static T MinFrom<T>(Func<T, double> getValue, params T[] values) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static T MinFrom<T>(Func<T, double> getValue, out double min, params T[] values) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static T MaxFrom<T>(Func<T, double> getValue, out double max, params T[] values) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static T MaxFrom<T>(Func<T, float> getValue, params T[] values) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static T MinFrom<T>(Func<T, float> getValue, params T[] values) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static T MinFrom<T>(Func<T, float> getValue, out float min, params T[] values) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static T MaxFrom<T>(Func<T, float> getValue, out float max, params T[] values) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static float RoundToPlaces(float value, int decimalPlaces) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static double RoundToPlaces(double value, int decimalPlaces) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static int BSPSolver(
    ref double v0,
    double dv,
    Func<double, double> solveFor,
    double vMin,
    double vMax,
    double epsilon,
    int maxIterations)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static int BSPSolver(
    ref float v0,
    float dv,
    Func<float, float> solveFor,
    float vMin,
    float vMax,
    float epsilon,
    int maxIterations)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static bool IsDivisible(int n, int byN) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static bool IsPowerOfTwo(int x) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static bool Approximately(double a, double b, double epsilon = 4.94065645841247E-324) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static double[] ShiftToZero(double[] input, double amount) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static float ApproachValue(
    float targetValue,
    float currentValue,
    float speed,
    float deltaTime)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static Vector3 ApproachValue(
    Vector3 targetValue,
    Vector3 currentValue,
    float speed,
    float deltaTime)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static float InterpolateValueSinus(float elapsedValue) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static float RemapLinearInterpolateValue(
    float sourceMin,
    float sourceMax,
    float targetMin,
    float targetMax,
    float sourceValue)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static double PositiveMod(double dividend, int divisor) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static float InterpolateValueWithFunction(float elapsedValue, BlendFunction function) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public UtilMath() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static UtilMath() => throw null;
}
