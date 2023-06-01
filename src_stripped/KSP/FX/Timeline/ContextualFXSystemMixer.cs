// Decompiled with JetBrains decompiler
// Type: KSP.FX.Timeline.ContextualFXSystemMixer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace KSP.FX.Timeline
{
  public class ContextualFXSystemMixer : PlayableBehaviour
  {
    public TimelineClip[] Clips;
    private SequenceControllerComponent _controller;
    private List<ContextualFXSystemBehavior> _startedClips;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnGraphStop(Playable playable) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void ProcessFrame(Playable playable, FrameData info, object playerData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ContextualFXSystemMixer() => throw null;
  }
}
