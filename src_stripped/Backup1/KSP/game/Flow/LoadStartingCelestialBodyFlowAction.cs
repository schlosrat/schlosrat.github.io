// Decompiled with JetBrains decompiler
// Type: KSP.Game.Flow.LoadStartingCelestialBodyFlowAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game.Load;
using KSP.Sim;
using KSP.Sim.impl;
using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace KSP.Game.Flow
{
  public class LoadStartingCelestialBodyFlowAction : FlowAction
  {
    private readonly LoadGameData _loadGameData;
    private readonly GameInstance _game;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LoadStartingCelestialBodyFlowAction(LoadGameData data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void DoAction(Action resolve, Action<string> reject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator CoroutineWaitForCelestialBodyLoad(
      CelestialBodyComponent model,
      Action resolve,
      Action<string> reject)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetStartingSoiCelestialBodyName(SerializedSavedGame savedGame) => throw null;
  }
}
