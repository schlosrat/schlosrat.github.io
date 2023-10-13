// Decompiled with JetBrains decompiler
// Type: KSPPartGeneratorAudio
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using AK.Wwise;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class KSPPartGeneratorAudio : KSPPartAudioBase
{
  public KSPPartGeneratorAudio.GeneratorSounds sounds;

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
  public void ActivateGenerator() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void DeactivateGenerator() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OverheatGenerator() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override void OnDisable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public KSPPartGeneratorAudio() => throw null;

  [Serializable]
  public class GeneratorSounds
  {
    [NonReorderable]
    public Event[] onGeneratorStartEvent;
    [NonReorderable]
    public Event[] onGeneratorStopEvent;
    [NonReorderable]
    public Event[] onGeneratorOverheat;
    [NonReorderable]
    public Event[] onDestroyEvent;
    [NonReorderable]
    public Event[] onVABPartHighlight;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GeneratorSounds() => throw null;
  }
}
