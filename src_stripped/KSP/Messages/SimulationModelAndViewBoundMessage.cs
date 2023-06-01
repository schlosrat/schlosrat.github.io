// Decompiled with JetBrains decompiler
// Type: KSP.Messages.SimulationModelAndViewBoundMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.impl;
using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Gameplay/SimulationModelAndViewBoundMessage", true, "", "")]
  public class SimulationModelAndViewBoundMessage : GameplayMessageBase
  {
    public SimulationObjectModel SimObjectModel;
    public ISimulationObjectView SimObjectView;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimulationModelAndViewBoundMessage() => throw null;
  }
}
