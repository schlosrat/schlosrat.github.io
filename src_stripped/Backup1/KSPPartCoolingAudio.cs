// Decompiled with JetBrains decompiler
// Type: KSPPartCoolingAudio
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
  protected override AK.Wwise.Event[] GetAudioEventForPartEvent(
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
    public AK.Wwise.Event[] OnCoolingStart;
    [NonReorderable]
    public AK.Wwise.Event[] OnCoolingStop;
    [NonReorderable]
    public AK.Wwise.Event[] OnCoolingOutOfResource;
    [NonReorderable]
    public AK.Wwise.Event[] onVABPartHighlight;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CoolingSounds() => throw null;
  }
}
