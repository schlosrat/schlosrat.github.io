// Decompiled with JetBrains decompiler
// Type: KSP.Video.LocalizedVideoData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using AK.Wwise;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Video;

namespace KSP.Video
{
  [CreateAssetMenu(fileName = "LocalizedVideo", menuName = "Video/LocalizedVideo", order = 100)]
  [Serializable]
  public class LocalizedVideoData : ScriptableObject
  {
    [SerializeField]
    private string m_title;
    [SerializeField]
    [TextArea(4, 8)]
    private string m_description;
    [SerializeField]
    [Header("Required")]
    private VideoClip m_videoClip;
    [SerializeField]
    private Event m_musicAudioEvent;
    [SerializeField]
    [Header("Optional")]
    private Event m_sfxAudioEvent;
    [Header("Localization")]
    [SerializeField]
    private List<LocalizedVideoData.LanguageData> _localizationData;
    [SerializeField]
    [Space]
    private Sprite m_preview;

    public string Title
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string Description
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public VideoClip VideoClip
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Event MusicAudioEvent
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Event SFXAudioEvent
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public List<LocalizedVideoData.LanguageData> LocalizationData
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Sprite Preview
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TextAsset GetSubtitleForLanguage(string Language) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Event GetVoiceOverForLanguage(string Language) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LocalizedVideoData() => throw null;

    [Serializable]
    public class LanguageData
    {
      public string Language;
      public TextAsset Subtitles;
      public Event VoAudioEvent;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public LanguageData() => throw null;
    }
  }
}
