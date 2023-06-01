// Decompiled with JetBrains decompiler
// Type: KSP.Messages.PropertyWatchers.CurrentGameStatePropertyWatcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Messages.PropertyWatchers
{
  [DiscoverableProperty("Properties/Game/State/CurrentState", true, "Returns the current game state", "")]
  public class CurrentGameStatePropertyWatcher : GamePropertyWatcher
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Type baseType() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int GetValueInt() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CurrentGameStatePropertyWatcher() => throw null;
  }
}
