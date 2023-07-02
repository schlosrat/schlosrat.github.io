// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ViewActions.impl.SingleShotViewAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.impl;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Sim.ViewActions.impl
{
  public class SingleShotViewAction : ViewActionWithSimObject
  {
    private readonly Action<SingleShotViewAction> executionAction;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SingleShotViewAction(
      SimulationObjectModel model,
      Func<ISimulationObjectView, bool> isReady,
      Action<SingleShotViewAction> executionAction)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Begin(IUniverseView universeView) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Update(double universalTime, double deltaTime) => throw null;
  }
}
