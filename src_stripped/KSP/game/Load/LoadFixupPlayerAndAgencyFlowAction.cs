// Decompiled with JetBrains decompiler
// Type: KSP.Game.Load.LoadFixupPlayerAndAgencyFlowAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Game.Load
{
  public class LoadFixupPlayerAndAgencyFlowAction : SaveLoadGameFlowActionBase
  {
    private LoadOrSaveCampaignTicket _loadOrSaveCampaignTicket;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LoadFixupPlayerAndAgencyFlowAction(LoadOrSaveCampaignTicket loadOrSaveCampaignTicket) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TakeOverPlayer(CampaignPlayerEntry campaignPlayerEntry) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ChangeVesselOwners(
      string oldPlayerNameString,
      string oldPlayerGuidString,
      byte oldPlayerId,
      string newPlayerNameString,
      string newPlayerGuidString,
      byte newPlayerId)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void MakeAllVesselsBeOwnedByThisPlayer(
      string playerNameString,
      string playerGuidString,
      byte playerId)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void DoAction(Action resolve, Action<string> reject) => throw null;
  }
}
