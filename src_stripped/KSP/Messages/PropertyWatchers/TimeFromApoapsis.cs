// Decompiled with JetBrains decompiler
// Type: KSP.Messages.PropertyWatchers.TimeFromApoapsis
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Messages.PropertyWatchers
{
  [DiscoverableProperty("Properties/Vehicle/TimeFromApoapsis", false, "Time from apoapsis value in double.", "The time (in seconds) from the active vessel's current position to its orbit's apoapsis. Intended to measure orbital positions.")]
  public class TimeFromApoapsis : VehiclePropertyWatcher
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetValueDouble() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TimeFromApoapsis() => throw null;
  }
}
