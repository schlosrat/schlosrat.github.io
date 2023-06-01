// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Module_WheelSteering
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.impl;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  [DisallowMultipleComponent]
  public class Module_WheelSteering : Module_WheelSubmodule
  {
    [SerializeField]
    protected Data_WheelSteering dataWheelSteering;
    [Header("Runtime Variables Below here - Do not change")]
    public Transform caliperTransform;
    public float steeringInput;
    public float steeringInputLast;
    public float steerAngle;
    public float steerRange;
    private bool _caliperUpdating;
    private Quaternion _caliperRot0;
    private Vector3 _upAxis;
    private Vector3 _fwdAxis;
    private Vector3 _leftAxis;
    private Vector3 _CoM;
    private Vector3 _wCenter;
    private Vector3 _wLeft0;
    private Vector3 _wLeft;
    private Vector3 _wRight;
    private Vector3 _wAxis;
    private Vector3 _sAxis;
    private float _CoMfwdLength;
    private bool _steeringAngleCurveDefined;
    private bool _steeringCurveDefined;
    private Vector2 _prevLocalWheelVelocity;
    private Vector3 updateCoordFrameReferenceForward;
    public Vector3 tPivot;
    public Vector3 tOrt;
    public Vector3 tCenter;
    public float h;

    public override System.Type PartComponentModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void ActionSteeringAdjustUIUpdate(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void AddDataModules() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnInitialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetSteeringState(bool newState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetSteeringStateOn() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetSteeringStateOff() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetSteeringStateInverted(bool newState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnShutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnWheelSetup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnModuleFixedUpdate(float fixedDeltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected float GetSteeringResponseScale(float steerDelta) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateCoordFrame() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float UpdateSteering(float input, float steeringRange) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float FindCoMfwdLength(Vector3 vesselCoM, Vector3 wheelCenter, Vector3 fwdAxis) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetCoMFwdLength() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3 FindTurnCenter(float steerAngle, float length, Vector3 CoM) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetSteeringTweakablesSliders() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnSubsystemsModified(WheelSubsystems s) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetCaliperUpdate(bool update) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResetCaliper(bool resetTransform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnWheelRepaired(PartBehavior p) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Module_WheelSteering() => throw null;
  }
}
