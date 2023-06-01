// Decompiled with JetBrains decompiler
// Type: KSP.UI.ToggleExtendedEventsVisualizer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using DG.Tweening;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI
{
  [RequireComponent(typeof (ToggleExtended))]
  public class ToggleExtendedEventsVisualizer : SelectableExtendedVisualizer
  {
    [NonReorderable]
    public AK.Wwise.Event[] OnToggleEnabledButtonPressedEvents;
    [NonReorderable]
    public AK.Wwise.Event[] OnToggleDisabledButtonPressedEvents;
    [Header("Animations When Toggle is Off")]
    public AnimationTriggers DataOffAnimationTriggers;
    [Header("Animations When Toggle is On")]
    public AnimationTriggers DataOnAnimationTriggers;
    private ToggleExtended toggle;
    private DOTweenAnimation[] tweenAnimations;
    public TransitionVisualToggle[] TransitionVisualsToggle;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleValueChanged(bool isOn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleValueChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleStateChanged(SelectionState newState, bool isOn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleAnimation(string triggerType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void HandleToggle(bool isOn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void HandleStateTransition(
      SelectionState currentSelectionState,
      bool instant)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool HasOnClickAudioEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ToggleExtendedEventsVisualizer() => throw null;
  }
}
