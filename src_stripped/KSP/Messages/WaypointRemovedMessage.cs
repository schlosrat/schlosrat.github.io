// Decompiled with JetBrains decompiler
// Type: KSP.Messages.WaypointRemovedMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Sim.impl;
using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Mission/WaypointRemoved", true, "A waypoint has been removed", "")]
  public class WaypointRemovedMessage : MissionMessageBase
  {
    public IGGuid Guid;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public WaypointRemovedMessage() => throw null;
  }
}
