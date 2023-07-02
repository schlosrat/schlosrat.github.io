// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.VegetationStudioCamera
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using AwesomeTechnologies.Utility.Culling;
using AwesomeTechnologies.VegetationStudio;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Jobs;
using UnityEngine;

namespace AwesomeTechnologies.VegetationSystem
{
  [Serializable]
  public class VegetationStudioCamera
  {
    public const int VEGETATION_GRID = 0;
    public const int BILLBOARD_GRID = 1;
    public const int HERO_GRID = 2;
    [NonSerialized]
    public CameraGrid[] CameraGrids;
    private const float DEFAULT_CELL_PADDING = 100f;
    private static readonly Vector3 DEFAULT_CENTER_POSITION;
    [SerializeField]
    public Camera SelectedCamera;
    public VegetationStudioCameraType VegetationStudioCameraType;
    public Transform TargetTransform;
    public VegetationStudioCamera.MultiOnVegetationCellVisibityChangedDelegate OnVegetationCellVisibleDelegate;
    public VegetationStudioCamera.MultiOnVegetationCellVisibityChangedDelegate OnVegetationCellInvisibleDelegate;
    public VegetationStudioCamera.MultiOnVegetationCellVisibityChangedDelegate OnPotentialCellInvisibleDelegate;
    public VegetationStudioCamera.MultiOnVegetationDistanceBandChangeDelegate OnVegetationCellDistanceBandChangeDelegate;
    public bool RenderDirectToCamera;
    public bool RenderBillboardsOnly;
    public CameraCullingMode CameraCullingMode;
    public VegetationSystemPro VegetationSystemPro;
    public QualityManager QualityManager;
    private bool _dirty;
    [NonSerialized]
    public Rect CurrentPotentialBillboardArea;
    private Vector3 _floatingOriginOffset;
    public GameObject WindSampler;
    private JobHandle _currentJobHandle;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EnsureCameraGrids() => throw null;

    public JobCullingGroup JobCullingGroup
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public JobCullingGroup BillboardJobCullingGroup
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public JobCullingGroup HeroJobCullingGroup
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public List<VegetationCell> PotentialVisibleVegetationCellList
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public List<VegetationCell> PotentialVisibleBillboardCellList
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public List<VegetationCell> PotentialVisibleHeroCellList
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool Enabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsEnabled() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VegetationStudioCamera(Camera selectedCamera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3 GetCameraPosition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetFloatingOriginOffset(Vector3 floatingOriginOffset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VegetationStudioCamera(
      VegetationStudioCameraType vegetationStudioCameraType)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VegetationStudioCamera(Transform transform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnChangedSceneViewCameraDelegate(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDirty() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PreCullVegetation(bool forceUpdate) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public JobHandle ScheduleCullVegetationJob(JobHandle dependsOn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ProcessEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdatePotentialVisibleCellsForGrid(
      bool forceUpdate,
      int gridIndexTemp,
      ref CameraGrid cameraGrid,
      float cellSize,
      float cellDrawDistance)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdatePotentialVisibleCells(bool forceUpdate) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateCullingGroup(int gridIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateCullingGroupWorker(ref CameraGrid cameraGrid, float distanceBand) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateBillboardCullingGroup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnStateChanged(JobCullingGroupEvent sphere) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDistanceBandStateChanged(JobCullingGroupEvent sphere) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveDelegates() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DrawVisibleCellGizmos(Color color, ref CameraGrid cameraGrid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DrawVisibleCellGizmos() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DrawVisibleBillboardCellGizmos() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DrawVisibleHeroCellGizmos() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static VegetationStudioCamera() => throw null;

    public delegate void MultiOnVegetationCellVisibityChangedDelegate(
      VegetationStudioCamera vegetationStudioCamera,
      VegetationCell vegetationCell);

    public delegate void MultiOnVegetationDistanceBandChangeDelegate(
      VegetationStudioCamera vegetationStudioCamera,
      VegetationCell vegetationCell,
      int distanceBand,
      int previousDistanceBand);
  }
}
