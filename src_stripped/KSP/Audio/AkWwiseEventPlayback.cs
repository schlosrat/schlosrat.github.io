// Decompiled with JetBrains decompiler
// Type: KSP.Audio.AkWwiseEventPlayback
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using AK.Wwise;
using KSP.Logging;
using KSP.Video;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace KSP.Audio
{
  public class AkWwiseEventPlayback : MonoBehaviour, IPlaybackControllable
  {
    private const LogFilter LOGTAG = (LogFilter) 8;
    private const string PREFIX = "[VideoPlayer][AkWwiseEventPlayback] ";
    private const float FRAME_TIME_60_HZ = 0.0166666675f;
    [Header("If set, will play this audio on Start")]
    [SerializeField]
    private Event _initialAudioData;
    private float _cachedDurationSeconds;
    private float _cachedFrameTimePercent;
    private float _storedTimeSeconds;
    private bool _isStopQueued;
    private int _ticksUntilReload;
    private bool _isPauseQueued;
    private float _lastTimeSeconds;
    private const uint EVENT_CALLBACK_FLAG = 540016649;

    public Event audioData
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public uint playingId
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PlaybackControlEvent PlaybackStateChanged
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public UnityEvent PlaybackFinished
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public KSP.Video.PlaybackState PlaybackState
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAudioData(Event audioData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public void ClearAudioData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public float GetTimeSeconds() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public float GetTimePercent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public float GetDurationSeconds() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private PlaybackControlResult InternalSetTimePercent(float timePercent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public PlaybackControlResult SetTimeSeconds(float timeSeconds) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public PlaybackControlResult SetTimeSecondsRelative(float deltaSeconds) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PlaybackControlResult Play() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PlaybackControlResult Pause() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Stop() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Close() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AudioCallbackHandler(object in_cookie, AkCallbackType in_type, AkCallbackInfo info) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public bool IsAudioDataValid() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    private bool IsControlReady() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    private void VerifyAkResult(AKRESULT result) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    private void InternalSetPlaybackState(KSP.Video.PlaybackState state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    private void InternalInvokePlaybackStateChanged(bool printDebug = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    private PlaybackControlResult InternalExecuteEventAction(
      AkActionOnEventType type,
      KSP.Video.PlaybackState targetState)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    private PlaybackControlResult InternalGetResultAfterSeek(
      float targetTimePercent,
      AKRESULT akResult)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AkWwiseEventPlayback() => throw null;

    private class PlayingIDCookie
    {
      public uint playingID;
      public Event eventSound;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public PlayingIDCookie() => throw null;
    }
  }
}
