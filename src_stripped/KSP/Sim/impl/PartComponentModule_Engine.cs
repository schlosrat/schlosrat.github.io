// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.PartComponentModule_Engine
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Modules;
using KSP.Sim.ResourceSystem;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class PartComponentModule_Engine : PartComponentModule
  {
    protected Data_Engine dataEngine;
    private bool _messageOutOfFuelFired;
    private List<ContainedResourceData> _containedResourceData;

    public override Type PartBehaviourModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool EngineIgnited
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float CurrentThrottle
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsInitialized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Data_Engine.EngineMode currentEngineModeData
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public PropellantState CurrentPropellantState
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float normalizedOutput
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsStaged() => throw null;

    public bool IsPropellantStarved
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float RequestedThrottle
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnStart(double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnUpdate(double universalTime, double deltaUniversalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnShutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void CalculatePropellantReqs() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected float CalculateThrust() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected bool GetInfinitePropellant() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void SetConsumptionRate(PropellantState p, double rate) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void ResetRate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual bool CheckDeprived() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double RequestPropellant(double mass) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected double RequiredPropellantMass(float throttleAmount, out float resultingThrust) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected float GetThrottlingMult(float atm, float throttle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Flameout(string message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Shutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void UnFlameout(bool showFX = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateStatus() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float ModifyFlow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<ContainedResourceData> GetContainedResourceData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartComponentModule_Engine() => throw null;
  }
}
