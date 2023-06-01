// Decompiled with JetBrains decompiler
// Type: KSP.Messages.CannotChangeNodeWhileOutOfFuelMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Map/CantChangeOutOfFuelManeuverNode", true, "Can’t manipulate this node because you’re out of fuel.", "")]
  public class CannotChangeNodeWhileOutOfFuelMessage : MessageCenterMessage
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CannotChangeNodeWhileOutOfFuelMessage() => throw null;
  }
}
