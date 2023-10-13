// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Module_Parachute
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Sim.Definitions;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.Modules
{
  [DisallowMultipleComponent]
  [RequireComponent(typeof (Module_Drag))]
  public class Module_Parachute : PartBehaviourModule, IMultipleDragCube, ILateUpdate
  {
    [SerializeField]
    [FormerlySerializedAs("data")]
    protected Data_Parachute dataParachute;
    public Animator animator;
    public string isOpenAnimTreeName;
    public string isDeployedAnimTreeName;
    public double invThermalMass;
    public double convectivekW;
    public double shockTemp;
    public int symmetryCount;
    public Quaternion lastRot;
    private bool _animationIsStarted;
    private float _deployTimer;
    private float _deployTimerNormalized;
    private Transform _canopyBoneTransform;
    private Data_Drag _dataDrag;
    private FXGroup _deployFx;
    private bool _fullDeploymentComplete;
    private Quaternion _currentCanopyRotation;
    private Transform _canopyMeshTransform;
    private double _finalTemp;
    private double _convectionArea;
    private double _machHeatMult;
    private bool _safetyBeDamned;
    private KSPPartAudioManager _kspPartAudioManager;
    private ModuleAction _actionDeployNow;
    private ModuleAction _actionCut;
    private ModuleAction _actionRepack;
    private ModuleAction _actionStageActivate;
    private static readonly int FPartialDeploySpeedMul;
    private static readonly int FPartialToFullDeploySpeedMul;
    private static readonly int FTurbulenceSpeedMul;

    public override System.Type PartComponentModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsMultipleCubesActive
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string[] GetDragCubeNames() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AssumeDragCubePosition(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool UsesProceduralDragCubes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void AddDataModules() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string GetModuleDisplayName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnInitialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDeploymentModeChanged(Data_Parachute.DeployMode newMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDeployStateChanged(Data_Parachute.DeploymentStates newState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdatePAMControlVisibility() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnIsDeploySettingsShownChanged(bool showSettings) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void InitProperties() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnAwake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private new void OnStart() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnShutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnLateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnModuleFixedUpdate(float fixedDeltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PlayDeployFX() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool ShouldDeployWhenArmed(
      double altitudeAboveGround,
      Vector3d velocityInAtmospherePhysicsSpace)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnArmedToggleChanged(bool armedValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetArmedStateOn() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetArmedStateOff() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetArmedState(bool state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ArmChute() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DeployNow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CutParachute() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Repack() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void PlayDeployAnimation(bool isOpen) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void PlayCloseAnimation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void PlayCutTransition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void UpdateCut() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double MaxSafeVelocityAtLocalBody() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void SetConvectiveStats(
      double density,
      double extTemp,
      double mach,
      double convCoeff)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void UpdateDeploySafety() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetDragCubes_Stowed() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetDragCube_SemiDeployed(float semiDeployed) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetDragCube_Deployed(float deployed) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Module_Parachute() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static Module_Parachute() => throw null;
  }
}
