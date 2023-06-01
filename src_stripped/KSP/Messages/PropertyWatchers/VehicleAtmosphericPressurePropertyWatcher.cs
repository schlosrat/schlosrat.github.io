// Decompiled with JetBrains decompiler
// Type: KSP.Messages.PropertyWatchers.VehicleAtmosphericPressurePropertyWatcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Messages.PropertyWatchers
{
  [DiscoverableProperty("Properties/Vehicle/AtmosphericPressure", false, "The static pressure in pascals", "")]
  public class VehicleAtmosphericPressurePropertyWatcher : VehiclePropertyWatcher
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetValueDouble() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VehicleAtmosphericPressurePropertyWatcher() => throw null;
  }
}
