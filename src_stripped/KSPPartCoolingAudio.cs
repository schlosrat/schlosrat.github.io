// Decompiled with JetBrains decompiler
// Type: KSPPartCoolingAudio
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using AK.Wwise;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class KSPPartCoolingAudio : KSPPartAudioBase
{
  public KSPPartCoolingAudio.CoolingSounds sounds;

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
  public void StartCooling() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void StopCooling() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnCoolingOutOfResource() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public KSPPartCoolingAudio() => throw null;

  [Serializable]
  public class CoolingSounds
  {
    [NonReorderable]
    public Event[] OnCoolingStart;
    [NonReorderable]
    public Event[] OnCoolingStop;
    [NonReorderable]
    public Event[] OnCoolingOutOfResource;
    [NonReorderable]
    public Event[] onVABPartHighlight;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CoolingSounds() => throw null;
  }
}
