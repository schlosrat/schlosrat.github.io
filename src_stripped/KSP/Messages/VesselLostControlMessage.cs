// Decompiled with JetBrains decompiler
// Type: KSP.Messages.VesselLostControlMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
