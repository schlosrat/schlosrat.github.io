// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ObjectAssemblyColorPicker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Api.CoreTypes;
using KSP.UI.Binding;
using KSP.UI.Binding.Core;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.OAB
{
  public class ObjectAssemblyColorPicker : PopUpUIManagerBase
  {
    private const float HUE_EPSILON = 1E-05f;
    private const int MIN_WIDTH = 1;
    public ContextBindRoot BindRoot;
    public ObjectAssemblyColorPicker.ColorSettings BaseColor;
    public ObjectAssemblyColorPicker.ColorSettings AccentColor;
    [Header("Color Picker")]
    public int textureSize;
    public ObjectAssemblyUIDragArea2D ColorPickerArea;
    public SliderExtended SliderHue;
    public SliderExtended SliderAlpha;
    [Header("UI Buttons")]
    [Space(5f)]
    public ButtonExtended CancelButton;
    public ButtonExtended SetAsDefaultButton;
    public ButtonExtended RestoreFromDefaultButton;
    public Toggle ApplyModeToggleAssembly;
    [Header("UI Buttons Highlight")]
    [Space(5f)]
    public Image BaseColorHighlight;
    public Image AccentColorHighlight;
    [Header("UI Binding")]
    [Space(5f)]
    public UIValueBinder BaseColorPickerPreview;
    public UIValueBinder AccentColorPickerPreview;
    public UIValueBinder BaseDefaultColorPickerPreview;
    public UIValueBinder AccentDefaultColorPickerPreview;
    public string BaseColorValueKey;
    public string AccentColorValueKey;
    public string BaseColorDefaultValueKey;
    public string AccentColorDefaultValueKey;
    [Header("Images")]
    public RawImage ColorPickerImage;
    public RawImage ColorAlphaSliderImage;
    private Texture2D _colorPickerTexture;
    private Texture2D _colorAlphaSliderTexture;
    private ObjectAssemblyColorPicker.ColorEditMode _colorEditMode;
    private ObjectAssemblyColorPicker.ColorApplyMode _colorApplyMode;
    private ObjectAssemblyColorPicker.ColorModes _xColorMode;
    private ObjectAssemblyColorPicker.ColorModes _yColorMode;
    private ObjectAssemblyColorPicker.ColorModes _zColorMode;
    private Dictionary<Color, Color[]> _textureCache;
    private Dictionary<Color, Color[]> _alphaSliderTextureCache;
    private PropertyExternal<Color> _baseColorValue;
    private PropertyExternal<Color> _accentColorValue;
    private PropertyExternal<Color> _baseDefaultColorValue;
    private PropertyExternal<Color> _accentDefaultColorValue;
    private OABSessionInformation _stats;
    private ObjectAssemblyBuilderEvents _eventsBuilder;
    private ObjectAssemblyUIEvents _eventsUI;

    public DataContext Context
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(
      OABSessionInformation stats,
      ObjectAssemblyBuilderEvents eventsBuilder,
      ObjectAssemblyUIEvents eventsUI)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AccentColorValue_OnChangedValue(Color obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BaseColorValue_OnChangedValue(Color obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetCallbacks() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemoveCallbacks() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BaseColorSelected() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AccentColorSelected() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetSelectedColor(Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Color GetSelectedColor() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnRestoreFromDefault() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RedrawColorPickers() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnSetAsDefault() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCancelButton() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void SetVisibilityOfManager(bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnApplyModeAssemblyToggle(bool toggle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnApplyColorToPart(
      IObjectAssemblyPart part,
      IReadOnlyList<IObjectAssemblyPart> parts)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DrawColorTexture(Color selectedColor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnXYDrag(Vector2 value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnHueDrag(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnAlphaDrag(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RedrawValue(bool instant = true, bool callback = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetColorFromXYZA(float x, float y, float z, float a) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GetXYZAFromColor(out float x, out float y, out float z, out float a) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void MapHSVToValue(
      float h,
      float s,
      float v,
      ObjectAssemblyColorPicker.ColorModes mapMode,
      out float value)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void MapValueToHSV(
      float value,
      ObjectAssemblyColorPicker.ColorModes mapMode,
      ref float h,
      ref float s,
      ref float v)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static float ClampedColorValueTranslator(float input, bool doClamp) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float CheckHueValue(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateColorHighlightToggle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void BaseColorHighlightToggle(bool on) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AccentColorHighlightToggle(bool on) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsAssemblyApplyMode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectAssemblyColorPicker() => throw null;

    public struct HSVColor : IEquatable<ObjectAssemblyColorPicker.HSVColor>
    {
      public float hue;
      public float saturation;
      public float value;
      public float alpha;
      private const float COLOR_TOLERANCE = 0.001f;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public HSVColor(float hue, float saturation, float value, float alpha) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public HSVColor(Color color) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Color HSVToRGB() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public bool Equals(ObjectAssemblyColorPicker.HSVColor other) => throw null;
    }

    public enum ColorModes
    {
      Hue,
      Saturation,
      Value,
    }

    private enum ColorEditMode
    {
      Base,
      Accent,
    }

    private enum ColorApplyMode
    {
      Part,
      All,
    }

    [Serializable]
    public struct ColorSettings
    {
      public Color color;
      public bool noColor;
      public Button colorPreviewButton;
      public Button colorPreviewDefaultButton;
    }
  }
}
