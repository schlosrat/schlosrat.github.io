// Decompiled with JetBrains decompiler
// Type: KSP.Game.GameStateMachine
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Messages;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Game
{
  public class GameStateMachine : SimpleStateMachine<GameState>
  {
    private List<GameStateConfiguration> _possibleStates;
    private SubscriptionHandle _stateChangeHandle;
    private GameInstance _game;
    private bool _paused;

    public bool Paused
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void PublishStateLeftMessage(
      MessageCenter messageCenter,
      GameState StateBeingLeft)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void PublishStateChangedMessage(
      MessageCenter messageCenter,
      GameState stateBeingLeft,
      GameState stateBeingEntered)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void PublishStateEnteredMessage(
      MessageCenter messageCenter,
      GameState StateBeingEntered)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameStateMachine(GameState initialState, GameInstance game) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameStateConfiguration GetGameState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameStateConfiguration GetLastGameState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetConfiguration(GameStatesConfiguration stateConfiguration) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void BackToPreviousState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnStateChange(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnStateExit(GameState previousState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnStateEnter(GameState currentState) => throw null;
  }
}
