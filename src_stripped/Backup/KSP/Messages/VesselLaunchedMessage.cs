// Decompiled with JetBrains decompiler
// Type: KSP.Messages.VesselLaunchedMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.impl;
using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Flight/OnVesselLaunchedMessage", true, "Message fired when a vessel is launched, i.e. stops being landed.", "")]
  public class VesselLaunchedMessage : VesselMessage
  {
    public IGGuid VesselID;
    public IGGuid LaunchLocation;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VesselLaunchedMessage() => throw null;
  }
}
