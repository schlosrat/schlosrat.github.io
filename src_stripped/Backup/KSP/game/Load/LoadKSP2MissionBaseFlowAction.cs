// Decompiled with JetBrains decompiler
// Type: KSP.Game.Load.LoadKSP2MissionBaseFlowAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game.Load
{
  public class LoadKSP2MissionBaseFlowAction : SaveLoadGameFlowActionBase
  {
    private LoadOrSaveCampaignTicket _loadOrSaveCampaignTicket;
    private Action _resolve;
    private List<string> _baseGlobalJsonStringList;
    private List<string> _baseAgencyJsonStringList;
    private List<string> _basePlayerJsonStringList;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LoadKSP2MissionBaseFlowAction(LoadOrSaveCampaignTicket loadOrSaveCampaignTicket) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnMissionDataItemLoaded(TextAsset textAsset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void DoAction(Action resolve, Action<string> reject) => throw null;
  }
}
