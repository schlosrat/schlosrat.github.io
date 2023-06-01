// Decompiled with JetBrains decompiler
// Type: KSP.Messages.ObserverCannotLeaveActiveVesselMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Flight/ObserverCannotLeaveActiveVesselMessage", true, "The observer cannot leave the current vessel", "")]
  public class ObserverCannotLeaveActiveVesselMessage : FlightMessageBase
  {
    public string VesselName;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObserverCannotLeaveActiveVesselMessage() => throw null;
  }
}
