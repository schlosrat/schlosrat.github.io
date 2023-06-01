// Decompiled with JetBrains decompiler
// Type: TriggerRandomTimelinesWithDelay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class TriggerRandomTimelinesWithDelay : MonoBehaviour
{
  [SerializeField]
  private float minDelay;
  [SerializeField]
  private float maxDelay;
  [SerializeField]
  private TimelineAsset[] _timelinesToChooseFrom;
  private PlayableDirector _director;
  private bool _delayMode;
  private float _delayTimer;
  private int _curTimelineIndex;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ResetDelayTimer() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void PickRandomTimelineIndex() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void PlayNextTimeline() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDirectorStopped(PlayableDirector director) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public TriggerRandomTimelinesWithDelay() => throw null;
}
