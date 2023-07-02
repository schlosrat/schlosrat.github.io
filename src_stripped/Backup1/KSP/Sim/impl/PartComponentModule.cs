// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.PartComponentModule
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Sim.Converters;
using KSP.Sim.Definitions;
using KSP.Sim.ResourceSystem;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public abstract class PartComponentModule
  {
    protected bool _isEnabled;
    public ModuleDataList DataModules;

    [TypeConverterIgnore]
    public abstract Type PartBehaviourModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public PartComponent Part
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void SetPart(PartComponent part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void ClearPart() => throw null;

    [TypeConverterIgnore]
    public bool IsEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    protected ResourceFlowRequestBroker resourceFlowRequestBroker
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void ThermalUpdate(double deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnStart(double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnUpdate(double universalTime, double deltaUniversalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnShutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnFinalizeCreation(double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void RemoveResourceRequest(ResourceFlowRequestHandle handle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected PartComponentModule() => throw null;
  }
}
