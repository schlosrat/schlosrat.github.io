// Decompiled with JetBrains decompiler
// Type: KSP.Messages.VesselCreatedMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Flight/Vessel/VesselCreatedMessage", true, "Player has created and place a vessel in the game", "")]
  public class VesselCreatedMessage : MessageCenterMessage
  {
    public IVehicle vehicle;
    public SerializedAssembly SerializedVessel;
    public SerializedLocation serializedLocation;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VesselCreatedMessage() => throw null;
  }
}
