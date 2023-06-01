// Decompiled with JetBrains decompiler
// Type: KSPPartParachuteAudio
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
  protected override AK.Wwise.Event[] GetAudioEventForPartEvent(
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
    public AK.Wwise.Event[] onActivate;
    [NonReorderable]
    public AK.Wwise.Event[] onSemiDeployed;
    [NonReorderable]
    public AK.Wwise.Event[] onDeployed;
    [NonReorderable]
    public AK.Wwise.Event[] OnCut;
    [NonReorderable]
    public AK.Wwise.Event[] OnStowed;
    [NonReorderable]
    public AK.Wwise.Event[] onVABPartHighlight;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ParachuteSounds() => throw null;
  }
}
