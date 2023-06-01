// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Module_Drag
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api;
using KSP.Messages;
using KSP.Sim;
using KSP.Sim.Definitions;
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.Modules
{
  [DisallowMultipleComponent]
  public class Module_Drag : PartBehaviourModule
  {
    public const float MINIMUM_VELOCITY_TO_UPDATE_AREA_PROPERTY = 0.05f;
    private const float KILOGRAM_TO_METRIC_TON = 0.001f;
    internal const float NEXT_NEIGHBOR_DEPTH_THRESHOLD = 1f;
    internal static readonly Vector3[] FaceDirections;
    private static bool _showDragDebug;
    [FormerlySerializedAs("data")]
    [SerializeField]
    protected Data_Drag dataDrag;
    private SubscriptionHandle _handlePartDestroyed;
    private SubscriptionHandle _handlePartDetached;
    private CorePartData _corePartData;
    private Data_LiftingSurface _liftingSurfaceData;
    private Data_Drag.DragForce _dragForce;
    private Data_Drag.BodyLiftForce _bodyLiftForce;
    public float bodyLiftScalar;
    public float dragScalar;
    private DragCubeGenerator _dragCubeGenerator;
    private Transform _partTransform;
    private Vector3 _partVelocityUnitVectorPartCoords;
    private bool _isAeroActive;
    private Transform _modelTransform;

    public override System.Type PartComponentModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static bool ShowDragDebug
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public static event Action OnDebugChanged
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearAndAddDragCube(DragCube cube) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnStart() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnShutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void AddDataModules() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnInitialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ToggleDragDebugStrings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnModuleFixedUpdate(float fixedDeltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDragCube() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCompleteDragCubeCalculation(DragCube cube) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateModuleProperties() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateCubeData(Vector3 partVelocityDirection) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateDrag(Vector3 partVelocityDirection) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateBodyLift(Vector3 partVelocityDirection) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPartDestroyed(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPartDetached(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EnableAero() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DisableAero() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator RecalculateExposedAreaCoroutine() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetMeshVolume(GameObject gameObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private DragCube GenerateCube(GameObject gameObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float GetCrossSectionalArea(Vector3 partVelocityUnitVector, float[] areaArray) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static float GetDepth(Vector3 partVelocityUnitVector, float[] depthArray) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetExposedArea() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool AttachNodeHasStackAttachedPart(AttachNodeData attachNode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3 GetNodeOrientationInAttachCoords(
      AttachNodeData attachNode,
      ICoordinateSystem partCoordinateSystem)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetDisableAerodynamics() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string GetModuleDisplayName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Module_Drag() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static Module_Drag() => throw null;
  }
}
