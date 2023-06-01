// Decompiled with JetBrains decompiler
// Type: Game.Data.StateReversionTracker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
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
  }
}
