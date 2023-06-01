// Decompiled with JetBrains decompiler
// Type: KSP.Messages.VesselSplitMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.impl;
using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  public class VesselSplitMessage : FlightMessageBase
  {
    public VesselComponent remainingVessel;
    public VesselComponent newVessel;
    public bool isNewVesselFromSubVessel;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VesselSplitMessage() => throw null;
  }
}
