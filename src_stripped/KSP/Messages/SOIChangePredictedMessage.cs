// Decompiled with JetBrains decompiler
// Type: KSP.Messages.SOIChangePredictedMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Flight/SOIChangePredictedMessage", false, "Player's vehicles' trajectory intersects with another Sphere of Influence", "To be fired when a trajectory has been determined to intersect a SOI")]
  public class SOIChangePredictedMessage : FlightMessageBase
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SOIChangePredictedMessage() => throw null;
  }
}
