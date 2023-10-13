// Decompiled with JetBrains decompiler
// Type: KSPPartAmbientEmitter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using AK.Wwise;
using KSP.Game;
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
  protected override Event[] GetAudioEventForPartEvent(
    KSPPartAudioBase.PartAudioEvent partAudioEvent)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected override void OnAudioEngineReady() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected override bool RequireGetDependencies(GameState gameState) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public KSPPartAmbientEmitter() => throw null;

  [Serializable]
  public class AmbientEmitterSounds
  {
    [NonReorderable]
    public Event[] OnAudioEngineReady;
    [NonReorderable]
    public Event[] onUnload;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AmbientEmitterSounds() => throw null;
  }
}
