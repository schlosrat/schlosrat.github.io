// Decompiled with JetBrains decompiler
// Type: KSP.UI.ToggleExtendedEventsVisualizer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
