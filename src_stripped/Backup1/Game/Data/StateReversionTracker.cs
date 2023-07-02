// Decompiled with JetBrains decompiler
// Type: Game.Data.StateReversionTracker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Game.Flow;
using KSP.Messages;
using KSP.Sim;
using KSP.Sim.impl;
using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace Game.Data
{
  public class StateReversionTracker
  {
    private SubscriptionHandle _handleVesselCreated;
    private SubscriptionHandle _handleRevertToLaunch;
    private SubscriptionHandle _handleRevertToVAB;
    private byte[] _saveGameData;
    private byte[] _saveVABGameData;
    private SerializedAssembly exitDataVAB;
    private Action<SerializedAssembly> onCompleteVAB;
    private string _lastVesselCreatedName;
    private string _lastLaunchedAssemblyName;
    private VesselComponent _activeVessel;
    public bool OABWorkspaceDirty;

    private GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool HasValidReversionState
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool HasValidVABReversionState
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Shutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedAssembly GetLastSerializedAssembly() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsLastLaunchedAssemblyTheActiveVessel() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsLastLaunchedVesselTheActiveVessel() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselCreated(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator DelayedStateSave() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnRevertToLaunch(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnLoadOrSaveCampaignFinishedCallback(
      LoadOrSaveCampaignTicket loadOrSaveCampaignTicket,
      bool success)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LaunchFromVAB(SerializedAssembly assembly, Action<SerializedAssembly> onComplete) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnRevertToVAB(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StateReversionTracker() => throw null;

    public class ResetRevertDataAction : FlowAction
    {
      private StateReversionTracker _tracker;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public ResetRevertDataAction(GameInstance game) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      protected override void DoAction(Action resolve, Action<string> reject) => throw null;
    }
  }
}
