// Decompiled with JetBrains decompiler
// Type: UnityEngine.UI.InputFieldExtended
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
  public class InputFieldExtended : TMP_InputField, ISelectionStateEventProvider
  {
    public readonly InputFieldExtended.FocusChangeEvent onFocusChanged;
    public SelectionStateEvent onStateTransition;
    [Range(0.0f, 1f)]
    public float alphaHitTestThreshold;
    private UnityEngine.UI.SelectionState lastState;

    public SelectionStateEvent OnStateTransition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public UnityEngine.UI.SelectionState CurrentSelectionState
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void DoStateTransition(Selectable.SelectionState state, bool instant) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnSelect(BaseEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnDeselect(BaseEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnPointerClick(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetText(string inString) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEndEdit(string text) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static UnityEngine.UI.SelectionState ToExtendedSelectionState(
      Selectable.SelectionState state)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public InputFieldExtended() => throw null;

    public class FocusChangeEvent : UnityEvent<bool>
    {
      [MethodImpl(MethodImplOptions.NoInlining)]
      public FocusChangeEvent() => throw null;
    }
  }
}
