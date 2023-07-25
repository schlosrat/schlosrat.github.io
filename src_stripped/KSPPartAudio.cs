// Decompiled with JetBrains decompiler
// Type: KSPPartAudio
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using AK.Wwise;
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
  protected override Event[] GetAudioEventForPartEvent(
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
    public Event akEvent;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SoundEventCategory() => throw null;
  }

  [Serializable]
  public class Sounds
  {
    [NonReorderable]
    public Event[] onActivateEvent;
    [NonReorderable]
    public Event[] onInactiveEvent;
    [NonReorderable]
    public Event[] onOverheatEvent;
    [NonReorderable]
    public Event[] onDestroyEvent;
    [NonReorderable]
    public Event[] onDecoupleEvent;
    [NonReorderable]
    public Event[] onLoadEvent;
    [NonReorderable]
    public Event[] onUnloadEvent;
    [NonReorderable]
    public Event[] onJointBreak;
    [NonReorderable]
    public Event[] onPartCollision;
    [NonReorderable]
    public Event[] onPartCollisionStart;
    [NonReorderable]
    public Event[] onPartCollisionStop;
    [NonReorderable]
    public Event[] onSonicBoom;
    [NonReorderable]
    public Event[] onFairingDeploy;
    [NonReorderable]
    public Event[] onDock;
    [NonReorderable]
    public Event[] onUndock;
    [NonReorderable]
    public Event[] onShowHeatIndicator;
    [NonReorderable]
    public Event[] onHideHeatIndicator;
    [NonReorderable]
    public Event[] onLightTurnedOn;
    [NonReorderable]
    public Event[] onLightTurnedOff;
    [NonReorderable]
    public Event[] onVABPartHighlight;
    [NonReorderable]
    public Event[] onResourceTransfertInboundStart;
    [NonReorderable]
    public Event[] onResourceTransfertInboundStop;
    [NonReorderable]
    public Event[] onResourceTransfertOutboundStart;
    [NonReorderable]
    public Event[] onResourceTransfertOutboundStop;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Sounds() => throw null;
  }
}
