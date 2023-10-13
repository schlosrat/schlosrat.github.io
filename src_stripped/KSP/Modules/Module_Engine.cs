// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Module_Engine
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Messages;
using KSP.OAB;
using KSP.Sim.Definitions;
using KSP.Sim.impl;
using KSP.VFX;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.Modules
{
  [ExecuteInEditMode]
  [DisallowMultipleComponent]
  public class Module_Engine : PartBehaviourModule, IEngineStatus
  {
    private static int emissionColorShaderParamHash;
    private static float _spoolEpsilon;
    [FormerlySerializedAs("data")]
    [SerializeField]
    protected Data_Engine dataEngine;
    public Module_Generator Alternator;
    public Module_Gimbal Gimbal;
    [SerializeField]
    private string _engineModeIsDeployedParamName;
    [SerializeField]
    private string _engineModeWantDeployedParamName;
    public FlameoutVFXData FlameoutVFX;
    private Animator _animator;
    private StagingComponent _staging;
    private int _stageIndex;
    private ICollection<PartComponent> _partMove;
    private RaycastHit _hit;
    private int _damageLayerMask;
    private double _timeLastShockwave;
    private float _deltaTime;
    private RaycastHit[] _thrustHits;
    private int _thrustHitCount;
    private List<Data_Engine.EngineForce> _engineForces;
    private List<Data_Engine.DamageForce> _engineDamageForces;
    private List<Data_Engine.ShockwaveForce> _engineShockForces;
    private List<Module_Engine.PartThrustHit> _uniquePartHits;
    private List<Data_Engine.ThrustCollisionInfo> _thrustCollisions;
    private SubscriptionHandle _onRevertMessageHandle;
    private ModuleAction _actionActivateDeactivate;
    private ModuleAction _actionChangeEngineMode;
    private ModuleAction _actionStageEngine;
    private List<Material> _emissiveMaterials;
    private bool _emissiveListPopulated;
    private float _emissiveIntensity;
    private float _throttleLerp;
    private Coroutine _changeModeCoroutine;
    private Coroutine _startEngineCoroutine;
    private Coroutine _stopEngineCoroutine;
    private int _deployedModeHash;

    public override System.Type PartComponentModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool EngineIgnited
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int CurrentEngineMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float ThrustPercentage
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float ActualThrust
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public List<Data_Engine.ThrustCollisionInfo> ThrustCollisionInfo
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Data_Engine.EngineMode currentEngineModeData
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public PropellantState CurrentPropellantState
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void AddDataModules() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnInitialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EngineModeDropdownOnChangeValue(string activeEngineModeName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int FindEngineModeIndexFromEngineID(string engineID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InitAnimator() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetEngineModeOne() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetEngineModeTwo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetIndependentThrottle(bool state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void IndependentThrottleEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void IndependentThrottleDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetThrustTransforms() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitThrustTransformMultipliers() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnShutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void IndependentThrottleChanged(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnOABThrustPercentageChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnRevertToLaunchEventMessage(MessageCenterMessage revertMessage) => throw null;

    private double universalTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateGimbalInvert() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnModuleFixedUpdate(float fixedDeltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnModuleOABFixedUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void UpdateThrustRelativeControlPoint() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ToggleStaging(bool bValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ToggleStagingForFlight(bool bValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void SpoolFXUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetSpoolUpDownState(float toValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void UpdateThrottle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void ThrustUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void ThermalUpdate(double deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected bool CheckTransformsUnderwater() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void EngineExhaustDamage() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void EngineShockWave() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEngineFlameoutChangedMessage(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AutoSwitchModes(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEngineShutdownMessage(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator Shutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void PlayFlameoutFX(bool flamingOut) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnCenterOfThrustQuery(CenterOfThrustQuery qry) => throw null;

    public Data_Engine.EngineForce AverageEngineForce
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool isOperational
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float normalizedOutput
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float throttleSetting
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string engineName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string engineDisplayName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ChangeEngineMode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ChangeEngineMode(int modeIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateAnimatorToModeChange(int modeIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnAnimStateEnter(Animator animator, int stateMachineHash) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator SwitchingEngineMode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ActivateDeactivateEngine() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void StageEngine() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ActivateEngine() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ActivateEngine(bool mpRemoteActivate) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DeactivateEngine() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DeactivateEngine(bool mpRemoteDeactivate) => throw null;

    public bool IsPropellantStarved
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float RequestedThrottle
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [Obsolete("Temporary access method till Multiplayer is using the sim instead of a bandaid to the view")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void SetRequestedThrottle(float newValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator EngineIgnitionOn(bool mpRemoteActivate) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetActivateDeactivateActionState(bool isActive, bool publishMessage = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string GetModuleDisplayName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Module_Engine() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static Module_Engine() => throw null;

    protected class PartThrustHit
    {
      public RaycastHit hit;
      public double damageScale;
      public PartBehavior part;
      public Vector3 relativeForcePosition;
      public Vector3 relativeForce;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public PartThrustHit() => throw null;
    }
  }
}
