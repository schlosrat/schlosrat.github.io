// Decompiled with JetBrains decompiler
// Type: KSPPartAmbientEmitter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class KSPPartAmbientEmitter : KSPPartAudioBase
{
  public KSPPartAmbientEmitter.AmbientEmitterSounds sounds;

  public override List<KSPPartAudioBase.PartAudioEvent> SupportedEvents
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected override AK.Wwise.Event[] GetAudioEventForPartEvent(
    KSPPartAudioBase.PartAudioEvent partAudioEvent)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected override void OnAudioEngineReady() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public KSPPartAmbientEmitter() => throw null;

  [Serializable]
  public class AmbientEmitterSounds
  {
    [NonReorderable]
    public AK.Wwise.Event[] OnAudioEngineReady;
    [NonReorderable]
    public AK.Wwise.Event[] onUnload;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AmbientEmitterSounds() => throw null;
  }
}
