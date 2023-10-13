// Decompiled with JetBrains decompiler
// Type: KSP.Game.StartupFlow.InitializeGameInstanceFlowAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
