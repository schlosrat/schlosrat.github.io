// Decompiled with JetBrains decompiler
// Type: KSP.Messages.PropertyWatchers.VehicleLongitudePropertyWatcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Messages.PropertyWatchers
{
  [DiscoverableProperty("Properties/Vehicle/VehicleLongitude", false, "Active Vessel Longitude Coordinate value.", "Checks the Active Sim VesselComponent.Longitude which is it's telemetry TelemetryComponent Longitude value.")]
  public class VehicleLongitudePropertyWatcher : VehiclePropertyWatcher
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetValueDouble() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VehicleLongitudePropertyWatcher() => throw null;
  }
}
