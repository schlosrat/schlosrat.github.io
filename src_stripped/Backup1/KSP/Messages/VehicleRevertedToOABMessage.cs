// Decompiled with JetBrains decompiler
// Type: KSP.Messages.VehicleRevertedToOABMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.OAB;
using KSP.Sim.impl;
using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Flight/VehicleRevertedToOABMessage", true, "Player has reverted a vehicle to VAB", "")]
  public class VehicleRevertedToOABMessage : MessageCenterMessage
  {
    public IGGuid vesselID;
    public ObjectAssemblyBuilder CurrentOAB;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VehicleRevertedToOABMessage() => throw null;
  }
}
