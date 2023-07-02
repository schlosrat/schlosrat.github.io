// Decompiled with JetBrains decompiler
// Type: KSP.Messages.PropertyWatchers.VesselSurfaceSpeedPropertyWatcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Messages.PropertyWatchers
{
  [DiscoverableProperty("Properties/Vehicle/Speed/Surface", true, "Speed of the vehicle with respect to the surface of its reference CelestialBody", "")]
  public class VesselSurfaceSpeedPropertyWatcher : VehiclePropertyWatcher
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetValueDouble() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VesselSurfaceSpeedPropertyWatcher() => throw null;
  }
}
