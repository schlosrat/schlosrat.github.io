// Decompiled with JetBrains decompiler
// Type: KSP.Game.Load.LoadKSP2MissionDataFlowAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game.Load
{
  public class LoadKSP2MissionDataFlowAction : SaveLoadGameFlowActionBase
  {
    private Action _resolve;
    private int _loadingDependenciesRemaining;

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
