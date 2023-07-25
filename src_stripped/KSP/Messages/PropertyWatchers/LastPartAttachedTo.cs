// Decompiled with JetBrains decompiler
// Type: KSP.Messages.PropertyWatchers.LastPartAttachedTo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Messages.PropertyWatchers
{
  [DiscoverableProperty("Properties/OAB/LastPartAttachedTo", true, "Returns the UniqueID of the last part that the player attached another part to. This is useful for checking more specific placement, and essential for tutorials that use compound parts like struts.", "")]
  public class LastPartAttachedTo : OABPropertyWatcher
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Type baseType() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string GetValueString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LastPartAttachedTo() => throw null;
  }
}
