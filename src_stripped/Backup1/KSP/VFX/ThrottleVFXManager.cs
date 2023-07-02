// Decompiled with JetBrains decompiler
// Type: KSP.VFX.ThrottleVFXManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Messages;
using KSP.Modules;
using KSP.Sim;
using KSP.Sim.impl;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.VFX
{
  [DisallowMultipleComponent]
  public class ThrottleVFXManager : KerbalMonoBehaviour
  {
    [Tooltip("Define the list of Action Events here for each Engine Mode.\n0 = The first (or only if only one engine mode for this engine), 1 = Second engine mode, and so on.")]
    public ThrottleVFXManager.FXModeActionEvent[] FXModeActionEvents;
    [FormerlySerializedAs("debugMode")]
    [HideInInspector]
    public bool DebugMode;
    private IFloatingOrigin _floatingOrigin;
    [FormerlySerializedAs("engineUsesDiscreteBursts")]
    [HideInInspector]
    public bool EngineUsesDiscreteBursts;
    [FormerlySerializedAs("triggerDiscreteAnimation")]
    [HideInInspector]
    public bool TriggerDiscreteAnimation;
    [HideInInspector]
    [FormerlySerializedAs("animTriggerName")]
    public string AnimTriggerName;
    [HideInInspector]
    [FormerlySerializedAs("isSolidFuelBooster")]
    public bool IsSolidFuelBooster;
    public AtmosphereTransitionVFXHandling AtmoTransVFXHandler;
    private float _solidBoosterThrustValue;
    private PartBehavior _thisPart;
    private VesselComponent _vessel;
    private float _vesselThrust;
    private Module_Engine _engineModule;
    private Data_Engine _engineData;
    private float _discreteBurstTimer;
    private bool _resetDiscreteBurstTimer;
    private bool _engineRunning;
    private bool _engineFlameout;
    private SubscriptionHandle _subscriptionHandle;
    private Animator _animator;
    private Vector3 _localAngularVel;
    private bool _TVMInitialized;
    private bool _isVFXActive;
    private int _currentEngineMode;
    private int _debugEngineModeCount;
    private bool _engineFXVisible;

    public VesselComponent Vessel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool EngineRunning
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int CurrentEngineMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int DebugEngineModeCount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsVFXActive
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEngineStateChange(MessageCenterMessage message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEngineModeExit(MessageCenterMessage message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEngineModeEnter(MessageCenterMessage message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEngineFlameout(MessageCenterMessage message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool ValidEngineMode(
      int engineModeIndex,
      out ThrottleVFXManager.FXModeActionEvent modeActionEvent)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEngineFXVisibilityChanged(MessageCenterMessage message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(IFloatingOrigin floatingOrigin, PartBehavior part, Module_Engine engineModule) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitFXData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TryInitSolidBooster() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitAnimator() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateEvents(
      bool running,
      int engineMode,
      float thrust,
      float pressure,
      float angularVelocity,
      Vector3 acceleration)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool UpdateDiscreteBurst(
      ThrottleParticleSystemData TPSD,
      float throttleMultiplier,
      float discreteBurstTimer)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ManageDiscreteBurstTimerAndAnimations() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateVFXActivationState(bool isOn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ThrottleVFXManager() => throw null;

    public enum FXmodeEvent
    {
      FXModeExit,
      FXModeEnter,
      FXModeExitRunning,
      FXModeEnterRunning,
      FXModeFlameout,
      FXModeRestart,
      FXModeStart,
      FXModeStop,
      FXModeIncreasing,
      FXModeDecreasing,
      FXModeRunning,
    }

    [Serializable]
    public class EngineEffect
    {
      [Tooltip("This should be the reference to the FX gameobject in the prefab.")]
      public GameObject EffectReference;
      [HideInInspector]
      public IEngineFXData EngineFXComponent;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public EngineEffect() => throw null;
    }

    [Serializable]
    public class FXActionEvent
    {
      [Tooltip("The Event this FX will be triggered by.")]
      public ThrottleVFXManager.FXmodeEvent ModeEvent;
      public ThrottleVFXManager.EngineEffect[] EngineEffects;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public FXActionEvent() => throw null;
    }

    [Serializable]
    public class FXModeActionEvent
    {
      [Tooltip("This is the Engine Mode Index.\n0 = The first (or only if only one engine mode for this engine), 1 = Second engine mode, and so on.")]
      public int EngineModeIndex;
      [Tooltip("Define the list of Action Events here for this Engine Mode.")]
      public ThrottleVFXManager.FXActionEvent[] ActionEvents;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public FXModeActionEvent() => throw null;
    }
  }
}
