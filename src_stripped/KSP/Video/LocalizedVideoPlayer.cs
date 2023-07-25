// Decompiled with JetBrains decompiler
// Type: KSP.Video.LocalizedVideoPlayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Audio;
using KSP.Logging;
using KSP.Messages;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.Video;

namespace KSP.Video
{
  public class LocalizedVideoPlayer : MonoBehaviour, IPlaybackControllable
  {
    private const float FRAME_TIME_60_HZ = 0.0166666675f;
    private const LogFilter LOGTAG = (LogFilter) 256;
    private const string PREFIX = "[VideoPlayer][LocalizedVideoPlayer] ";
    private static readonly Color ENABLED_SCREEN_COLOR;
    private static readonly Color DISABLED_SCREEN_COLOR;
    private static readonly Color LOADING_SCREEN_COLOR;
    [Tooltip("Small size for the caption fonts, fetched from Accessibility settings value")]
    public float captionsSmallSize;
    [Tooltip("Medium size for the caption fonts, fetched from Accessibility settings value")]
    public float captionsMediumSize;
    [Tooltip("Large size for the caption fonts, fetched from Accessibility settings value")]
    public float captionsLargeSize;
    [Space]
    public bool autoCloseWhenFinished;
    [Space]
    public CanvasGroup playbackUIControlsGroup;
    [Space]
    private VideoPlayer _videoPlayer;
    public RawImage videoPlayerUIScreen;
    private RenderTexture _videoPlayerTexture;
    private bool _haveVideoTexture;
    public float MaxAudioVideoDesync;
    [Space]
    public AkWwiseEventPlayback musicAudioPlayer;
    public AkWwiseEventPlayback voAudioPlayer;
    public AkWwiseEventPlayback sfxAudioPlayer;
    [Space]
    public TextMeshProUGUI SubtitleTextMesh;
    private SRTParser _SRTParser;
    private int _cachedSubtitleIndex;
    private LocalizedVideoData _videoData;
    private float _lastTimeSeconds;
    private bool _videoPrepareIsQueued;
    private PlaybackState _lastPlaybackState;
    [SerializeField]
    [Space]
    private PlaybackControlEvent _playbackStateChanged;
    [Space]
    [SerializeField]
    private UnityEvent _playbackFinished;
    private PlaybackState _videoPlaybackState;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Close() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Open(LocalizedVideoData data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnLocalize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CloseInternal(bool fireEvent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OpenInternal(LocalizedVideoData videoData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void VideoPlayerOnPrepareCompleted(VideoPlayer source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleVideoPlayerEnd(VideoPlayer source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleVideoPlayerError(VideoPlayer source, string error) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AudioPlaybackStateChangePassthrough(PlaybackStateData stateData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandlePlaybackStateChanged(PlaybackStateData stateData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SyncAudioAndVideo(PlaybackStateData stateData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateRenderTextureLifetime() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    private bool IsVideoControlReady() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    private void GetOrAddComponent<T>(ref T target) where T : Component => throw null;

    public PlaybackControlEvent PlaybackStateChanged
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public UnityEvent PlaybackFinished
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public PlaybackState PlaybackState
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public float GetTimeSeconds() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public float GetTimePercent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public float GetDurationSeconds() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PlaybackControlResult SetTimeSeconds(float timeSeconds) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public PlaybackControlResult SetTimeSecondsRelative(float deltaSeconds) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PlaybackControlResult Play() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PlaybackControlResult Pause() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Stop() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    private void InternalSetVideoPlaybackState(PlaybackState state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    private void InternalInvokeVideoPlaybackStateChanged(bool printDebug = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateSubtitles(float Time) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetSubtitle(SubtitleBlock sBlock) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LoadSubtitles(TextAsset SubtitleData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnSubtitleSizeChanged(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateSubtitleSize(SubTitleTextSizeMode newSize) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LoadSubtitleSize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LocalizedVideoPlayer() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static LocalizedVideoPlayer() => throw null;
  }
}
