// Decompiled with JetBrains decompiler
// Type: KSP.OcclusionCone
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP
{
  public class OcclusionCone
  {
    public ThermalOcclusionData part;
    public Vector3 center;
    public Vector2 extents;
    public Vector2 offset;
    public double radius;
    public double CylinderNoseDot;
    public double ShockNoseDot;
    public double ShockAngle;
    public double ShockConvectionTemperatureMultiplier;
    public double ShockConvectionCoefficientMultiplier;
    public double OccludeConvectionTemperatureMultiplier;
    public double OccludeConvectionCoefficientMultiplier;
    public double OccludeConvectionAreaMultiplier;
    public static double detachedShockHeatMult;
    public static double detachedShockCoeffMult;
    public static double detachedBehindShockHeatMult;
    public static double detachedBehindShockCoeffMult;
    public static double detachedShockMachAngleMult;
    public static double detachedShockStartAngle;
    public static double detachedShockEndAngle;
    public static double obliqueShockAngleMult;
    public static double obliqueShockPartAngleMult;
    public static double obliqueShockMinAngleMult;
    public static double obliqueShockConeHeatMult;
    public static double obliqueShockConeCoeffMult;
    public static double obliqueShockCylHeatMult;
    public static double obliqueShockCylCoeffMult;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Setup(
      ThermalOcclusionData occlusionData,
      double sqrtMach,
      double sqrtMachAngle,
      double detachAngle)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetShockRadius(double dot) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OcclusionCone() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static OcclusionCone() => throw null;
  }
}
