// Decompiled with JetBrains decompiler
// Type: KSP.UI.ToggleFlyout
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.Messages;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace KSP.UI
{
  [RequireComponent(typeof (ToggleExtended))]
  public class ToggleFlyout : 
    KerbalMonoBehaviour,
    IPointerEnterHandler,
    IEventSystemHandler,
    IPointerExitHandler
  {
    [SerializeField]
    private ToggleExtended _toggle;
    [SerializeField]
    private Canvas _toggleCanvas;
    [SerializeField]
    private GameObject _target;
    [SerializeField]
    [Space]
    private bool _hideOnRightClick;
    [SerializeField]
    private bool _hideOnLeftClick;
    [SerializeField]
    private bool _hideOnMiddleClick;
    private SubscriptionHandle _handleEscapeMenuOpened;
    private bool _mouseOnFlyout;

    public ToggleExtended ToggleExtended
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerEnter(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerExit(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnToggleValueChanged(SelectionState newState, bool instant) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEscapeMenuOpened(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HideFlyOut() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ToggleFlyout() => throw null;
  }
}
