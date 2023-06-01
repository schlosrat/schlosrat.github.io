// Decompiled with JetBrains decompiler
// Type: KSP.Video.IPlaybackControllable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using UnityEngine.Events;

namespace KSP.Video
{
  public interface IPlaybackControllable
  {
    PlaybackControlEvent PlaybackStateChanged { get; }

    UnityEvent PlaybackFinished { get; }

    PlaybackState PlaybackState { get; }

    float GetTimeSeconds();

    float GetTimePercent();

    float GetDurationSeconds();

    PlaybackControlResult SetTimeSeconds(float timeSeconds);

    PlaybackControlResult SetTimeSecondsRelative(float deltaSeconds);

    PlaybackControlResult Play();

    PlaybackControlResult Pause();

    void Stop();

    void Close();
  }
}
