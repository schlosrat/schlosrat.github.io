// Decompiled with JetBrains decompiler
// Type: KSP.UI.AudioSettingsMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI
{
  public class AudioSettingsMenu : SettingsSubMenu, IMenu, IDisposable
  {
    public const float AUDIO_VOLUME_MAX = 100f;
    [SerializeField]
    private SliderExtended masterVolumeSlider;
    [SerializeField]
    private SliderExtended musicVolumeSlider;
    [SerializeField]
    private SliderExtended sfxVolumeSlider;
    [SerializeField]
    private SliderExtended voVolumeSlider;
    [SerializeField]
    private SliderExtended kerbalCommunicationVolumeSlider;
    [SerializeField]
    private SliderExtended ambienceVolumeSlider;
    [SerializeField]
    private SliderExtended uiSoundsVolumeSlider;

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
    private void OnMasterVolumeChanged(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnMusicVolumeChanged(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnSFXVolumeChanged(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVOVolumeChanged(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnKerbalComVolumeChanged(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnAmbienceVolumeChanged(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnUIVolumeChanged(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyMasterVolume(CVar selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyMusicVolume(CVar selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplySFXVolume(CVar selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyVOVolume(CVar selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyKerbalCommVolume(CVar selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyAmbienceVolume(CVar selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyUIVolume(CVar selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void IsActive(bool isActive) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AudioSettingsMenu() => throw null;
  }
}
