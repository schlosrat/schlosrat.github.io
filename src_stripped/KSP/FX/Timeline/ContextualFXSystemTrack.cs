// Decompiled with JetBrains decompiler
// Type: KSP.FX.Timeline.ContextualFXSystemTrack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
    public virtual Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ContextualFXSystemTrack() => throw null;
  }
}
