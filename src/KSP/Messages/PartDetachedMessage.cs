// Decompiled with JetBrains decompiler
// Type: KSP.Messages.PartDetachedMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.impl;
using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Flight/Parts/PartDetachedMessage", false, "A part was detached from the main vehicle assembly", "")]
  public class PartDetachedMessage : FlightMessageBase
  {
    public PartBehavior PartBehavior;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartDetachedMessage() => throw null;
  }
}
