// Decompiled with JetBrains decompiler
// Type: EdyCommonTools.MathUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace EdyCommonTools
{
  public static class MathUtility
  {
    public static float RpmToW;
    public static float WToRpm;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float ClampAngle(float angle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float ClampAngle360(float angle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float Vector2Angle(Vector2 v1, Vector3 v2, bool use360Range = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float FastAbs(float x) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int FastAbs(int x) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float MaxAbs(float a, float b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float MinAbs(float a, float b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Vector3Equals(Vector3 a, Vector3 b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Vector3Approximate(Vector3 a, Vector3 b, float sqrThreshold = 9.99999944E-11f) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float ClampMagnitude(float a, float min, float max) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float Max(float a, float b, params float[] n) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float Min(float a, float b, params float[] n) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsSimilarOrSmaller(float a, float b, float threshold = 0.0001f) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsSimilarOrGreater(float a, float b, float threshold = 0.0001f) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsSimilar(float a, float b, float threshold = 0.0001f) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float Lin2Log(float val) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 Lin2Log(Vector3 val) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 ClosestPointOnPlane(
      Vector3 planePoint,
      Vector3 planeNormal,
      Vector3 point)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float UnclampedLerp(float from, float to, float t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float LinearLerp(float x0, float y0, float x1, float y1, float x) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float LinearLerp(Vector2 from, Vector2 to, float t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float CubicLerp(float x0, float y0, float x1, float y1, float x) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float CubicLerp(Vector2 from, Vector2 to, float t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float TangentLerp(
      float x0,
      float y0,
      float x1,
      float y1,
      float a,
      float b,
      float x)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float TangentLerp(Vector2 from, Vector2 to, float a, float b, float t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float SmoothStep(float from, float to, float t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float SmootherStep(float from, float to, float t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float Ease(float x, float k) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float Step(float x, float k) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float Slope(float s) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static float GetMultiplier(int decimals) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float FloorDecimals(float value, int decimals) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 FloorDecimals(Vector3 value, int decimals) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float RoundDecimals(float value, int decimals) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 RoundDecimals(Vector3 value, int decimals) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 GetAxisVector(MathUtility.Axis axis) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 GetAxisVector(Transform transform, MathUtility.Axis axis) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string FormatBinary(int bytes, int decimals = 1) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool PlanePlaneIntersection(
      Vector3 plane1Position,
      Vector3 plane1Normal,
      Vector3 plane2Position,
      Vector3 plane2Normal,
      out Vector3 linePosition,
      out Vector3 lineDirection)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float DistancePointLine(
      Vector3 point,
      Vector3 linePosition,
      Vector3 lineDirection)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    static MathUtility() => throw null;

    public enum Axis
    {
      Right,
      Up,
      Forward,
      Left,
      Down,
      Back,
    }
  }
}
