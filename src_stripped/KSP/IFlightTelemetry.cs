// Decompiled with JetBrains decompiler
// Type: KSP.IFlightTelemetry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim;

namespace KSP
{
  public interface IFlightTelemetry : IVehicleTelemetry
  {
    Vector SurfacePrograde { get; }

    Vector SurfaceRetrograde { get; }

    Vector Up { get; }

    Vector North { get; }

    Vector East { get; }

    Vector SurfaceVelocity { get; }

    double SurfaceSpeed { get; }

    double VerticalSpeed { get; }

    double HorizontalSpeed { get; }

    double Latitude { get; }

    double Longitude { get; }

    double AltitudeFromRadius { get; }

    double AltitudeFromSeaLevel { get; }

    double AltitudeFromTerrain { get; }

    double AltitudeFromScenery { get; }

    double StaticPressurekPa { get; }

    double DynamicPressurekPa { get; }

    double AtmosphericTemperature { get; }

    double ExternalTemperature { get; }

    double AtmosphericDensity { get; }

    double AtmosphericDensityNormalized { get; }

    double SoundSpeed { get; }

    double MachNumber { get; }

    double GeeForce { get; }

    bool LandedOrSplashed { get; set; }

    bool PatchedConicsAttached { get; set; }
  }
}
