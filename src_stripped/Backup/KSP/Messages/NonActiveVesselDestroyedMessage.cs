// Decompiled with JetBrains decompiler
// Type: KSP.Messages.NonActiveVesselDestroyedMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.impl;
using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Flight/Vessel/NonActiveVesselDestroyedMessage", true, "A non active vessel has been destroyed", "")]
  public class NonActiveVesselDestroyedMessage : FlightMessageBase
  {
    public IGGuid Guid;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NonActiveVesselDestroyedMessage() => throw null;
  }
}
