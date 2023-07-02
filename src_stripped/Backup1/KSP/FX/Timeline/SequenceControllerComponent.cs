// Decompiled with JetBrains decompiler
// Type: KSP.FX.Timeline.SequenceControllerComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Playables;

namespace KSP.FX.Timeline
{
  [RequireComponent(typeof (PlayableDirector))]
  public class SequenceControllerComponent : KerbalMonoBehaviour
  {
    private PlayableDirector director;
    [NonReorderable]
    public SequenceControllerComponent.NamedTimeline[] NamedTimelines;
    [HideInInspector]
    public int InstanceIndex;
    public Action OnClipEnd;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Shutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator RegisterMessages() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPlayableDirectorStopped(PlayableDirector aDirector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnTimeWarpRateChange(float newTimeWarpRate) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTimePauseStateChange(bool isPaused) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PlayTimeLine() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PlayTimeLine(string TimelineName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void StopTimeLine() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SequenceControllerComponent() => throw null;

    [Serializable]
    public class NamedTimeline
    {
      public string Name;
      public PlayableAsset Timeline;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public NamedTimeline() => throw null;
    }
  }
}
