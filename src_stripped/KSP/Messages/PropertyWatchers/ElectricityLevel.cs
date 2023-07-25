// Decompiled with JetBrains decompiler
// Type: KSP.Messages.PropertyWatchers.ElectricityLevel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Messages.PropertyWatchers
{
  [DiscoverableProperty("Properties/Vehicle/Resources/ElectricityLevel", true, "Returns the amount of electricity stored as a percentage of its capacity", "")]
  public class ElectricityLevel : VehiclePropertyWatcher
  {
    private float _timeBetweenChecks;
    private float _timeToWaitTill;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Type baseType() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetValueDouble() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ElectricityLevel() => throw null;
  }
}
