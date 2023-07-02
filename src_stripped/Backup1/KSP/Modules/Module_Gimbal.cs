// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Module_Gimbal
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.Definitions;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.Modules
{
  [DisallowMultipleComponent]
  public class Module_Gimbal : PartBehaviourModule, ITorqueProvider
  {
    [SerializeField]
    [FormerlySerializedAs("data")]
    protected Data_Gimbal dataGimbal;
    private Transform _currentGimbalTransform;
    private Animator _animator;
    private Vector3 _actuationLocal;
    private Vector3 _actuation;
    public List<List<KeyValuePair<Module_Engine, float>>> _engineMultsList;
    private bool _isMoving;
    private List<Transform> gimbalTransforms;
    private List<ITransformModel> gimbalTransformsP;
    private List<Quaternion> initRotations;
    private Vector3[] oldActuationLocal;
    internal bool EngineThrustInvertGimbal;

    public override System.Type PartComponentModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void AddDataModules() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string GetModuleDisplayName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnInitialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnInitializeFlightItems() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnShutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnModuleFixedUpdate(float fixedDeltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateGimbalRotation(float fixedDeltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateGimbalAnimator() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetGimbalActuation(float pitch, float roll, float yaw) => throw null;

    public Vector3 GimbalActuation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetLocalActuation(Transform gimbalTransform, Vector3 PYR, Vector3 localCoM) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CreateEngineList() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetPotentialTorque(out Vector3 pos, out Vector3 neg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetGimbalState(bool newState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetGimbalStateOn() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetGimbalStateOff() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetGimbalPitchState(bool newState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetGimbalYawState(bool newState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetGimbalRollState(bool newState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnIsAdvancedSettingsShownChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdatePAMControlVisibility() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Module_Gimbal() => throw null;
  }
}
