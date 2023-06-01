// Decompiled with JetBrains decompiler
// Type: KSP.Messages.NonActiveVesselNearManeuverMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Maneuver/NonActiveVesselNearManeuverMessage", true, "Inactive vessel is near maneuver node", "")]
  public class NonActiveVesselNearManeuverMessage : MessageCenterMessage
  {
    public string VesselName;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NonActiveVesselNearManeuverMessage() => throw null;
  }
}
