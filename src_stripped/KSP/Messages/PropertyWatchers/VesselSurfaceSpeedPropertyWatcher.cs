// Decompiled with JetBrains decompiler
// Type: KSP.Messages.PropertyWatchers.VesselSurfaceSpeedPropertyWatcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
