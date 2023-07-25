// Decompiled with JetBrains decompiler
// Type: KSP.FX.Timeline.EffectAtLocationData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace KSP.FX.Timeline
{
  [Serializable]
  public class EffectAtLocationData : PlayableAsset, ITimelineClipAsset
  {
    public EffectAtLocationBehavior EffectLocationData;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) => throw null;

    public ClipCaps clipCaps
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public EffectAtLocationData() => throw null;
  }
}
