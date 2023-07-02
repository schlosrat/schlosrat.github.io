// Decompiled with JetBrains decompiler
// Type: KSP.Utilities.CelestialUtilities
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.impl;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Utilities
{
  public class CelestialUtilities
  {
    private IUniverseView universeView;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialUtilities(IUniverseView universeView) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static CelestialBodyBehavior RandomBody(List<CelestialBodyBehavior> bodies) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double GetHighestPeak(CelestialBodyBehavior body) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double GetMinimumOrbitalDistance(CelestialBodyBehavior body, float margin) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsGasGiant(CelestialBodyBehavior body) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 LLAtoECEF(double lat, double lon, double alt, double radius) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double SynchronousSMA(CelestialBodyBehavior body) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double KolniyaSMA(CelestialBodyBehavior body) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double TerrainAltitude(
      CelestialBodyBehavior body,
      double latitude,
      double longitude,
      bool underwater = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetSolarExtents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double GreatCircleDistance(
      CelestialBodyBehavior body,
      double latitude1,
      double longitude1,
      double latitude2,
      double longitude2)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double GetDifferenceInCoordinates(double valueA, double valueB) => throw null;
  }
}
