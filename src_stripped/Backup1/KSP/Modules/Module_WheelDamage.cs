// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Module_WheelDamage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Messages;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  [DisallowMultipleComponent]
  public class Module_WheelDamage : Module_WheelSubmodule
  {
    [SerializeField]
    protected Data_WheelDamage dataWheelDamage;
    [Header("Runtime Variables Below here - Do not change")]
    public float currentDeflection;
    public float lastDeflection;
    public float currentSlip;
    public float lastSlip;
    public float currentDownForce;
    public float lastDownForce;
    public bool initialized;
    public float totalStress;
    public float stressVariability;
    private const float _repairImmunityMin = 30f;
    private const float _repairImmunityMax = 90f;
    private float _repairImmunityTimeTotal;
    private float _repairImmunityTimeLeft;
    internal float _startupTime;
    private float _stressTime;
    private Transform _dmgTransform;
    private Transform _undmgTransform;
    private WheelSubsystem _subsystemDamage;
    private SubscriptionHandle _handleDocked;
    private SubscriptionHandle _handleUndocked;
    private Collider impactDamageCollider;

    public override System.Type PartComponentModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void AddDataModules() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnInitialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GetDamageTransforms(bool logError) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnShutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDockingComplete(MessageCenterMessage curMCM) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void ResetImmunity() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnWheelSetup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnModuleFixedUpdate(float fixedDeltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDamaged(bool damaged) => throw null;

    [ContextMenu("Damage Wheel")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DamageWheel() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HandleCollision(Collision c) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HandleCollisionVelocity(
      Collision c,
      GameObject otherObject,
      Vector3 velocity,
      Vector3 normal)
    {
      throw null;
    }

    public bool IsImpactDamageEnable
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Module_WheelDamage() => throw null;
  }
}
