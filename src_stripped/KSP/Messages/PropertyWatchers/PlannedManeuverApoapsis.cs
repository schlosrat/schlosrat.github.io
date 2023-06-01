// Decompiled with JetBrains decompiler
// Type: KSP.Messages.PropertyWatchers.PlannedManeuverApoapsis
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
