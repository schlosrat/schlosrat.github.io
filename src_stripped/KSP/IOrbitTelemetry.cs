// Decompiled with JetBrains decompiler
// Type: KSP.IOrbitTelemetry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
