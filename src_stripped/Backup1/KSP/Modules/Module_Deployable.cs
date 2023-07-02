// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Module_Deployable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Sim;
using KSP.Sim.Definitions;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  [RequireComponent(typeof (Module_Drag))]
  public class Module_Deployable : PartBehaviourModule, IMultipleDragCube, ILateUpdate
  {
    public const string DRAGCUBE_PACKED_NAME = "PACKED";
    public const string DRAGCUBE_RETRACTED_NAME = "RETRACTED";
    public const string DRAGCUBE_EXTENDED_NAME = "EXTENDED";
    public const float EPSILON = 1E-05f;
    public static readonly string[] DefaultDragCubeNames;
    private static readonly int DISABLE_CLIMB_INTERACT_CONTEXT;
    [SerializeField]
    protected Data_Deployable dataDeployable;
    public Animator animator;
    public Transform panelRotationTransform;
    public Transform secondaryTransform;
    public bool hasPivot;
    public CelestialFrame trackingBody;
    public ITransformModel trackingTransform;
    public string[] dragCubeNames;
    private float _speedMultiplier;
    private Quaternion _startingRotWhenReturningToOrigin;
    private AnimatorStateInfo _animatorStateInfo;
    private float _currentAnimNormalizedTime;
    private Data_Drag _dataDrag;
    protected bool _trackingLOS;
    protected string _blockingObject;
    private Transform _originalRotationTransform;
    private ClimbInstance _ladderClimbInstance;
    private InteractInstance _ladderInteractInstance;
    protected bool _actionPendingCompletion;
    private bool _actionAvailable;
    private bool _unavailableState;
    private float _workingDeployLimit;
    private float _lerpStep;
    private bool _isAtTargetDeployLimit;
    protected ModuleAction _actionExtend;
    private bool _hasAnimatorDeployLimit;

    public override System.Type PartComponentModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsMultipleCubesActive
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float CurrentAnimNormalizedTime
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
    protected void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnShutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnInitializeDrag() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void OnInitializeVisuals() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeAnimatorReferences() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnModuleFixedUpdate(float fixedDeltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnModuleOABFixedUpdate(float fixedDeltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void UpdateDeployment(float fixedDeltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void UpdateAerodynamics() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateAnimationForDeployLimitDrag(float fixedDeltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Quaternion GetPanelRotationForDragCubes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnLateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void UpdateDeployStateToFullStop() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCurrentDeployStateChanged(Data_Deployable.DeployState obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetPartProperties() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnToggleExtendChanged(bool newToggleExtendValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDeployLimitChanged(float newLimit) => throw null;

    [ContextMenu("Extend")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual bool Extend() => throw null;

    [ContextMenu("Retract")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual bool Retract() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual bool HasTrackerReturnedToOrigin(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnAnimStateEnter(Animator animator, int stateMachinePathHash) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void GetTrackingBodyTransformFrame() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDeployActionAvailability(bool available, bool notify = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool CalculateTrackingLOS(Vector3 trackingDirection, ref string blocker) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void PostCalculateTracking(bool trackingLOS, Vector3 trackingDirection) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void CalculateTracking(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string[] GetDragCubeNames() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AssumeDragCubePosition(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool UsesProceduralDragCubes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetDragCubes(float retracted) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetDragCubes(float retracted, Quaternion rotation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FetchLadderClimbAndInteractInstances() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateLadderClimbAndInteractEnabled() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetExtendState(bool newState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetExtendStateOn() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetExtendStateOff() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdatePAMControlVisibility() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdatePAMLabels() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Module_Deployable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static Module_Deployable() => throw null;
  }
}
