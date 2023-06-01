// Decompiled with JetBrains decompiler
// Type: KSP.Video.PlaybackControlVisible
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Video
{
  [RequireComponent(typeof (CanvasGroup))]
  public class PlaybackControlVisible : PlaybackController
  {
    private CanvasGroup _canvasGroup;
    [Header("Visibility states for each of the playback states")]
    public PlaybackControlVisible.VisibilityState VisibilityPlaying;
    public PlaybackControlVisible.VisibilityState VisibilityPaused;
    public PlaybackControlVisible.VisibilityState VisibilityNoData;
    public PlaybackControlVisible.VisibilityState VisibilityLoading;
    public PlaybackControlVisible.VisibilityState VisibilityUnloaded;
    public PlaybackControlVisible.VisibilityState VisibilityErrored;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void HandlePlaybackStateDataChanged(PlaybackStateData state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void HandlePlaybackStateChange(PlaybackState state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void UpdateVisibility(
      PlaybackControlVisible.VisibilityState newVisibility)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PlaybackControlVisible() => throw null;

    public enum VisibilityState
    {
      Visible,
      Disabled,
      Hidden,
    }
  }
}
