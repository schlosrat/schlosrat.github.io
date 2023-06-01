// Decompiled with JetBrains decompiler
// Type: KSP.FX.Timeline.PartAudioEventBehavior
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine.Playables;

namespace KSP.FX.Timeline
{
  [Serializable]
  public class PartAudioEventBehavior : PlayableBehaviour
  {
    public string audioEventCategory;
    public string targetTagName;
    private bool active;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Activate(TimelineAdapter adapter) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Deactivate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartAudioEventBehavior() => throw null;
  }
}
