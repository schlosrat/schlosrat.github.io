// Decompiled with JetBrains decompiler
// Type: KSP.Messages.PropertyWatchers.PlannedManeuverApoapsis
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Messages.PropertyWatchers
{
  [DiscoverableProperty("Properties/Vehicle/PlannedManeuverApoapsis", false, "Maneuver node apoapsis value in double (above the celestial body radius level).", "Checks the apoapsis of the current maneuver node orbit.")]
  public class PlannedManeuverApoapsis : VehiclePropertyWatcher
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetValueDouble() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PlannedManeuverApoapsis() => throw null;
  }
}
