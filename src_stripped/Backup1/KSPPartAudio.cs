// Decompiled with JetBrains decompiler
// Type: KSPPartAudio
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Messages;
using KSP.Sim.impl;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[DisallowMultipleComponent]
public class KSPPartAudio : KSPPartAudioBase
{
  private SubscriptionHandle _decoupleMessageHandle;
  private float _k_part_collision_velocity;
  private float _k_part_fairing_nb_panels;
  private bool _enableCollisionVerbose;
  private bool _IsInCollision;
  private int _collisionStayFrame;
  private int _nbOfFrameToReleaseCollision;
  private double _oldMachNumber;
  private bool _isShowingHeatIndicator;
  private VesselBehavior _vessel;
  public List<KSPPartAudio.SoundEventCategory> namedSoundEvents;
  public KSPPartAudio.Sounds sounds;

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
  public void PostEventCategory(string eventCategory) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnDestroy() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override void OnDisable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnDecoupleEventMessage(MessageCenterMessage decoupleMessage) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void JointBreak() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void HandleCollisionAudio(bool isTerrainCollision, Vector3 relativeVelocity) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void HandleCollisionEnter(bool isTerrainCollision, Vector3 relativeVelocity) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void HandleCollisionStay(bool isTerrainCollision, Vector3 relativeVelocity) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void HandleCollisionExit(bool isTerrainCollision) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnFairingDeploy(int numberOfPanels) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnPartDocked() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnPartUndocked() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnLightTurnedOn() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnLightTurnedOff() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateCollisionLoop() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void GetDependencies() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void InitDecoupleModuleAudio() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateSonicBoom() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnShowHeatIndicator() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnHideHeatIndicator() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public KSPPartAudio() => throw null;

  [Serializable]
  public class SoundEventCategory
  {
    public string category;
    public AK.Wwise.Event akEvent;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SoundEventCategory() => throw null;
  }

  [Serializable]
  public class Sounds
  {
    [NonReorderable]
    public AK.Wwise.Event[] onActivateEvent;
    [NonReorderable]
    public AK.Wwise.Event[] onInactiveEvent;
    [NonReorderable]
    public AK.Wwise.Event[] onOverheatEvent;
    [NonReorderable]
    public AK.Wwise.Event[] onDestroyEvent;
    [NonReorderable]
    public AK.Wwise.Event[] onDecoupleEvent;
    [NonReorderable]
    public AK.Wwise.Event[] onLoadEvent;
    [NonReorderable]
    public AK.Wwise.Event[] onUnloadEvent;
    [NonReorderable]
    public AK.Wwise.Event[] onJointBreak;
    [NonReorderable]
    public AK.Wwise.Event[] onPartCollision;
    [NonReorderable]
    public AK.Wwise.Event[] onPartCollisionStart;
    [NonReorderable]
    public AK.Wwise.Event[] onPartCollisionStop;
    [NonReorderable]
    public AK.Wwise.Event[] onSonicBoom;
    [NonReorderable]
    public AK.Wwise.Event[] onFairingDeploy;
    [NonReorderable]
    public AK.Wwise.Event[] onDock;
    [NonReorderable]
    public AK.Wwise.Event[] onUndock;
    [NonReorderable]
    public AK.Wwise.Event[] onShowHeatIndicator;
    [NonReorderable]
    public AK.Wwise.Event[] onHideHeatIndicator;
    [NonReorderable]
    public AK.Wwise.Event[] onLightTurnedOn;
    [NonReorderable]
    public AK.Wwise.Event[] onLightTurnedOff;
    [NonReorderable]
    public AK.Wwise.Event[] onVABPartHighlight;
    [NonReorderable]
    public AK.Wwise.Event[] onResourceTransfertInboundStart;
    [NonReorderable]
    public AK.Wwise.Event[] onResourceTransfertInboundStop;
    [NonReorderable]
    public AK.Wwise.Event[] onResourceTransfertOutboundStart;
    [NonReorderable]
    public AK.Wwise.Event[] onResourceTransfertOutboundStop;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Sounds() => throw null;
  }
}
