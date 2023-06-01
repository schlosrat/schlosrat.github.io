// Decompiled with JetBrains decompiler
// Type: KSP.FX.Timeline.ContextualFXSystemTrack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace KSP.FX.Timeline
{
  [TrackClipType(typeof (ContextualFXSystemData))]
  [TrackBindingType(typeof (SequenceControllerComponent))]
  public class ContextualFXSystemTrack : TrackAsset
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ContextualFXSystemTrack() => throw null;
  }
}
