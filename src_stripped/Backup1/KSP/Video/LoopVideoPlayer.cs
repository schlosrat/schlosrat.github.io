// Decompiled with JetBrains decompiler
// Type: KSP.Video.LoopVideoPlayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.UI;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

namespace KSP.Video
{
  public class LoopVideoPlayer : Indicator
  {
    protected const float FRAME_TIME_60_HZ = 0.0166666675f;
    protected bool _isPlaying;
    [Tooltip("Will play on Start and OnEnable.")]
    [SerializeField]
    protected bool playAutomatically;
    protected bool autoAddedToProvider;
    [SerializeField]
    private RectTransform _UIpanelRectTransform;
    private Vector2 _videoDefaultSize;
    [Space]
    [SerializeField]
    protected VideoPlayer _videoPlayer;
    [SerializeField]
    protected Image _gifPlayerUIScreen;
    [SerializeField]
    protected RawImage _videoPlayerUIScreen;
    [SerializeField]
    protected Image _border;
    [SerializeField]
    [Header("If not null this will play on Start")]
    [Tooltip("Set this on Indicator or TooltipPrefabs")]
    protected LoopVideoData _defaultVideoData;
    protected RenderTexture _videoPlayerTexture;
    protected LoopVideoData _currentVideoData;
    protected int spriteIndex;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsDataValid() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddToProvider() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemoveFromProvider() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Show(IndicatorData indicatorData, Action<Indicator> onHideCallback) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Play(LoopVideoData loopVideoData, Vector2 size, bool usevideoPlayerSize = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Stop() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual bool Validate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LoopVideoPlayer() => throw null;
  }
}
