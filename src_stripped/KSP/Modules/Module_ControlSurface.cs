// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Module_ControlSurface
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Messages;
using KSP.OAB;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  [DisallowMultipleComponent]
  public class Module_ControlSurface : Module_LiftingSurface, ITorqueProvider
  {
    [SerializeField]
    protected Data_ControlSurface dataCtrlSurface;
    protected static readonly string ControlSurfaceAttributeName;
    private Module_ProceduralPart _moduleProceduralPart;
    private Data_ProceduralPart _dataProceduralPart;
    private DragCubeGenerator _dragCubeGenerator;
    private Module_Drag _moduleDrag;
    private Data_Drag _dataDrag;
    private Data_LiftingSurface.DragForce _ctrlSurfaceDragForce;
    private Data_LiftingSurface.LiftForce _ctrlSurfaceLiftForce;
    [SerializeField]
    protected Transform _ctrlSurface;
    protected Quaternion _neutral;
    protected Vector3 _inputVector;
    protected float _action;
    protected float _deflection;
    protected float _roll;
    public float _deflectionDirection;
    protected float _currentDeployAngle;
    protected Transform vesselRef;
    protected Vector3 _rotationVector;
    protected Data_LiftingSurface.TransformDir _forwardDirection;
    [SerializeField]
    protected Transform _referenceXform;
    protected float upRefSignDot;
    protected float _rotationAxesSignDot;
    private const float _epsilon = 1E-06f;
    private Vector3 _nVel;

    public override System.Type PartComponentModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsProceduralPart
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
    protected void MeshDataChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnControlPointChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ControlOwnerChanged(MessageCenterMessage msg) => throw null;

    [ContextMenu("Reset Positional References")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetPositionalReferences() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetMeshArea(
      GameObject gameObj,
      Data_LiftingSurface.TransformDir liftDir,
      float liftDirection,
      out Vector3 localCenter)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Bounds CalculateLocalBounds(
      GameObject part,
      out MeshFilter[] rs,
      MeshFilter[] excludedMeshes = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Bounds CalculateGlobalBounds(GameObject part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3 LiftVectorCalc(Data_LiftingSurface.TransformDir liftDir, float liftDirection) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnModuleFixedUpdate(float fixedDeltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void CtrlSurfaceUpdate(Vector3 vel, float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnCenterOfLiftQuery(ObjectAssemblyCOPressureQuery qry) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetControlSurfaceDeployState(bool newState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetControlSurfaceDeployStateOn() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetControlSurfaceDeployStateOff() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetControlSurfaceInvertControlState(bool newState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetControlSurfacePitchState(bool newState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetControlSurfaceYawState(bool newState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetControlSurfaceRollState(bool newState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnIsAdvancedSettingsShownChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void UpdatePAMControlVisibility() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetPotentialLift(bool positiveDeflection) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetPotentialTorque(out Vector3 pos, out Vector3 neg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Module_ControlSurface() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static Module_ControlSurface() => throw null;
  }
}
