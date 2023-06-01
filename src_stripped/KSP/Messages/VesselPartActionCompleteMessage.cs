// Decompiled with JetBrains decompiler
// Type: KSP.Messages.VesselPartActionCompleteMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Flight/Vessel/VesselPartActionCompleteMessage", true, "Part Action fully deployed (ie. deploy solar panels, parachutes fully deployed)", "")]
  public class VesselPartActionCompleteMessage : FlightMessageBase
  {
    public string Guid;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VesselPartActionCompleteMessage() => throw null;
  }
}
