// Decompiled with JetBrains decompiler
// Type: KSP.UI.Flight.UIInfoLabel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
