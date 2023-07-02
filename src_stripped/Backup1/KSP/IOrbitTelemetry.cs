// Decompiled with JetBrains decompiler
// Type: KSP.IOrbitTelemetry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
