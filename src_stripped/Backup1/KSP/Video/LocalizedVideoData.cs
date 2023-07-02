// Decompiled with JetBrains decompiler
// Type: KSP.Video.LocalizedVideoData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
    [TextArea(4, 8)]
    [SerializeField]
    private string m_description;
    [SerializeField]
    [Header("Required")]
    private VideoClip m_videoClip;
    [SerializeField]
    private AK.Wwise.Event m_musicAudioEvent;
    [SerializeField]
    [Header("Optional")]
    private AK.Wwise.Event m_sfxAudioEvent;
    [Header("Localization")]
    [SerializeField]
    private List<LocalizedVideoData.LanguageData> _localizationData;
    [Space]
    [SerializeField]
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

    public AK.Wwise.Event MusicAudioEvent
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public AK.Wwise.Event SFXAudioEvent
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
    public AK.Wwise.Event GetVoiceOverForLanguage(string Language) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LocalizedVideoData() => throw null;

    [Serializable]
    public class LanguageData
    {
      public string Language;
      public TextAsset Subtitles;
      public AK.Wwise.Event VoAudioEvent;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public LanguageData() => throw null;
    }
  }
}
