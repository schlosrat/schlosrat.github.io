// Decompiled with JetBrains decompiler
// Type: KSP.Messages.PropertyWatchers.OABXAxisCenterOfLiftOffsetCenterOfMassPropertyWatcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
