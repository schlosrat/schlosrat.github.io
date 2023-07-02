// Decompiled with JetBrains decompiler
// Type: KSP.Video.PlaybackControlVisible
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
