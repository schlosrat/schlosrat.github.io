// Decompiled with JetBrains decompiler
// Type: UnityEngine.UI.Flyout
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Messages;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
  public class Flyout : TMP_Dropdown, ISelectionStateEventProvider
  {
    public bool PublishMessages;
    public SelectedDiscoverableMessage FlyoutOpenedMessage;
    public SelectedDiscoverableMessage FlyoutClosedMessage;
    [Range(0.0f, 1f)]
    public float AlphaHitTestThreshold;
    private GameObject _dropdown;
    private Canvas _buttonCanvas;
    private SelectionState lastState;
    public SelectionStateEvent onStateTransition;
    public UnityEvent<bool> IsOpen;

    public Graphic TargetGraphic
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public SelectionState CurrentSelectionState
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public SelectionStateEvent OnStateTransition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual GameObject CreateDropdownList(GameObject template) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void DestroyDropdownList(GameObject obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void DoStateTransition(Selectable.SelectionState state, bool instant) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private SelectionState ToExtendedSelectionState(Selectable.SelectionState state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnPointerEnter(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnPointerExit(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Flyout() => throw null;
  }
}
