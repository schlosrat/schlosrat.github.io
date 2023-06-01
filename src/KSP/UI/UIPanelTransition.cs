// Decompiled with JetBrains decompiler
// Type: KSP.UI.UIPanelTransition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace KSP.UI
{
  public class UIPanelTransition : UITransitionBase
  {
    public string startState;
    public bool lockWhileTransitioning;
    public float transitionTime;
    public UIPanelTransition.PanelPosition[] states;
    private Vector2 panelPosition;
    private Coroutine panelCoroutine;
    public UnityEvent onTransitionStart;
    public UnityEvent onTransitionComplete;
    public Action onTransitionCompleteTemporary;
    private int stateIndex;

    public string State
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public int StateIndex
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool Transitioning
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Transition(string stateName, Action onFinished = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Transition(int stIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator TransitionState(
      UIPanelTransition.PanelPosition newPosition,
      Action onFinished = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TransitionStateImmediate(
      UIPanelTransition.PanelPosition newPosition,
      Action onFinished = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private UIPanelTransition.PanelPosition GetState(string stateName, out int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIPanelTransition() => throw null;

    [Serializable]
    public class PanelPosition
    {
      public string name;
      public Vector2 position;
      public bool inputLock;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public PanelPosition() => throw null;
    }
  }
}
