// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Module_WheelBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Animation;
using KSP.Inspector;
using KSP.Messages;
using KSP.Sim;
using KSP.Sim.Definitions;
using KSP.Sim.impl;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;
using VehiclePhysics;

namespace KSP.Modules
{
  [DisallowMultipleComponent]
  [RequireComponent(typeof (Module_ReinforcedConnection))]
  public class Module_WheelBase : PartBehaviourModule, IGroundOffsetModifier, ILateUpdate
  {
    [SerializeField]
    protected Data_WheelBase dataWheelBase;
    [ReadOnly]
    [Header("Runtime Variables Below here - Do not change")]
    [SerializeField]
    private KSPWheelController _wheel;
    private bool _VFXCollisionTracked;
    [SerializeField]
    [ReadOnly]
    private GameObject _wheelHost;
    private GameObject _clipGameObject;
    public bool SuspensionEnabled;
    public Transform WheelColliderHost;
    public Transform WheelTransform;
    private List<Module_WheelSubmodule> _subModules;
    private bool _setup;
    [SerializeField]
    private bool _driftCorrection;
    [NonSerialized]
    private Collider _gCollider;
    [NonSerialized]
    private Collider _gColliderPrev;
    [NonSerialized]
    private VesselBehavior _vSrfContact;
    [NonSerialized]
    private string _vLandedAt;
    [NonSerialized]
    private List<LateUpdateConstraint> _managedLateUpdateConstraints;
    public Vector2 SlipDisplacement;
    private WheelSubsystems _inopSystems;
    private WheelSubsystem _inopOnRails;
    private WheelSubsystem _inopSuspension;
    private WheelSubsystem _deploymentSubsystems;
    private bool _subsystemsDisabled;
    private Module_WheelBrakes _brakesSubmodule;
    private Data_WheelBrakes _dataWheelBrakes;
    private Module_WheelLock _wheelLockSubmodule;
    private Module_WheelDamage _wheelDamageSubmodule;
    private Module_Deployable _deployableSubmodule;
    private Data_Deployable _dataDeployable;
    [SerializeField]
    private bool _rbBrakeConstraints;
    [SerializeField]
    private bool _deploymentStateChanging;
    [SerializeField]
    private SphereCollider _standInCollider;
    private SubscriptionHandle _handleSOIEntered;
    private SubscriptionHandle _handleDocked;
    private SubscriptionHandle _handleUndocked;
    private bool _lateUpdateConstraintsEnabled;
    private float schloompaTime;
    private Module_WheelDamage moduleWheelDamage;
    private float acquireMaxSpeed;
    private Vector3 fixFwd;
    private Vector3 error;
    private Vector3 errorLast;
    [FormerlySerializedAs("kd")]
    [SerializeField]
    private float driftDifferenceErrorCorrectionMul;
    [FormerlySerializedAs("ki")]
    [SerializeField]
    private float driftErrorCorrectionMul;
    private Module_WheelBase.DriftCorrectionState driftCorrectionState;

    public override System.Type PartComponentModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [ReadOnly]
    public KSPWheelController Wheel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 WheelOrgPosR
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Quaternion WheelOrgRotR
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public WheelSubsystems InopSystems
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void AddDataModules() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnInitialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetFrictionState(bool newState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetFrictionStateOn() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetFrictionStateOff() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void WheelSetup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float ApplyGeeBias(float gee) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateFriction() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDeploymentStateChanging(float state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetInopSubsystems(bool disable) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnShutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnModuleFixedUpdate(float fixedDeltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnLateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateWheelVFX() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EnterWheelContactVFX() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateWheelContactVFX() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ExitWheelContactVFX() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CheckSubsteps() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LandingDetectionUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected bool LandedDetectionNeedsUpdate(
      Collider hitCollider,
      Collider hitColliderPrev,
      VesselBehavior vContact,
      bool isGrounded)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IgnoreForcesOnSameVesselContact(VehicleBase.WheelState st) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LSchloomphaVPPProcessing() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EnableWheelCollider() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DisableWheelCollider(bool immediate = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void ResetWheelGroundCheck() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterSubmodule(Module_WheelSubmodule m) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnregisterSubmodule(Module_WheelSubmodule m) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnWheelSetup(KSPWheelController w) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPartPack(PartBehavior partBeh) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPartUnpack(PartBehavior partBeh) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDockingComplete(MessageCenterMessage curMCM) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResetBrakeInput(float prevInput) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselUndocking(MessageCenterMessage curMCM) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ToggleRbConstraints(bool freeze) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HoldWheelDamage(float seconds = 3f) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SOIChange(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected SphereCollider CreateStandInCollider(KSPWheelController w) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnSubsystemsModified(WheelSubsystems sub) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InopUpdate(bool force = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InopWheelCollider(bool inop, bool force) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InopWheelTransform(bool disable) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CheckSuspensionToggle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void UpdateDriftFix() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected Vector3 GetFixFwd() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void GetFixTorque(Vector3 fixOrt, Vector3 refOrt) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void ActionUIUpdate(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetDeployStateExtended() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetDeployStateRetracted() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetDeployState(bool newState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ToggleLateUpdateConstraints(bool doUpdate, bool force = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPutToGround(ref float lowestPoint) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Module_WheelBase() => throw null;

    public enum DriftCorrectionState
    {
      Idle,
      Acquire,
      Fix,
    }
  }
}
