// Decompiled with JetBrains decompiler
// Type: KSP.Messages.VesselTargetChange
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.impl;
using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Flight/ActiveVesselTargetChange", false, "The target of a vessel has updated", "")]
  public class VesselTargetChange : FlightMessageBase
  {
    public IGGuid vesselID;
    public IGGuid targetID;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VesselTargetChange() => throw null;
  }
}
