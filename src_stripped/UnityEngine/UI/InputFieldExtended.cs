// Decompiled with JetBrains decompiler
// Type: UnityEngine.UI.InputFieldExtended
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
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
    private SelectionState lastState;

    public SelectionStateEvent OnStateTransition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public SelectionState CurrentSelectionState
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void DoStateTransition(Selectable.SelectionState state, bool instant) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnSelect(BaseEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnDeselect(BaseEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnPointerClick(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetText(string inString) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEndEdit(string text) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static SelectionState ToExtendedSelectionState(Selectable.SelectionState state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public InputFieldExtended() => throw null;

    public class FocusChangeEvent : UnityEvent<bool>
    {
      [MethodImpl(MethodImplOptions.NoInlining)]
      public FocusChangeEvent() => throw null;
    }
  }
}
