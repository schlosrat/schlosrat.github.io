// Decompiled with JetBrains decompiler
// Type: KSP.Messages.ManeuverRequestOrbitNodeHighlightMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
