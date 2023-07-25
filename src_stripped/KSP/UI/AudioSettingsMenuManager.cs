// Decompiled with JetBrains decompiler
// Type: KSP.UI.AudioSettingsMenuManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.UI.Binding;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  public class AudioSettingsMenuManager : SettingsSubMenu
  {
    private const string MUTE_AUDIO_SETTINGS_ACTION_KEY = "MuteAudioSettings";
    private const string MASTER_LEVEL_PROPERTY_KEY = "MasterLevel";
    private const string AMBIENCE_LEVEL_PROPERTY_KEY = "AmbienceLevel";
    private const string SFX_LEVEL_PROPERTY_KEY = "SFXLevel";
    private const string VO_LEVEL_PROPERTY_KEY = "VOLevel";
    private const string MUSIC_LEVEL_PROPERTY_KEY = "MusicLevel";
    private const string KERBAL_COMUNICATION_CHATTER_PROPERTY_KEY = "KerbalCommunicationChatter";
    private const string UI_SOUNDS_PROPERTY_KEY = "UISounds";
    private const string AUDIO_LISTENING_MODE_PROPERTY_KEY = "AudioListeningMode";
    private const string TAB_AWAY_AUDIO_PROPERTY_KEY = "TabAwayAudio";
    private const string AUDIO_EVENT_MUTE_ON = "Play_ui_options_mute_button_ON";
    private const string AUDIO_EVENT_MUTE_OFF = "Play_ui_options_mute_button_off";
    private const string IS_KERBAL_IVA_ENABLED = "IsKerbalIVAEnabled";
    [SerializeField]
    private ContextBindRoot _bindRoot;
    private DataContext _dataContext;
    private Property<float> _masterLevel;
    private Property<float> _ambienceLevel;
    private Property<float> _sfxLevel;
    private Property<float> _voLevel;
    private Property<float> _musicLevel;
    private Property<float> _kerbalCommunicationChatter;
    private Property<float> _uiSounds;
    private Property<AudioSettingsMenuManager.AudioListeningModeEnum> _audioListeningMode;
    private Property<bool> _tabAwayAudio;
    private Property<bool> _isKerbalIVAEnabled;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeContextBinding() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Revert() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void MuteAudioSettings(string channelToMute) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyMasterVolume(float selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnMasterLevelChanged(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyAmbienceVolume(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnAmbienceLevelChanged(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplySFXVolume(float selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnSFXLevelChanged(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyVoiceVolume(float selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVoiceLevelChanged(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyMusicVolume(float selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnMusicLevelChanged(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyKerbalCommVolume(float selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnKerbalCommLevelChanged(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyUIVolume(float selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnUILevelChanged(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyAudioListeningMode(
      AudioSettingsMenuManager.AudioListeningModeEnum value)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnListeningModeChanged(
      AudioSettingsMenuManager.AudioListeningModeEnum value)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyTabAwayAudio(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTabAwayAudioChanged(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AudioSettingsMenuManager() => throw null;

    public enum AudioListeningModeEnum
    {
      Normal,
      HomeTheatre,
      NightMode,
      Headphones,
      LaptopSpeakers,
    }
  }
}
