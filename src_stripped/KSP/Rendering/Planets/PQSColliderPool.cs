// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.Planets.PQSColliderPool
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Jobs;

namespace KSP.Rendering.Planets
{
  public class PQSColliderPool
  {
    private Mesh _colliderMesh;
    private Transform _colliderParent;
    private List<PQSCollider> _colliderList;
    private GameObject _colliderPrefab;
    private PQSGlobalSettings _pqsGlobalSettings;
    private TransformAccessArray _colliderTransforms;
    private NativeList<Vector3> _colliderOffsetPositions;
    private int _size;
    private int _index;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PQSColliderPool(
      Mesh colliderMesh,
      Transform colliderParent,
      int initialSize,
      PQSGlobalSettings pqsGlobalSettings)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PQSCollider GetPqsCollider(ref int index, Vector3 refPosition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PQSCollider PeekPqsCollider(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ReturnPqsCollider(PQSCollider pqsCollider) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ReturnPqsCollider(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateColliderPositions(Transform refTransform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private PQSCollider CreatePqsCollider() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private GameObject CreateColliderObject() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private MeshCollider CreateCollider(GameObject objRef) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool UpdatePoolIndex() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateColliderData(PQS Pqs, BiomePhysicsMapping mappingTable) => throw null;
  }
}
