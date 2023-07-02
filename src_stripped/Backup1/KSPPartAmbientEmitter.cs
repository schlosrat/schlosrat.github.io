// Decompiled with JetBrains decompiler
// Type: KSPPartAmbientEmitter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
