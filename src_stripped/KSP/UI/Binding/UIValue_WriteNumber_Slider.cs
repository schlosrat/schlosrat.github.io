// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_WriteNumber_Slider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI.Binding
{
  [DisallowMultipleComponent]
  public class UIValue_WriteNumber_Slider : UIValueNumberBinder
  {
    [SerializeField]
    [Header("Slider Bar")]
    private SliderExtended slider;
    [SerializeField]
    [Header("Value Setting Behavior")]
    private bool setValueOnDrag;
    [Header("Visible Rounding Behavior")]
    [SerializeField]
    private double snapToNearest;
    [SerializeField]
    private bool snapDuringDrag;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EnforceSlider01Range() => throw null;

    private double SnapToNearest
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Slider_IsPointerDown(bool isDown) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Slider_DragPositionChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Slider_ValueDiffWithoutPointer(float diff01) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnMappedNumberRangeChanged(
      UIValueNumberRange oldRange,
      bool shouldRedraw)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateFromSliderValue(float sliderValue01, bool doSetValue = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool IsFloatClose(float a, float b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_WriteNumber_Slider() => throw null;
  }
}
