// Decompiled with JetBrains decompiler
// Type: KSP.Video.LocalizedVideoPlayerUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Logging;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.Video
{
  [RequireComponent(typeof (CanvasGroup))]
  public class LocalizedVideoPlayerUI : PlaybackController
  {
    private const LogFilter LOGTAG = LogFilter.UI;
    private const string PREFIX = "[LocalizedVideoPlayerUI] ";
    [Header("UI Controls should be a child of this so they can be hidden/made inactive together.")]
    public CanvasGroup controlsUIGroup;
    [Header("Optional - If set, this group will be shown when playback is finished")]
    public CanvasGroup endScreenUIGroup;
    private bool _haveEndScreenUIGroup;
    [Header("on/off controls", order = 3)]
    [Space(order = 2)]
    [Header("UI Controls - none are required. Set only what you need", order = 1)]
    public ToggleExtended pausePlayToggle;
    private bool _havePausePlayToggle;
    [Space]
    public ButtonExtended playButton;
    private bool _havePlayButton;
    public ButtonExtended pauseButton;
    private bool _havePauseButton;
    public ButtonExtended closeButton;
    private bool _haveCloseButton;
    public ButtonExtended subtitleButton;
    private bool _haveSubtitleButton;
    [Header("jump controls")]
    public float jumpSeconds;
    public ButtonExtended jumpBackButton;
    private bool _haveJumpBackButton;
    public ButtonExtended jumpForwardButton;
    private bool _haveJumpForwardButton;
    [Header("scrubbable timeline")]
    public SliderExtended timelineSlider;
    private bool _haveTimelineSlider;
    [Header("text displays")]
    public TMP_Text currentTimeText;
    private bool _haveCurrentTimeText;
    public TMP_Text totalTimeText;
    private bool _haveTotalTimeText;
    public TMP_Text timeRemaining;
    private bool _haveTimeRemaining;
    public TextMeshProUGUI subtitleTextMesh;
    private bool _haveSubtitleTextMesh;
    private bool _resumeIsQueued;
    private bool _sliderIsDrag;
    private bool _sliderWasDrag;
    private bool _ignorePlayToggleSet;
    private PlaybackState lastPlayState;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void HandlePlaybackStateDataChanged(PlaybackStateData state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateSliderDragPauseState(PlaybackStateData state, float sliderValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SetControl(IPlaybackControllable controllable) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CacheOptionalUIElements() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleSliderInput(float sliderValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleSliderHeldInput(bool isDown) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandlePausePlayToggleInput(bool newIsPlaying) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandlePlayInput() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandlePauseInput() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleCloseInput() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleJumpForwardInput() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleJumpBackwardInput() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleToggleSubtitles() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateUI(PlaybackStateData stateData, bool LogChange = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateUIControlGroup(PlaybackStateData stateData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateUITimeSlider(PlaybackStateData stateData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateUIPausePlay(PlaybackStateData stateData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateUIJumpButtons(PlaybackStateData stateData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateUITextTime(PlaybackStateData stateData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateEndScreenUIGroup(PlaybackStateData stateData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Replay() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Close() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LocalizedVideoPlayerUI() => throw null;
  }
}
