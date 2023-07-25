// Decompiled with JetBrains decompiler
// Type: KSP.OAB.MultiClickButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace KSP.OAB
{
  public class MultiClickButton : 
    Button,
    IPointerClickHandler,
    IEventSystemHandler,
    IPointerDownHandler,
    IPointerUpHandler
  {
    public Button.ButtonClickedEvent onRightClick;
    public Button.ButtonClickedEvent onMiddleClick;
    public UnityEvent onLeftMouseHold;
    public UnityEvent onRightMouseHold;
    public UnityEvent onMiddleMouseHold;
    public float holdDelay;
    public string OnButtonHoverAudioEvent;
    public string OnButtonPressedAudioEvent;
    private Coroutine curClickCoroutine;
    private bool delayActionTriggered;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnPointerEnter(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnPointerDown(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnPointerUp(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnPointerClick(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator ClickWithDelay(int mouseButtonIndex, float delay) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClearTrackedCoroutine() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PostAKEventsWithPositionalRTPC(string EventToPost) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MultiClickButton() => throw null;
  }
}
