// Decompiled with JetBrains decompiler
// Type: KSP.Messages.PropertyWatchers.OABXAxisCenterOfLiftOffsetCenterOfMassPropertyWatcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Messages.PropertyWatchers
{
  [DiscoverableProperty("Properties/OAB/XAxisCenterOfLiftOffsetCenterOfMass", false, "Returns the offset in X between the current assemly Center of Lift and Center of Mass, returns 9999 if any reference is invalid", "Substracts the center of mass axis and the center of lift offset.x")]
  public class OABXAxisCenterOfLiftOffsetCenterOfMassPropertyWatcher : OABPropertyWatcher
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetValueDouble() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OABXAxisCenterOfLiftOffsetCenterOfMassPropertyWatcher() => throw null;
  }
}
