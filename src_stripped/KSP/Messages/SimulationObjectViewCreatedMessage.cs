// Decompiled with JetBrains decompiler
// Type: KSP.Messages.SimulationObjectViewCreatedMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Gameplay/SimulationObjectViewCreatedMessage", true, "", "")]
  public class SimulationObjectViewCreatedMessage : GameplayMessageBase
  {
    public ISimulationObjectView SimObjectView;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimulationObjectViewCreatedMessage() => throw null;
  }
}
