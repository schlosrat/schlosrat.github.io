// Decompiled with JetBrains decompiler
// Type: EdyCommonTools.SplineFollowTrack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace EdyCommonTools
{
  [TrackBindingType(typeof (Transform))]
  [TrackClipType(typeof (SplineFollowAsset))]
  public class SplineFollowTrack : TrackAsset
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SplineFollowTrack() => throw null;
  }
}
