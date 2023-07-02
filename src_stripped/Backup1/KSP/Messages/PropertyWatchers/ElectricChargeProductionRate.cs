// Decompiled with JetBrains decompiler
// Type: KSP.Messages.PropertyWatchers.ElectricChargeProductionRate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Messages.PropertyWatchers
{
  [DiscoverableProperty("Properties/Vehicle/ElectricChargeProductionRate", true, "The rate of electrical charge the vessel is receiving", "")]
  public class ElectricChargeProductionRate : VehiclePropertyWatcher
  {
    private const string ELECTRIC_CHARGE_RESOURCE_NAME = "ElectricCharge";
    private double _rate;
    private float _timeBetweenChecks;
    private float _timeToWaitTill;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Type baseType() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetValueDouble() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ElectricChargeProductionRate() => throw null;
  }
}
