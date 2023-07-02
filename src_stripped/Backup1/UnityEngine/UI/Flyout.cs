// Decompiled with JetBrains decompiler
// Type: UnityEngine.UI.Flyout
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
    private UnityEngine.UI.SelectionState lastState;
    public SelectionStateEvent onStateTransition;
    public UnityEvent<bool> IsOpen;

    public Graphic TargetGraphic
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public UnityEngine.UI.SelectionState CurrentSelectionState
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public SelectionStateEvent OnStateTransition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override GameObject CreateDropdownList(GameObject template) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void DestroyDropdownList(GameObject obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void DoStateTransition(Selectable.SelectionState state, bool instant) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private UnityEngine.UI.SelectionState ToExtendedSelectionState(Selectable.SelectionState state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnPointerEnter(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnPointerExit(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Flyout() => throw null;
  }
}
