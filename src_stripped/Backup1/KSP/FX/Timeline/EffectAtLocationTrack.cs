// Decompiled with JetBrains decompiler
// Type: KSP.FX.Timeline.EffectAtLocationTrack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace KSP.FX.Timeline
{
  [TrackBindingType(typeof (TimelineAdapter))]
  [TrackClipType(typeof (EffectAtLocationData))]
  public class EffectAtLocationTrack : TrackAsset
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public EffectAtLocationTrack() => throw null;
  }
}
