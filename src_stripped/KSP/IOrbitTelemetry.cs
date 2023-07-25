// Decompiled with JetBrains decompiler
// Type: KSP.IOrbitTelemetry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;

namespace KSP
{
  public interface IOrbitTelemetry : IFlightTelemetry, IVehicleTelemetry
  {
    Vector OrbitPrograde { get; }

    Vector OrbitRetrograde { get; }

    Vector OrbitNormal { get; }

    Vector OrbitAntiNormal { get; }

    Vector OrbitRadialIn { get; }

    Vector OrbitRadialOut { get; }

    Vector OrbitalVelocity { get; }

    double OrbitalSpeed { get; }

    IOrbit Orbit { get; }
  }
}
