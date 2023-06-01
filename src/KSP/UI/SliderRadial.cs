// Decompiled with JetBrains decompiler
// Type: KSP.UI.SliderRadial
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace KSP.UI
{
  public class SliderRadial : 
    KerbalMonoBehaviour,
    IPointerDownHandler,
    IEventSystemHandler,
    IDragHandler
  {
    public float InitMaxDegrees;
    [SerializeField]
    private Image _backgroundImage;
    [SerializeField]
    private Image _fill;
    private float _fillValue;
    [SerializeField]
    private RectTransform _handle;
    [SerializeField]
    private TextMeshProUGUI _text;
    public readonly SliderRadial.IsPointerDownChangedEvent onIsPointerDownChanged;
    public readonly SliderRadial.DragPositionChangedEvent onDragPositionChanged;
    public readonly SliderRadial.OnValueChangeWithoutPointer onValueDiffWithoutPointer;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDrag(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerDown(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetValue(float ratio) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SliderRadial() => throw null;

    public class IsPointerDownChangedEvent : UnityEvent<bool>
    {
      [MethodImpl(MethodImplOptions.NoInlining)]
      public IsPointerDownChangedEvent() => throw null;
    }

    public class DragPositionChangedEvent : UnityEvent
    {
      [MethodImpl(MethodImplOptions.NoInlining)]
      public DragPositionChangedEvent() => throw null;
    }

    public class OnValueChangeWithoutPointer : UnityEvent<float>
    {
      [MethodImpl(MethodImplOptions.NoInlining)]
      public OnValueChangeWithoutPointer() => throw null;
    }
  }
}
