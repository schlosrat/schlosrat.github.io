// Decompiled with JetBrains decompiler
// Type: KSP.Messages.PropertyWatchers.OABYAxisCenterOfLiftOffsetCenterOfMassPropertyWatcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Messages.PropertyWatchers
{
  [DiscoverableProperty("Properties/OAB/YAxisCenterOfLiftOffsetCenterOfMass", false, "Returns the offset in Y between the current assemly Center of Lift and Center of Mass, returns 9999 if any reference is invalid", "Substracts the center of mass axis and the center of lift offset.y")]
  public class OABYAxisCenterOfLiftOffsetCenterOfMassPropertyWatcher : OABPropertyWatcher
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetValueDouble() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OABYAxisCenterOfLiftOffsetCenterOfMassPropertyWatcher() => throw null;
  }
}
