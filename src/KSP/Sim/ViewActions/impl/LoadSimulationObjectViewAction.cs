// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ViewActions.impl.LoadSimulationObjectViewAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Messages;
using KSP.Sim.impl;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.ViewActions.impl
{
  public class LoadSimulationObjectViewAction : IViewAction
  {
    private SimulationObjectModel _simObject;
    private SimulationObjectView _viewObject;
    private MessageCenter GameMessageCenter;
    private bool _forcePositionRotation;
    private Vector3 _worldPosition;
    private Quaternion _worldRotation;

    public bool IsFinished
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LoadSimulationObjectViewAction(SimulationObjectModel simObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LoadSimulationObjectViewAction(
      SimulationObjectModel simObject,
      Vector3 worldPosition,
      Quaternion worldRotation)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetDebugNameString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ResolveDependencies(IModelViewMap modelViewMap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Begin(IUniverseView universeView) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnViewObjectInstantiateFinished(SimulationObjectView viewObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Update(double universalTime, double deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void FinalizeDependencies(IModelViewMap modelViewMap) => throw null;
  }
}
