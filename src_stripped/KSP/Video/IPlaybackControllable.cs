// Decompiled with JetBrains decompiler
// Type: KSP.Video.IPlaybackControllable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
