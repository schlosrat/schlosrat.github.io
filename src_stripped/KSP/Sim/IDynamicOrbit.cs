// Decompiled with JetBrains decompiler
// Type: KSP.Sim.IDynamicOrbit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
