// Decompiled with JetBrains decompiler
// Type: KSP.Messages.ManeuverRequestOrbitNodeHighlightMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Map;
using KSP.Sim.impl;
using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  public class ManeuverRequestOrbitNodeHighlightMessage : MessageCenterMessage
  {
    public IGGuid simObjectGUID;
    public Map3DTrajectoryEvents.EventType orbitNodeType;
    public double UToffset;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ManeuverRequestOrbitNodeHighlightMessage() => throw null;
  }
}
