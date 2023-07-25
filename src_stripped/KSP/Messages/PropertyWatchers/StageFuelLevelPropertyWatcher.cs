// Decompiled with JetBrains decompiler
// Type: KSP.Messages.PropertyWatchers.StageFuelLevelPropertyWatcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Messages.PropertyWatchers
{
  [DiscoverableProperty("Properties/Vehicle/Fuel/Stage", false, "Returns the active stage's fuel level as a percentage out of 100", "The % does not need to be 0 for an engine to be starved. Returns -1 for an invalid ActiveVessel or a vessel iwth 0 fuel tanks remaining.")]
  public class StageFuelLevelPropertyWatcher : VehiclePropertyWatcher
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetValueDouble() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StageFuelLevelPropertyWatcher() => throw null;
  }
}
