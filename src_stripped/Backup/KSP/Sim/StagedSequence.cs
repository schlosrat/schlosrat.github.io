// Decompiled with JetBrains decompiler
// Type: KSP.Sim.StagedSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  public abstract class StagedSequence : IEventEmitter
  {
    protected Dictionary<Enum, HashSet<EngagedContract>> actions;
    protected double accumulatedTime;

    public abstract string Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public abstract Enum Events
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public StagedSequence.SequenceState State
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Stop() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public EngagedContract Subscribe(Enum eventType, Action<Enum> callback) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Unsubscribe(EngagedContract contract) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void Emit(Enum eventType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Update(double deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected StagedSequence() => throw null;

    public enum SequenceState
    {
      Primed,
      Running,
      Complete,
    }
  }
}
