// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Module_WheelSuspension
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  [DisallowMultipleComponent]
  public class Module_WheelSuspension : Module_WheelSubmodule, ILateUpdate
  {
    [SerializeField]
    protected Data_WheelSuspension dataWheelsuspension;
    [SerializeField]
    [Header("Runtime Variables Below here - Do not change")]
    private bool autoSpringDamperSet;
    [SerializeField]
    private float spring;
    [SerializeField]
    private float damper;
    [SerializeField]
    private float damperFudge;
    [SerializeField]
    private float boost;
    [SerializeField]
    private float vesselMass;
    private Transform _suspensionTransform;
    public float suspCompression;
    public float sprungMassGravity;
    public bool sprungMassEasing;
    private Collider _suspensionCollider;
    [SerializeField]
    private bool highGeeOverride;
    [SerializeField]
    private float springClampMax;
    [SerializeField]
    private float damperClampMax;
    [SerializeField]
    private float damperLerpBase;
    [SerializeField]
    private float oscillationDamper;
    [SerializeField]
    private float boostClamp;
    [SerializeField]
    private float autoBoostClamp;
    [SerializeField]
    private bool debugSuspension;
    private Module_Deployable _deployableSubmodule;
    private Data_Deployable _dataDeployable;
    private Vector3 _suspensionPosition;
    private bool _deploymentStateChanging;

    public override System.Type PartComponentModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool HighGeeOverride
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void AddDataModules() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnInitialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetSuspensionState(bool newState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetSuspensionStateOn() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetSuspensionStateOff() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupVesselMassBalancer() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnShutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDeploymentStateChanged(bool state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselPartCountChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnWheelSetup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnAutoSpringDamperChanged(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnModuleFixedUpdate(float fixedDeltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnLateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float BoostCurve(float b, float power) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SuspensionSpringUpdate(float sprungMass) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void UpdateAutoBoost(float st) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnSubsystemsModified(WheelSubsystems s) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void ResetSuspensionCollider(float delay) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Module_WheelSuspension() => throw null;
  }
}
