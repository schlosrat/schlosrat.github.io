// Decompiled with JetBrains decompiler
// Type: KSP.Messages.RevertToLaunchMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.impl;
using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Flight/RevertToLaunchMessage", true, "Player has reverted a vehicle to a launch location", "")]
  public class RevertToLaunchMessage : MessageCenterMessage
  {
    public IGGuid vesselID;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RevertToLaunchMessage() => throw null;
  }
}
