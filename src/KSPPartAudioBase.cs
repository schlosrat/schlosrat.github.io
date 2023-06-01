// Decompiled with JetBrains decompiler
// Type: KSPPartAudioBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using AK.Wwise;
using KSP.Audio;
using KSP.Game;
using KSP.Rendering.Planets;
using KSP.Sim.impl;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public abstract class KSPPartAudioBase : KerbalMonoBehaviour
{
  private readonly List<KSPPartAudioBase.PartAudioEvent> SingleOccurenceEvents;
  public BiomeAudioMapping biomeAudioMapping;
  public float MinPartImpactCollisionVelocity;
  public float MinTerrainImpactCollisionVelocity;
  public float MinRollingCollisionVelocity;
  public KSPPartAudioRTPCMapping _rtpcMapping;
  protected PartBehavior _partBehavior;
  private static bool _enableVerboseDebug;
  private static string _verboseFilter;
  private KSPPartAudioBase.PartAudioEvent _lastEvent;
  private uint _lastBiomeSwitch;
  protected bool _isAttachedToActiveVessel;
  protected bool _wasAttachedToMainVessel;
  private static bool _areAllBanksLoaded;
  private static bool _areAllAkObjectsRegistered;
  private bool _isAudioReady;
  private List<KSPPartAudioBase.PartAudioEvent> _unplayedEventQueue;
  protected Dictionary<uint, float> _rtpcCachedValues;

  public abstract List<KSPPartAudioBase.PartAudioEvent> SupportedEvents
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SwitchBiomeAudio(bool isTerrainCollision, PQSData.KSP2BiomeType Biome) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void PostEvent(KSPPartAudioBase.PartAudioEvent partEvent) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool HasAudioEventForPartEvent(KSPPartAudioBase.PartAudioEvent partEvent) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected bool CanPostEvent(KSPPartAudioBase.PartAudioEvent partEvent) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected void RecordLastEvent(KSPPartAudioBase.PartAudioEvent audioEvent) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected void LogPostedEvents(
    KSPPartAudioBase.PartAudioEvent partAudioEvent,
    Event[] audioEventToPlay)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected virtual Event[] GetAudioEventForPartEvent(KSPPartAudioBase.PartAudioEvent partAudioEvent) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected VesselBehavior GetVessel() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public virtual void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnAllObjectsRegisteredInternal() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnAllBanksLoadedInternal() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public virtual void OnDisable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnAudioEngineReadyInternal() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected virtual void OnAudioEngineReady() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public virtual void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void GetDependencies() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateAudioParams(VesselBehavior vessel) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateAttachmentStatus(VesselBehavior vessel) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected KSPPartAudioBase() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static KSPPartAudioBase() => throw null;

  public enum PartAudioEvent
  {
    Invalid,
    OnActive,
    OnInactive,
    OnOutOfFuel,
    OnOverheat,
    OnDestroy,
    OnDecouple,
    OnLoad,
    OnUnload,
    OnJointBreak,
    OnCollision,
    OnCollisionStart,
    OnCollisionStop,
    OnSonicBoom,
    OnFairingDeploy,
    OnDocked,
    OnUndocked,
    OnShowHeatIndicator,
    OnHideHeatIndicator,
    OnLightTurnedOn,
    OnLightTurnedOff,
    OnVABPartHighlight,
    OnResourceTransfertInboundStart,
    OnResourceTransfertInboundStop,
    OnResourceTransfertOutboundStart,
    OnResourceTransfertOutboundStop,
    OnEngineStart,
    OnEngineStop,
    OnEngineModeChangedFromFirstToSecond,
    OnEngineModeChangedFromSecondToFirst,
    OnEngineSecondaryModeStart,
    OnEngineSecondaryModeStop,
    OnEngineGimbalStartMovement,
    OnEngineGimbalStopMovement,
    OnGeneratorStart,
    OnGeneratorStop,
    OnGeneratorOverheat,
    OnCoolingStart,
    OnCoolingStop,
    OnCoolingOutOfResource,
    OnWheelTouchGround,
    OnWheelLeaveGround,
    OnWheelBreakStart,
    OnWheelBreakStop,
    OnWheelAirplaneTouchdown,
    OnParachuteArmed,
    OnParachuteSemiDeployed,
    OnParachuteDeployed,
    OnParachuteCut,
    OnParachuteStowed,
    OnAudioEngineReady,
  }
}
