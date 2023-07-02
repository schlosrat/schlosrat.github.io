// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ViewActions.impl.ViewActionWithSimObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.impl;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Sim.ViewActions.impl
{
  public abstract class ViewActionWithSimObject : IViewAction
  {
    public SimulationObjectModel model;
    public ISimulationObjectView simulationView;
    private Func<ISimulationObjectView, bool> isReady;

    public bool IsFinished
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected ViewActionWithSimObject(
      SimulationObjectModel model,
      Func<ISimulationObjectView, bool> isReadyDelegate)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool ResolveDependencies(IModelViewMap modelViewMap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void Begin(IUniverseView universeView) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void Update(double universalTime, double deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void FinalizeDependencies(IModelViewMap modelViewMap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Finish() => throw null;
  }
}
