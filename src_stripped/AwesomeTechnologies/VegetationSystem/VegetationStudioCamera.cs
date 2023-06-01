// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.VegetationStudioCamera
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
    [SerializeField]
    public Camera SelectedCamera;
    public VegetationStudioCameraType VegetationStudioCameraType;
    public Transform TargetTransform;
    public JobCullingGroup JobCullingGroup;
    public JobCullingGroup BillboardJobCullingGroup;
    public JobCullingGroup HeroJobCullingGroup;
    public VegetationStudioCamera.MultiOnVegetationCellVisibityChangedDelegate OnVegetationCellVisibleDelegate;
    public VegetationStudioCamera.MultiOnVegetationCellVisibityChangedDelegate OnVegetationCellInvisibleDelegate;
    public VegetationStudioCamera.MultiOnVegetationCellVisibityChangedDelegate OnPotentialCellInvisibleDelegate;
    public VegetationStudioCamera.MultiOnVegetationDistanceBandChangeDelegate OnVegetationCellDistanceBandChangeDelegate;
    public bool RenderDirectToCamera;
    public bool RenderBillboardsOnly;
    public CameraCullingMode CameraCullingMode;
    public VegetationSystemPro VegetationSystemPro;
    public QualityManager QualityManager;
    private Vector3 _potentialCellsCenterPosition;
    private Vector3 _potentialBillboardCellsCenterPosition;
    private Vector3 _potentialHeroCellsCenterPosition;
    private float _potentialVegetationCellPadding;
    private float _potentialBillboardCellPadding;
    private float _potentialHeroCellPadding;
    private float _lastVegetationCellDistance;
    private float _lastBillboardCellDistance;
    private float _lastHeroCellDistance;
    private bool _dirty;
    [NonSerialized]
    public Rect CurrentPotentialBillboardArea;
    private Vector3 _floatingOriginOffset;
    public GameObject WindSampler;
    private JobHandle _currentJobHandle;
    [NonSerialized]
    public List<AwesomeTechnologies.VegetationSystem.VegetationStudioCameraRenderList> VegetationStudioCameraRenderList;
    [NonSerialized]
    public List<VegetationCell> PotentialVisibleVegetationCellList;
    [NonSerialized]
    public List<VegetationCell> PotentialVisibleBillboardCellList;
    [NonSerialized]
    public List<VegetationCell> PotentialVisibleHeroCellList;

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
    public void PrepareRenderLists(List<VegetationPackagePro> vegetationSystemProList) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdatePotentialVisibleVegetationCells(bool forceUpdate) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdatePotentialVisibleHeroCells(bool forceUpdate) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdatePotentialVisibleBillboardCells(bool forceUpdate) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdatePotentialVisibleCells(bool forceUpdate) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateCullingGroup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateBillboardCullingGroup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateHeroCullingGroup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateHeroCullingGroup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateBillboardCullingGroup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateCullingGroup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BoundingSphereInfo GetBoundingSphereInfo(int potentialVisibleVegetationCellIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnStateChanged(JobCullingGroupEvent sphere) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDistanceBandStateChanged(JobCullingGroupEvent sphere) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnBillboardStateChanged(JobCullingGroupEvent sphere) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnBillboardDistanceBandStateChanged(JobCullingGroupEvent sphere) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnHeroStateChanged(JobCullingGroupEvent sphere) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnHeroDistanceBandStateChanged(JobCullingGroupEvent sphere) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DisposeVegetationStudioCameraRenderList() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool ValidateVegetationStudioCameraRenderList(
      List<VegetationPackagePro> vegetationPackageProList)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveDelegates() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DrawVisibleCellGizmos() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DrawVisibleBillboardCellGizmos() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DrawVisibleHeroCellGizmos() => throw null;

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
