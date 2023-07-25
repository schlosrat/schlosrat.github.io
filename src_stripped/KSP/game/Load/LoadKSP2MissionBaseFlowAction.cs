// Decompiled with JetBrains decompiler
// Type: KSP.Game.Load.LoadKSP2MissionBaseFlowAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
