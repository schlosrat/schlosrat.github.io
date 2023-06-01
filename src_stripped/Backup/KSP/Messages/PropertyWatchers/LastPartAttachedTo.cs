// Decompiled with JetBrains decompiler
// Type: KSP.Messages.PropertyWatchers.LastPartAttachedTo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
