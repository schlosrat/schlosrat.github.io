// Decompiled with JetBrains decompiler
// Type: KSP.Sim.IDynamicOrbit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api;
using KSP.Sim.impl;

namespace KSP.Sim
{
  public interface IDynamicOrbit : IOrbit
  {
    void UpdateFromOrbitAtUT(IOrbit orbit, double UT, CelestialBodyComponent toBody);

    void UpdateFromStateVectors(
      Position pos,
      Velocity vel,
      CelestialBodyComponent refBody,
      double UT);

    void UpdateFromStateVectors(
      ICoordinateSystem coordinateSystem,
      Vector3d pos,
      IMotion relativeMotion,
      Vector3d vel,
      CelestialBodyComponent refBody,
      double UT);
  }
}
