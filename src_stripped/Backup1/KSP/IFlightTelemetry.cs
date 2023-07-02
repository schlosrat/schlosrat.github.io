// Decompiled with JetBrains decompiler
// Type: KSP.IFlightTelemetry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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

    double AltitudeFromSurface { get; }

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
