// Decompiled with JetBrains decompiler
// Type: KSP.Game.AgencyColorPicker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.UI.Binding;
using KSP.UI.Binding.Core;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.Game
{
  public class AgencyColorPicker : KerbalMonoBehaviour
  {
    private const float MIN_HS_VALUE_CORRECTION = 0.001f;
    private const float MIN_HS_VALUE_CHECK = 0.0001f;
    private const float MAX_HS_VALUE_CORRECTION = 0.9999f;
    private const float MAX_HS_VALUE_CHECK = 0.98f;
    private const float HUE_EPSILON = 1E-05f;
    private const int MIN_WIDTH = 1;
    [SerializeField]
    private ContextBindRoot _bindRoot;
    [Space]
    [SerializeField]
    private AgencyColorPicker.ColorSettings _baseColor;
    [SerializeField]
    private AgencyColorPicker.ColorSettings _accentColor;
    [Header("Color Picker")]
    [SerializeField]
    private int _textureSize;
    [SerializeField]
    private ObjectAssemblyUIDragArea2D _colorPickerArea;
    [SerializeField]
    private SliderExtended _sliderHue;
    [SerializeField]
    private string _baseColorKey;
    [SerializeField]
    private string _accentColorKey;
    [SerializeField]
    private string _selectedBaseColorKey;
    [SerializeField]
    private string _selectedAccentColorKey;
    [SerializeField]
    private string _setAsNewAgencyColorsKey;
    [SerializeField]
    [Space(5f)]
    [Header("UI Buttons Highlight")]
    private Image _baseColorHighlight;
    [SerializeField]
    private Image _accentColorHighlight;
    [SerializeField]
    [Space(5f)]
    [Header("UI Binding")]
    private UIValueBinder _baseColorPickerPreview;
    [SerializeField]
    private UIValueBinder _accentColorPickerPreview;
    [SerializeField]
    [Header("Images")]
    private RawImage _colorPickerImage;
    [SerializeField]
    [Header("Agency Flag Manager")]
    private AgencyFlagManager _agencyFlagManager;
    private AgencyColorPicker.ColorModes _xColorMode;
    private AgencyColorPicker.ColorModes _yColorMode;
    private AgencyColorPicker.ColorModes _zColorMode;
    private Texture2D _colorPickerTexture;
    private Texture2D _colorAlphaSliderTexture;
    private AgencyColorPicker.ColorEditMode _colorEditMode;
    private bool _isEnabledOnce;
    private Property<Color> _selectedBaseColor;
    private Property<Color> _selectedAccentColor;
    private Dictionary<Color, Color[]> _textureCache;
    private Dictionary<Color, Color[]> _alphaSliderTextureCache;
    private DataContext _dataContext;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InitializeContext(DataContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddEventListeners() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetPickerColors() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SelectedBaseColorValue_OnChangedValue(Color newColor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SelectedAccentColorValue_OnChangedValue(Color newColor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetAsNewAgencyColors() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BaseColorSelected() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AccentColorSelected() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetSelectedColor(Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Color GetSelectedColor() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BaseColorDefaultSelected() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AccentColorDefaultSelected() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DrawColorTexture(Color selectedColor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnXYDrag(Vector2 value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnHueDrag(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetColorFromXYZA(float x, float y, float z, float a) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GetXYZAFromColor(out float x, out float y, out float z, out float a) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void MapHSVToValue(
      float h,
      float s,
      float v,
      AgencyColorPicker.ColorModes mapMode,
      out float value)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void MapValueToHSV(
      float value,
      AgencyColorPicker.ColorModes mapMode,
      ref float h,
      ref float s,
      ref float v)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static float CorrectValue(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float CheckHueValue(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateColorHighlightToggle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BaseColorHighlightToggle(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AccentColorHighlightToggle(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AgencyColorPicker() => throw null;

    public enum ColorModes : byte
    {
      None,
      Hue,
      Saturation,
      Value,
    }

    private enum ColorEditMode : byte
    {
      None,
      Base,
      Accent,
    }

    public struct HSVColor : IEquatable<AgencyColorPicker.HSVColor>
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
      public bool Equals(AgencyColorPicker.HSVColor other) => throw null;
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
