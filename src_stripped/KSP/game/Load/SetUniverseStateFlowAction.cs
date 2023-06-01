// Decompiled with JetBrains decompiler
// Type: KSP.Game.Load.SetUniverseStateFlowAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Game.Load
{
  public class SetUniverseStateFlowAction : SaveLoadGameFlowActionBase
  {
    private Action _resolve;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SetUniverseStateFlowAction(LoadGameData data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void DoAction(Action resolve, Action<string> reject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnUniverseStateUpdated(string guid) => throw null;
  }
}
