// Decompiled with JetBrains decompiler
// Type: KSPPartGeneratorAudio
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
  protected override AK.Wwise.Event[] GetAudioEventForPartEvent(
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
    public AK.Wwise.Event[] onGeneratorStartEvent;
    [NonReorderable]
    public AK.Wwise.Event[] onGeneratorStopEvent;
    [NonReorderable]
    public AK.Wwise.Event[] onGeneratorOverheat;
    [NonReorderable]
    public AK.Wwise.Event[] onDestroyEvent;
    [NonReorderable]
    public AK.Wwise.Event[] onVABPartHighlight;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GeneratorSounds() => throw null;
  }
}
