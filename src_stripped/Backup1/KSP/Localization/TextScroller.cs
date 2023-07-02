// Decompiled with JetBrains decompiler
// Type: KSP.Localization.TextScroller
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace KSP.Localization
{
  public class TextScroller : KerbalMonoBehaviour
  {
    public TextMeshProUGUI TextField;
    public RectTransform ProxyObjectTransform;
    [Header("Speed in pixels per second")]
    public float ScrollSpeed;
    [Header("Delay before scrolling begins in decimal seconds")]
    public float ScrollDelay;
    [Header("Delay before reset in decimal seconds")]
    public float ResetDelay;
    public bool ResetScroll;
    public bool AlwaysScroll;
    private TextMeshProUGUI _cloneTextFieldRight;
    private TextMeshProUGUI _cloneTextFieldLeft;
    private float _scrollPosition;
    private float _scrollDirection;
    private float _cachedX;
    private float _lastX;
    private bool _hover;
    private float _hoverWaitTime;
    private float _resetWaitTime;
    private bool _scrollingEnabled;
    private PointerEventData _pointerData;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateScrollingText(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateMouseHover() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateCachedXPosition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnLocalizeEvent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResetScrolling() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateCloneScrollWrap() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private TextMeshProUGUI CloneTextField(TextMeshProUGUI textField) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTextChanged(Object obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateHoverDelay(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsHoverDelayOver() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResetHoverDelay() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateResetDelay(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsResetDelayOver() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResetResetDelay() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TextScroller() => throw null;
  }
}
