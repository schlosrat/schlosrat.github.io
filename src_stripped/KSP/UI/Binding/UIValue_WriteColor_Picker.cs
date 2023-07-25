// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_WriteColor_Picker
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
  public class UIValue_WriteColor_Picker : UIValueBinder<Color>
  {
    public DragArea2D dragXY;
    public SliderExtended sliderZ;
    public SliderExtended sliderAlpha;
    public UIValue_WriteColor_Picker.ColorModes xColorMode;
    public UIValue_WriteColor_Picker.ColorModes yColorMode;
    public UIValue_WriteColor_Picker.ColorModes zColorMode;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnXYDrag(Vector2 value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnZDrag(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnAlphaDrag(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetColorFromXYZA(float x, float y, float z, float a) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GetXYZAFromColor(out float x, out float y, out float z, out float a) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void MapHSVToValue(
      float h,
      float s,
      float v,
      UIValue_WriteColor_Picker.ColorModes mapMode,
      out float value)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void MapValueToHSV(
      float value,
      UIValue_WriteColor_Picker.ColorModes mapMode,
      ref float h,
      ref float s,
      ref float v)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_WriteColor_Picker() => throw null;

    public enum ColorModes
    {
      Hue,
      Saturation,
      Value,
    }
  }
}
