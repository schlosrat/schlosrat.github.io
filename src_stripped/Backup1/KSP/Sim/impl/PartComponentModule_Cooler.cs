// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.PartComponentModule_Cooler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Modules;
using KSP.Sim.ResourceSystem;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class PartComponentModule_Cooler : PartComponentModule
  {
    protected Data_Cooler dataCooler;
    private bool _requestOutstanding;
    private FlowRequestResolutionState _returnedRequestResolutionState;

    public override Type PartBehaviourModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private GameInstance _game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public virtual double EnergyApplied
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public virtual bool CoolerOperational
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnStart(double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnShutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnUpdate(double universalTime, double deltaUniversalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void ResourceConsumptionUpdate(double deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ThermalCooling(double deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartComponentModule_Cooler() => throw null;
  }
}
