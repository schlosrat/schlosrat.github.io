// Decompiled with JetBrains decompiler
// Type: KSP.Messages.VesselThrottleLockedDueToTimewarpingMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Flights/Vessel/VesselThrottleLockedDueToTimewarpMessage", true, "Throttle change but cant because timewarping", "")]
  public class VesselThrottleLockedDueToTimewarpingMessage : VesselMessage
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public VesselThrottleLockedDueToTimewarpingMessage() => throw null;
  }
}
