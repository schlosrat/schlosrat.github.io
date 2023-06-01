// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_ReadBool_ImageSingle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace KSP.UI.Binding
{
  public class UIValue_ReadBool_ImageSingle : 
    UIValueBinder<bool>,
    IPointerEnterHandler,
    IEventSystemHandler,
    IPointerExitHandler
  {
    [SerializeField]
    private Image targetImage;
    [SerializeField]
    private float animationDuration;
    [Header("Sprite")]
    [SerializeField]
    private bool updateSprite;
    [SerializeField]
    private Sprite spriteOn;
    [SerializeField]
    private Sprite spriteOff;
    [SerializeField]
    [Header("Color")]
    private bool updateColor;
    [SerializeField]
    private Color colorOn;
    [SerializeField]
    private Color colorOff;
    [Header("Highlight")]
    [SerializeField]
    private bool updateHighlight;
    [SerializeField]
    private Sprite highlightspriteOn;
    [SerializeField]
    private Sprite highlightspriteOff;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerEnter(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerExit(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_ReadBool_ImageSingle() => throw null;
  }
}
