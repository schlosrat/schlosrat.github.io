// Decompiled with JetBrains decompiler
// Type: KSP.Map.Map3DSpaceProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.impl;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.Map
{
  [Serializable]
  public class Map3DSpaceProvider
  {
    [FormerlySerializedAs("Map3DScaleInv")]
    [SerializeField]
    [Tooltip("This is an inverse value. Consider what you see here to be 1 / <what you specify for this>. Bigger # = smaller map.")]
    private double _map3DScaleInv;
    [FormerlySerializedAs("CelestialBodyScalar")]
    [Tooltip("scales all celestial body objects. This number should probably come from somewhere more defined.")]
    [SerializeField]
    private double _celestialBodyScalar;
    [Tooltip("the camera pivot is required To allow forced resetting when the map selection changes.")]
    [SerializeField]
    private Transform mapCamPivot;
    private List<Map3DFocusItem> selectableItemsWithSimInfo;
    private TransformModel defaultParent;
    private TransformModel origin;
    private TransformModel mapCamera3DInActualModel;
    private ITransformModel _originTarget;
    private ITransformFrame _originParentFrame;

    public double Map3DScaleInv
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMap3DScaleInv(double scaleInv) => throw null;

    public double CelestialBodyScalar
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMapCelestialBodyScalar(double celestialBodyScalar) => throw null;

    public Transform UnityTransformRoot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] protected set => throw null;
    }

    public Matrix4x4 MapLocalToWorldMatrix
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public TransformModel CameraModel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Map3DSpaceProvider() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateMapSelectable(Map3DFocusItem item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d TranslateSimPositionToMapPosition(Position toTransform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateTransformPosOnly(Transform mapItem, TransformModel actualData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateTransformRotationOnly(Transform mapItem, TransformModel actualData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateTargetTransform(Transform target, TransformModel targetModel, double? scale) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    private Matrix4x4D Get3DMapLocalToMapPosRotMatrix(ITransformFrame transformFrame) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public Matrix4x4D Get3DMapLocalToWorldPosRotMatrix(ITransformFrame transformFrame) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateRegisteredItems() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterMapItem(Map3DFocusItem mapItem) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnregisterMapItem(Map3DFocusItem mapItem) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearRegisteredItems() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    private void SetTransformModelOrigin(ITransformModel target) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateOriginPosition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetOrigin(Map3DFocusItem target) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetTransformRoot(Transform transformRoot) => throw null;
  }
}
