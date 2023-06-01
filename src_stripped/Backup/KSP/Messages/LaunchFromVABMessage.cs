// Decompiled with JetBrains decompiler
// Type: KSP.Messages.LaunchFromVABMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim;
using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Flight/LaunchFromVABMessage", true, "Player has launch a vehicle from VAB", "")]
  public class LaunchFromVABMessage : MessageCenterMessage
  {
    public IVehicle vehicle;
    public SerializedAssembly SerializedVessel;
    public SerializedLocation serializedLocation;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LaunchFromVABMessage() => throw null;
  }
}
