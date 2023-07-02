// Decompiled with JetBrains decompiler
// Type: KSPPartParachuteAudio
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
