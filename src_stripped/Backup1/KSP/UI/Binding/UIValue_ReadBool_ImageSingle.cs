// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_ReadBool_ImageSingle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
    [SerializeField]
    [Header("Sprite")]
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
