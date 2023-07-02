// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.OrbitalElements
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
