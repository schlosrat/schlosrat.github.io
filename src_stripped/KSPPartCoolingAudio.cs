// Decompiled with JetBrains decompiler
// Type: KSPPartCoolingAudio
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
