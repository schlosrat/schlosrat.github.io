// Decompiled with JetBrains decompiler
// Type: KSP.Messages.VesselLostControlMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Flight/Vessel/VesselLostControlMessage", true, "Player's vehicle has lost control", "")]
  public class VesselLostControlMessage : VesselMessage
  {
    public CommandControlState CommandControlState;
    public string VesselName;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VesselLostControlMessage() => throw null;
  }
}
