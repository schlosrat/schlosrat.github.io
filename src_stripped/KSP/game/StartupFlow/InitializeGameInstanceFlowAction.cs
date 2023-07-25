// Decompiled with JetBrains decompiler
// Type: KSP.Game.StartupFlow.InitializeGameInstanceFlowAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game.Flow;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Game.StartupFlow
{
  public class InitializeGameInstanceFlowAction : FlowAction
  {
    private readonly Func<GameInstance> _game;
    private readonly GameStatesConfiguration _stateConfiguration;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public InitializeGameInstanceFlowAction(
      string name,
      Func<GameInstance> game,
      GameStatesConfiguration stateConfiguration)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void DoAction(Action resolve, Action<string> reject) => throw null;
  }
}
