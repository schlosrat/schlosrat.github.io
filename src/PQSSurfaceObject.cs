// Decompiled with JetBrains decompiler
// Type: PQSSurfaceObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api;
using KSP.Game;
using KSP.Rendering.Planets;
using KSP.Sim.impl;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

public class PQSSurfaceObject : KerbalMonoBehaviour
{
  [FormerlySerializedAs("latitude")]
  public double Latitude;
  [FormerlySerializedAs("longitude")]
  public double Longitude;
  [FormerlySerializedAs("repositionRadiusOffset")]
  public double RadialOffset;
  [FormerlySerializedAs("reorientFinalAngle")]
  [Range(-360f, 360f)]
  public float DegreesAroundRadialNormal;
  public bool CreateTransformModel;
  [FormerlySerializedAs("doCulling")]
  public bool ColliderCulling;
  [Tooltip("Distance in meters from Observer to disable colliders")]
  [FormerlySerializedAs("cullingDistance")]
  public float ColliderCullingDistance;
  [Tooltip("Optional Bounds for testing culling distances")]
  [FormerlySerializedAs("rendererForBoundsCulling")]
  public Renderer RendererForBoundsCulling;
  [Header("LODs")]
  public PQSSurfaceObject.LODGameObject[] GameObjectsToLOD;
  [Header("Debug")]
  [SerializeField]
  [HideInInspector]
  private CelestialBodyBehavior _celestialBody;
  [SerializeField]
  [HideInInspector]
  private PQS _sphere;
  [SerializeField]
  [HideInInspector]
  private bool _hasParentSurfaceObject;
  private bool _hasPositioned;
  private bool _areCollidersActive;
  private readonly List<Collider> _collidersToCull;

  public ICoordinateSystem coordinateSystem
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public Vector3d localPosition
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public QuaternionD localRotation
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDisable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void LateUpdate() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateCulling() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static void SetCollidersEnabled(List<Collider> colliders, bool isEnabled) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnSphereActivated(PQS sphere) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void PositionSurfaceObject() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OrientWithSurface() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void GetPositionRotationRelativeTo(
    Transform targetTransform,
    out Vector3d position,
    out QuaternionD rotation)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public PQSSurfaceObject() => throw null;

  [Serializable]
  public class LODGameObject
  {
    public GameObject GameObject;
    public double Distance;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LODGameObject() => throw null;
  }
}
