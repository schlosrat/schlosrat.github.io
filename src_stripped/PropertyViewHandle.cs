// Decompiled with JetBrains decompiler
// Type: PropertyViewHandle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Messages;
using KSP.Sim.impl;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class PropertyViewHandle
{
  private ViewController _viewController;
  private List<string> keysPassed;
  private bool _hasInitialized;
  public Dictionary<string, (bool, string)> hasPartInVessel;
  public Dictionary<string, (bool, string)> hasPartGroupInVessel;
  public (string, int) MyPlayerLastFTUEMissionStageCompleted;
  public (string, int) MyPlayerLastMissionStageCompleted;
  public (string, int) MyPlayerLastTutorialStageCompleted;
  private SubscriptionHandle _onVesselChangedMessage;
  private SubscriptionHandle _onVesselDockedMessage;
  private SubscriptionHandle _onVesselUndockedMessage;
  private SubscriptionHandle _onStageActivatedMessage;
  private SubscriptionHandle _onPartDestroyedMessage;
  private SubscriptionHandle _onLastMissionStageCompletedMessage;
  private SubscriptionHandle _onGameStateChangedMessage;

  private GameInstance Game
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public MessageCenter Messages
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SubscribeToMessages(ViewController viewController) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void UnSubscribeToMessages() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Initialize() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool TryGeneratePropertyKey(string missionID, string inputValue, out string key) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnVesselChangedMessage(MessageCenterMessage msg) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnVesselDockedMessage(MessageCenterMessage msg) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnVesselUndockedMessage(MessageCenterMessage msg) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnPartDestroyedMessage(MessageCenterMessage msg) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnStageActivatedMessage(MessageCenterMessage msg) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnMissionStageCompleted(MessageCenterMessage msg) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnGameStateChangedMessage(MessageCenterMessage msg) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ResetCachedLastMissionStagesActivated() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void HasPartInVesselChecker() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public PropertyViewHandle() => throw null;
}
