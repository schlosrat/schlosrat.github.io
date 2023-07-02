// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Module_RCS
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using KSP.VFX;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.Modules
{
  [DisallowMultipleComponent]
  public class Module_RCS : PartBehaviourModule, ITorqueProvider
  {
    [FormerlySerializedAs("data")]
    [SerializeField]
    protected Data_RCS dataRCS;
    public Transform[] ThrusterTransforms;
    public RCSVFXManager rcsVFXManager;
    [HideInInspector]
    public List<RCSForce> thrustForces;
    public bool requiresFuel;
    public float precisionFactor;
    public float thrustCurveDisplay;
    public float thrustCurveRatio;
    private float EPSILON;
    public float realISP;
    private float leverDistance;
    private Vector3 inputRot;
    private Vector3 inputLin;
    private Vector3 rot;
    private bool usePrecision;
    public bool flameout;
    private double exhaustVel;
    public double maxFuelFlow;
    public double flowMult;
    public double ispMult;
    private float currentThrustForce;
    private float totalThrustForce;
    private Transform currentThruster;
    public bool isOperational;
    private KSPPartAudioManager _kspPartAudioManager;
    private bool _rcsAudioState;

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
    protected override void OnShutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnModuleFixedUpdate(float fixedDeltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnModuleUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnModuleOABFixedUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void InitProperties() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double GetMaxFuelFlow(float Isp) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessInputs() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessThrust() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float CalculateThrust(float totalForce, out bool success) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RequestPropellant(double mass) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSFXState(bool state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetPotentialTorque(out Vector3 pos, out Vector3 neg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetLeverDistance(Vector3 origin, Vector3 axis, Vector3 leverPivotPosition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetRCSState(bool newState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetRCSStateOn() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetRCSStateOff() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetRCSPitchState(bool newState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetRCSYawState(bool newState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetRCSRollState(bool newState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetRCSXState(bool newState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetRCSYState(bool newState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetRCSZState(bool newState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetRCSMainThrottleState(bool newState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetRCSFullThrottleState(bool newState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnIsAdvancedSettingsShownChanged(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdatePAMControlVisibility() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Module_RCS() => throw null;
  }
}
