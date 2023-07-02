// Decompiled with JetBrains decompiler
// Type: KSP.Messages.VesselAcquiredNewResourceMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Flight/Vessel/VesselAcquiredNewResourceMessage", false, "Vessel has acquired a new (vessel has never had the resource) resource via drilling or transfer", "")]
  public class VesselAcquiredNewResourceMessage : FlightMessageBase
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public VesselAcquiredNewResourceMessage() => throw null;
  }
}
