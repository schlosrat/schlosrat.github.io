// Decompiled with JetBrains decompiler
// Type: KSP.UI.GameplaySettingsMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI
{
  public class GameplaySettingsMenu : SettingsSubMenu, IMenu, IDisposable
  {
    [SerializeField]
    private TMP_Dropdown languageDropDown;
    [SerializeField]
    private Slider uiScaleSlider;
    public string LanguageLocaliztionPrefix;
    private List<string> _availableLanguages;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupCVar() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Revert() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RevertUIChanges() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeLanguageDropdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnLanguageSelectionChanged(int value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnUIScaleFactorChanged(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDefaultThrottleInPrelaunchChanged(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyLanguageSelection(CVar selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyUIScaleFactor(CVar selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void IsActive(bool isActive) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameplaySettingsMenu() => throw null;
  }
}
