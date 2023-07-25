// Decompiled with JetBrains decompiler
// Type: KSP.UI.DropdownExtended
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace KSP.UI
{
  public class DropdownExtended : TMP_Dropdown
  {
    private SelectionStateEvent _onStateTransition;
    public readonly DropdownExtended.DropdownExpandEvent OnExpandEvent;
    private SelectionState _lastState;
    private bool _lastExpandedState;

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
    public virtual void OnPointerDown(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnPointerEnter(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnPointerExit(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnPointerUp(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static SelectionState ToExtendedSelectionState(Selectable.SelectionState state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DropdownExtended() => throw null;

    public class DropdownExpandEvent : UnityEvent<bool>
    {
      [MethodImpl(MethodImplOptions.NoInlining)]
      public DropdownExpandEvent() => throw null;
    }
  }
}
