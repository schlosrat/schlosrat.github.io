// Decompiled with JetBrains decompiler
// Type: KSP.FX.Timeline.ContextualFXSystemMixer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
