// Decompiled with JetBrains decompiler
// Type: KSP.Game.Flow.SequentialFlow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Startup;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game.Flow
{
  public class SequentialFlow : MonoBehaviour
  {
    private float _flowStartedOn;
    private float _flowStartedOnRealtime;
    private int _flowIndex;
    private readonly List<FlowAction> _flowActions;
    private readonly List<string> _errors;
    private GameInstance _game;

    public virtual string Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float FlowProgress
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public FlowState FlowState
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public string[] Errors
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool HaltOnError
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public event EventHandler FlowFinished
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event EventHandler<float> FlowUpdate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event EventHandler<string> FlowError
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public int FlowActionCount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetGameInstance(GameInstance gameInstance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void StartFlow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void ResetFlow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void NextFlowAction() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void UpdateProgress() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void OnActionResolve(FlowAction sender) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void OnActionReject(FlowAction sender, string error) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FlowAction GetCurrentAction() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddAction(FlowAction action) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearActions() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SequentialFlow() => throw null;
  }
}
