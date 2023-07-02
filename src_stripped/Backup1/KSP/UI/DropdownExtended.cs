// Decompiled with JetBrains decompiler
// Type: KSP.UI.DropdownExtended
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
    private UnityEngine.UI.SelectionState _lastState;
    private bool _lastExpandedState;

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
    public override void OnPointerDown(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnPointerEnter(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnPointerExit(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnPointerUp(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static UnityEngine.UI.SelectionState ToExtendedSelectionState(
      Selectable.SelectionState state)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DropdownExtended() => throw null;

    public class DropdownExpandEvent : UnityEvent<bool>
    {
      [MethodImpl(MethodImplOptions.NoInlining)]
      public DropdownExpandEvent() => throw null;
    }
  }
}
