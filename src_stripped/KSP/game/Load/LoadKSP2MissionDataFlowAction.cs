// Decompiled with JetBrains decompiler
// Type: KSP.Game.Load.LoadKSP2MissionDataFlowAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
