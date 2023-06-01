// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.OrbitalElements
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public struct OrbitalElements
  {
    public double Inclination;
    public double Eccentricity;
    public double SemiMajorAxis;
    public double LongitudeOfAscendingNode;
    public double ArgumentOfPeriapsis;
    public double MeanAnomalyAtEpoch;
    public double Epoch;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OrbitalElements(
      double inclination,
      double eccentricity,
      double semiMajorAxis,
      double longitudeOfAscendingNode,
      double argumentOfPeriapsis,
      double meanAnomalyAtEpoch,
      double epoch)
    {
      throw null;
    }
  }
}
