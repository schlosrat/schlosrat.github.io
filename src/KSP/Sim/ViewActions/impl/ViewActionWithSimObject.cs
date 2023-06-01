// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ViewActions.impl.ViewActionWithSimObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
