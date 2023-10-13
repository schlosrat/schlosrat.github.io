// Decompiled with JetBrains decompiler
// Type: KSP.Game.Load.LoadKSP2MissionDataFlowAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Game.Missions;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game.Load
{
  public class LoadKSP2MissionDataFlowAction : SaveLoadGameFlowActionBase
  {
    private Action _resolve;
    private int _loadingDependenciesRemaining;
    private KSP2MissionManager _missionManager;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LoadKSP2MissionDataFlowAction(LoadGameData data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnAssetLoadFinished(GameObject obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CheckFlowActionStatus() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void DoAction(Action resolve, Action<string> reject) => throw null;
  }
}
