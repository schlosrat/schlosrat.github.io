// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Utility.Culling.BoundingSphereCullJob
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

namespace AwesomeTechnologies.Utility.Culling
{
  [BurstCompile(CompileSynchronously = true)]
  internal struct BoundingSphereCullJob : IJobParallelFor
  {
    public NativeArray<BoundingSphereInfo> BoundingSphereInfoList;
    [ReadOnly]
    public NativeList<float> DistancesList;
    [ReadOnly]
    public NativeArray<Plane> FrustumPlanes;
    public Vector3 DistanceReferencePoint;
    public bool NoFrustumCulling;
    public bool AddShadowCells;
    public Vector3 FloatingOriginOffset;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Execute(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int SphereInFrustum(BoundingSphere boundingSphere) => throw null;
  }
}
