// Decompiled with JetBrains decompiler
// Type: KSP.FX.Timeline.TimelineAdapter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using AK.Wwise;
using KSP.Game;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace KSP.FX.Timeline
{
  [RequireComponent(typeof (PlayableDirector))]
  public class TimelineAdapter : KerbalMonoBehaviour
  {
    private PlayableDirector director;
    [Tooltip("If True, will look for ObjectProxy Tracks in timeline and resolve bindings through them")]
    public bool resolveObjectProxies;
    private List<GameObject> _spawnedObjects;
    private List<Event> _timelineAudio;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Shutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Cleanup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnClipEnd(EffectAtLocationBehavior curEALB) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResolveObjectReferenceProxies() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnTimeWarpRateChange(float newTimeWarpRate) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PlayTimeLine() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void StopTimeLine() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TriggerLaunch() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TriggerTimelineLaunchIfNotAlreadyLaunched() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void StopEffects(ParticleSystemStopBehavior stopBehaviour = ParticleSystemStopBehavior.StopEmitting) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void StopAudio() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DestroyEffects() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameObject CreateEffectAtLocation(GameObject VFX, string locationObjectTag) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SendPartAudioEvent(string targetTag, string audioCategory) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GetReferenceProxiesRecursive(
      IEnumerable<TrackAsset> groupTracks,
      Dictionary<TrackAsset, ObjectReferenceProxy> proxyMap)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TimelineAdapter() => throw null;
  }
}
