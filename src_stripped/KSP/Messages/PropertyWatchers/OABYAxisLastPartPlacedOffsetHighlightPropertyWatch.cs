// Decompiled with JetBrains decompiler
// Type: KSP.Messages.PropertyWatchers.OABYAxisLastPartPlacedOffsetHighlightPropertyWatcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Messages.PropertyWatchers
{
  [DiscoverableProperty("Properties/OAB/YAxisLastPartPlacedOffsetHighlight", false, "Returns the offset in Y within the last placed part and the highlight attach point in world coords, returns 9999 if any is invalid", "Substracts LastPartPlaced.PartTransform.position and highlightAttachPoint.position and returns the offset.y")]
  public class OABYAxisLastPartPlacedOffsetHighlightPropertyWatcher : OABPropertyWatcher
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetValueDouble() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OABYAxisLastPartPlacedOffsetHighlightPropertyWatcher() => throw null;
  }
}
