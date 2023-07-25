// Decompiled with JetBrains decompiler
// Type: KSP.Tools.PQSFreeCamUtils.PositionUtils
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Tools.PQSFreeCamUtils
{
  public static class PositionUtils
  {
    public const float FLOAT_COMPARISON_TOLERANCE = 1E-05f;
    public const double DEG2RAD = 0.017453292519943295;
    public const double RAD2DEG = 57.295779513082323;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public static Vector2d GetLonLatFromRadialPos(Vector3d radialNormal) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public static Vector3d GetRadialNormalFromLatLon(double lat, double lon) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public static Vector2d GetUnitVectorFromAngle(double camAngle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public static QuaternionD ComputeCamRotation(
      QuaternionD orientation,
      double camAngle,
      double camPitch)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public static double GetHeadingFromOrientationCamAngle(QuaternionD orientation, double camAngle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public static QuaternionD TranslateOrientation(
      QuaternionD orientation,
      double radius,
      double angle,
      double x,
      double y)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public static bool AreLatLonClose(
      double radius,
      double pos1Lat,
      double pos1Lon,
      double pos2Lat,
      double pos2Lon,
      float threshhold)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public static double GetLatLonDist(
      double radius,
      double pos1Lat,
      double pos1Lon,
      double pos2Lat,
      double pos2Lon)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool RaycastParametricSphere(
      double radius,
      Vector3d rayPos,
      Vector3d rayDir,
      out double t1,
      out double t2)
    {
      throw null;
    }
  }
}
