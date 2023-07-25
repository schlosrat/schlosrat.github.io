// Decompiled with JetBrains decompiler
// Type: KSPPartParachuteAudio
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using AK.Wwise;
using KSP.Modules;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class KSPPartParachuteAudio : KSPPartAudioBase
{
  public KSPPartParachuteAudio.ParachuteSounds sounds;

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
  public void OnDeploymentStateChanged(Data_Parachute.DeploymentStates newState) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public KSPPartParachuteAudio() => throw null;

  [Serializable]
  public class ParachuteSounds
  {
    [NonReorderable]
    public Event[] onActivate;
    [NonReorderable]
    public Event[] onSemiDeployed;
    [NonReorderable]
    public Event[] onDeployed;
    [NonReorderable]
    public Event[] OnCut;
    [NonReorderable]
    public Event[] OnStowed;
    [NonReorderable]
    public Event[] onVABPartHighlight;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ParachuteSounds() => throw null;
  }
}
