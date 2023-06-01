// Decompiled with JetBrains decompiler
// Type: KSP.UI.Flight.UIInfoLabel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace KSP.UI.Flight
{
  public class UIInfoLabel : KerbalMonoBehaviour, IUIInfoLabel
  {
    [SerializeField]
    private Image icon;
    [SerializeField]
    private TextMeshProUGUI text;
    private Image mouseHoverImage;
    private Action onDoubleClick;

    public TextMeshProUGUI Text
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Image Icon
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public RectTransform RectTransform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Setup(Color iconColor, Sprite iconSprite, float iconSize, Action onDoubleClick) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetActive(bool active) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetVisibility(bool show) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnClick(PointerEventData ptrData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIInfoLabel() => throw null;
  }
}
