// Decompiled with JetBrains decompiler
// Type: KSP.UI.InGameSettingsMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using KSP.UserInterface;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI
{
  [PrefabName("InGameSettingsMenu.prefab")]
  public class InGameSettingsMenu : UIModule
  {
    public ApplySettings applySettings;
    [SerializeField]
    private Button applyButton;
    [SerializeField]
    private Button revertButton;
    [SerializeField]
    private Button backButton;
    private SettingsProperties settingsProperties;
    [SerializeField]
    private Slider masterVolumeSlider;
    [SerializeField]
    private Slider musicVolumeSlider;
    [SerializeField]
    private Slider sfxVolumeSlider;
    [SerializeField]
    private Slider voVolumeSlider;
    [SerializeField]
    private Slider kerbalCommunicationVolumeSlider;
    [SerializeField]
    private Slider ambienceVolumeSlider;
    [SerializeField]
    private Slider uiSoundsVolumeSlider;
    [SerializeField]
    private TMP_Dropdown resolutionDropDown;
    [SerializeField]
    private Toggle vsyncToggle;
    [SerializeField]
    private Toggle fullscreenToggle;
    [SerializeField]
    private TMP_Dropdown antiAliasingDropDown;
    [SerializeField]
    private TMP_Dropdown textureQualityDropDown;
    [SerializeField]
    private TMP_Dropdown conicPatchDrawModeDropDown;
    [SerializeField]
    private Toggle anisotropicFilteringToggle;
    [SerializeField]
    private Slider conicPatchLimitSlider;
    [SerializeField]
    private Slider partHighlighterBrightnessFactorSlider;
    [SerializeField]
    private Toggle partHighlighterEnabledInFlightToggle;
    [SerializeField]
    private TMP_Dropdown languageDropDown;
    [SerializeField]
    private Toggle thermalHighlightsToggle;
    [SerializeField]
    private Toggle temperatureGaugesToggle;
    [SerializeField]
    private Toggle evasAutoRotateToCameraToggle;
    [SerializeField]
    private Slider uiScaleSlider;
    [SerializeField]
    private Slider defaultThrottleInPrelaunchSlider;
    private string _languageLocalizationPrefix;
    private List<string> _availableLanguages;
    [SerializeField]
    private Toggle enableAutoSavesToggle;
    [SerializeField]
    private Slider maxAutosavesSlider;
    [SerializeField]
    private Slider autosaveTimeInMinutesSlider;
    [SerializeField]
    private GameObject resolutionDropDownHader;
    [SerializeField]
    private GameObject antiAliasingDropDownHader;
    [SerializeField]
    private GameObject textureQualityDropDownHader;
    [SerializeField]
    private GameObject conicPatchDrawModeDropDownHader;
    [SerializeField]
    private GameObject conicPatchLimitSliderHader;
    private bool alreadyCreated;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Pooled() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Created() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddUIListeners() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupUIValues() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HideUIElements() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LanguageSelectionChanged(int selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResolutionSelectionChanged(int selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AntiAliasingSelectionChanged(int selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AnisotropicSelectionChanged(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TextureQualitySelectionChanged(int selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ConicPatchDrawModeSelectionChanged(int selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Back() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnBack() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Apply() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Revert() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public InGameSettingsMenu() => throw null;
  }
}
