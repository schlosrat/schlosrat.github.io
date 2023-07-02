// Decompiled with JetBrains decompiler
// Type: KSP.Messages.PropertyWatchers.VehicleHeadingPropertyWatcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Messages.PropertyWatchers
{
  [DiscoverableProperty("Properties/Vehicle/VehicleHeading", false, "Active Vessel Heading Coordinate value in double.", "Checks the Active Sim VesselComponent.Heading which is calculated on VesselComponent.")]
  public class VehicleHeadingPropertyWatcher : VehiclePropertyWatcher
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetValueDouble() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VehicleHeadingPropertyWatcher() => throw null;
  }
}
