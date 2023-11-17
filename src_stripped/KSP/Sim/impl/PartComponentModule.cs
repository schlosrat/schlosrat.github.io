// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.PartComponentModule
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
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

    /// <summary>
    /// This triggers when the Flight scene is first loaded. When loading a game it triggers for in-flight vessels also.
    /// </summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnStart(double universalTime) => throw null;

    /// <summary>
    /// This starts triggering when vessel is first placed in Flight. Does not trigger while still in OAB.
    /// Keeps triggering in every scene once it's in Flight.
    /// OnUpdate is called every frame.
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnUpdate(double universalTime, double deltaUniversalTime) => throw null;

    /// <summary>
    /// This triggers when the part is destroyed, when leaving the Flight scene, when exiting the game.
    /// It... also triggers when Flight scene is loaded? (why? maybe it's triggered when leaving the OAB scene)
    /// </summary>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnShutdown() => throw null;

    /// <summary>
    /// It appears this doesn't trigger at all?
    /// </summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnFinalizeCreation(double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void RemoveResourceRequest(ResourceFlowRequestHandle handle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected PartComponentModule() => throw null;
  }
}
