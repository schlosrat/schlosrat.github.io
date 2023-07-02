// Decompiled with JetBrains decompiler
// Type: KSP.Messages.VesselSplitMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
