// Decompiled with JetBrains decompiler
// Type: KSP.Messages.PropertyWatchers.OABLastPartPlacedPropertyWatcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Messages.PropertyWatchers
{
  [DiscoverableProperty("Properties/OAB/LastPartPlaced", true, "Returns the UniqueID of the last part the player put down in the OAB, will return an empty string if the last placed part becomes deleted for any reason.", "")]
  public class OABLastPartPlacedPropertyWatcher : OABPropertyWatcher
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Type baseType() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string GetValueString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OABLastPartPlacedPropertyWatcher() => throw null;
  }
}
