// Decompiled with JetBrains decompiler
// Type: KSP.Messages.VesselCreatedMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
