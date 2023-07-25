// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_WriteVector2_MinMaxSliders
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api;
using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI.Binding
{
  [DisallowMultipleComponent]
  public class UIValue_WriteVector2_MinMaxSliders : 
    UIValueBinder<Vector2>,
    IUIValueNumberBindable,
    IUIValueBindable
  {
    [SerializeField]
    [Header("Slider Bars")]
    private SliderExtended _sliderMin;
    [SerializeField]
    private SliderExtended _sliderMax;
    [SerializeField]
    private SliderExtended _sliderFill;
    [Header("Value Setting Behaviour")]
    [SerializeField]
    private bool _setValueOnDrag;
    private bool _hasSlidersDefined;
    private bool _hasSlidersEventsRegistered;
    private double _valueMappedMin;
    private double _valueMappedMax;
    private float _numberRangeNormalizer;
    private RectTransform _fillRect;

    public UIValueNumberRange NumberRange
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    private float _curValueMin01
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private float _curValueMax01
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private bool IsAnySliderPointerDown
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ConnectSliderEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EnforceSlider01Ranges() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EnforceSlider01Range(SliderExtended slider) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SliderMin_IsPointerDown(bool isDown) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SliderMax_IsPointerDown(bool isDown) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Slider_IsPointerDown(
      SliderExtended slider,
      UIValue_WriteVector2_MinMaxSliders.PossibleSliders sliderInUse,
      bool isDown)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SliderMin_DragPositionChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SliderMax_DragPositionChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SliderFill_DragPositionChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SliderMin_ValueDiffWithoutPointer(float diff01) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SliderMax_ValueDiffWithoutPointer(float diff01) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResizeFill() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateFromSliderValue(
      SliderExtended slider,
      UIValue_WriteVector2_MinMaxSliders.PossibleSliders sliderInUse,
      bool doSetValue = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void BindValue(IProperty valueNumberProperty, double min, double max) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void UpdateMetadataFromContext() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void SetMappedValueRange(double min, double max, bool shouldRedraw = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void OnMappedNumberRangeChanged(UIValueNumberRange oldRange, bool shouldRedraw) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_WriteVector2_MinMaxSliders() => throw null;

    private enum PossibleSliders
    {
      Min,
      Max,
      Fill,
    }
  }
}
