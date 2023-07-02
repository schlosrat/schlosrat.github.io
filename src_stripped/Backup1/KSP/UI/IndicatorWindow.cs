// Decompiled with JetBrains decompiler
// Type: KSP.UI.IndicatorWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI
{
  public class IndicatorWindow : Indicator
  {
    [Header("Components")]
    [SerializeField]
    private KSP2UIWindow _window;
    [SerializeField]
    protected RectTransform _uiPanelRectTransform;
    [SerializeField]
    protected bool _resizeOnlyUIPanel;
    [SerializeField]
    [Space]
    private TextMeshProUGUI _messageBoxTitle;
    [SerializeField]
    private TextMeshProUGUI _messageBoxText;
    [Tooltip("Title Parent, for hiding this when title string is null")]
    [SerializeField]
    private GameObject _headerParent;
    [Tooltip("Body text Parent, for hiding this when body text string is null")]
    [SerializeField]
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
