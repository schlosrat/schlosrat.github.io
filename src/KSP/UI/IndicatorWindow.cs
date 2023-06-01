// Decompiled with JetBrains decompiler
// Type: KSP.UI.IndicatorWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI
{
  public class IndicatorWindow : Indicator
  {
    [SerializeField]
    [Header("Components")]
    private KSP2UIWindow _window;
    [SerializeField]
    protected RectTransform _uiPanelRectTransform;
    [SerializeField]
    protected bool _resizeOnlyUIPanel;
    [Space]
    [SerializeField]
    private TextMeshProUGUI _messageBoxTitle;
    [SerializeField]
    private TextMeshProUGUI _messageBoxText;
    [SerializeField]
    [Tooltip("Title Parent, for hiding this when title string is null")]
    private GameObject _headerParent;
    [SerializeField]
    [Tooltip("Body text Parent, for hiding this when body text string is null")]
    private GameObject _bodyParent;
    [SerializeField]
    [Space]
    private Image _image;
    [SerializeField]
    private RawImage _rawImage;
    private string translationCache;
    private bool isOffScreen;

    public bool IsOffScreen
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Hide() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Show(IndicatorData indicatorData, Action<Indicator> onHide) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void UpdateLoopDOTween() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool IsVisibleFrom(RectTransform parentRectTransform, Camera UICamera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IndicatorWindow() => throw null;
  }
}
