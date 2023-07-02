// Decompiled with JetBrains decompiler
// Type: KSPPartEngineAudio
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Messages;
using KSP.Modules;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class KSPPartEngineAudio : KSPPartAudioBase
{
  public KSPPartEngineAudio.EngineSounds sounds;
  public KSPPartEngineAudio.SecondaryEngineSounds secondaryEngineSounds;
  private Module_Engine _engineModule;
  private IEngineStatus _engineStatus;
  private bool _isSolidFuelBooster;
  private bool _isEngineActive;
  private bool _engineMode1CurrentlyActive;
  private bool _engineMode2CurrentlyActive;
  private SubscriptionHandle _flameOutMessageHandle;
  private SubscriptionHandle _engineActivationMessageHandle;
  private SubscriptionHandle _engineModeChangedMessageHandle;
  private SubscriptionHandle _gimbalActivationMessageHandle;
  private bool _isOutOfFuelMode1;
  private bool _isOutOfFuelMode2;
  private bool _isSecondaryMode;
  private int _forcedEngineIndex;
  private Vector3 _previousListenerPosition;
  private Vector3 _previousSourcePosition;
  private const float MaxDistance = 100f;
  private float _vesselThrottle;
  private float _p_vessel_relative_speed_doppler;
  private static int DopplerDeferFrameCount;
  private int _dopplerCountdown;
  private bool _isGimbalPlaying;

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
  public override void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override void OnDisable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void DestroyEngine() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnDestroy() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnEngineActivationChanged(MessageCenterMessage engineActiveMsg) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnEngineModeChanged(MessageCenterMessage modeChange) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnGimbalActicationChanged(MessageCenterMessage modeChange) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void ForceUpdateEngineMode(int newModeIdx) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void ActivateEngine() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void DeactivateEngine() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void InitEngineModuleAudio() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void InitMessages() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnEngineFlameout(MessageCenterMessage flameOut) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void GetDependencies() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateEngineMode() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateAudioParams() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void LateUpdate() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public KSPPartEngineAudio() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static KSPPartEngineAudio() => throw null;

  [Serializable]
  public class EngineSounds
  {
    [NonReorderable]
    public AK.Wwise.Event[] onEngineStartEvent;
    [NonReorderable]
    public AK.Wwise.Event[] onEngineStopEvent;
    [NonReorderable]
    public AK.Wwise.Event[] onDestroyEvent;
    [NonReorderable]
    public AK.Wwise.Event[] onOutOfFuelEvents;
    [NonReorderable]
    public AK.Wwise.Event[] onVABPartHighlight;
    [NonReorderable]
    public AK.Wwise.Event[] onGimbalStartMoving;
    [NonReorderable]
    public AK.Wwise.Event[] onGimbalStopMoving;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public EngineSounds() => throw null;
  }

  [Serializable]
  public class SecondaryEngineSounds
  {
    [NonReorderable]
    public AK.Wwise.Event[] onEngineSecondModeStartEvent;
    [NonReorderable]
    public AK.Wwise.Event[] onEngineSecondModeStopEvent;
    [NonReorderable]
    public AK.Wwise.Event[] onEngineModeChangedFromFirstToSecond;
    [NonReorderable]
    public AK.Wwise.Event[] onEngineModeChangedFromSecondToFirst;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SecondaryEngineSounds() => throw null;
  }
}
