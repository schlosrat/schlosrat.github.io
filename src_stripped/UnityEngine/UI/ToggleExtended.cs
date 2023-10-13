// Decompiled with JetBrains decompiler
// Type: UnityEngine.UI.ToggleExtended
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Messages;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
  public class ToggleExtended : Toggle, ISelectionStateEventProvider
  {
    [Tooltip("Any additional graphics to display when this toggle has been switched on")]
    public Graphic[] _additionalGraphicsToToggle;
    public bool PublishMessages;
    public SelectedDiscoverableMessage ToggleEnabledMessageType;
    public SelectedDiscoverableMessage ToggleDisabledMessageType;
    public bool ignoreClicksWhenOn;
    public bool ignoreClicksWhenOff;
    public ToggleExtended.HandledClickTypes ClickTypes;
    public SelectionStateEvent onStateTransition;
    public UnityEvent WhenTogglingOn;
    public UnityEvent WhenTogglingOff;
    public UnityEvent ToggleClicked;
    private UnityEngine.UI.SelectionState lastState;
    [Range(0.0f, 1f)]
    public float alphaHitTestThreshold;
    private Dictionary<Graphic, bool> raycastCache;

    public SelectionStateEvent OnStateTransition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public UnityEngine.UI.SelectionState CurrentSelectionState
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Graphic TargetGraphic
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetNavigationMode(Navigation.Mode navigationMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CallWhenToggling(bool curToggleState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ToggleAdditionalGraphics(bool isOn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DisableRaycasting() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RestoreRaycasting() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void DoStateTransition(Selectable.SelectionState state, bool instant) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static UnityEngine.UI.SelectionState ToExtendedSelectionState(
      Selectable.SelectionState state)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnPointerClick(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ToggleExtended() => throw null;

    public enum HandledClickTypes
    {
      None,
      Left,
      Right,
      Middle,
      Any,
    }
  }
}
