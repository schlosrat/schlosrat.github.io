// Decompiled with JetBrains decompiler
// Type: KSP.Messages.PropertyWatchers.VehicleLatitudePropertyWatcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Messages.PropertyWatchers
{
  [DiscoverableProperty("Properties/Vehicle/VehicleLatitude", false, "Active Vessel Latitude Coordinate value in double.", "Checks the Active Sim VesselComponent.Latitude which is it's telemetry TelemetryComponent Latitude value.")]
  public class VehicleLatitudePropertyWatcher : VehiclePropertyWatcher
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetValueDouble() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VehicleLatitudePropertyWatcher() => throw null;
  }
}
