// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.CameraComputeBuffers
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.VegetationSystem
{
  public class CameraComputeBuffers
  {
    public const int MAX_SCATTER_LODS = 4;
    public readonly ComputeBuffer[] VisibleBuffers;
    public readonly ComputeBuffer[] ShadowBuffers;
    private ComputeBuffer dummyRenderAppendBuffer;
    private readonly uint[] _args;
    public readonly List<ComputeBuffer>[] ArgsBuffers;
    public readonly List<ComputeBuffer>[] ShadowArgsBuffers;
    private readonly uint[] _billboardArgs;
    public ComputeBuffer BillboardMergeBuffer;
    public ComputeBuffer BillboardArgsBuffer;
    public const int DefaultComputeBufferSize = 5000;
    private const int BillboardMergeBufferItemSize = 80;
    private const int MeshInstanceBufferItemSize = 144;
    private const int COMPUTE_BUFFER_PADDING = 5000;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CreateBillboardBuffers(Mesh billboardMesh) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DisposeBillboardBuffers() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraComputeBuffers(
      Mesh vegetationMeshLod0,
      Mesh vegetationMeshLod1,
      Mesh vegetationMeshLod2,
      Mesh vegetationMeshLod3)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateBillboardComputeBufferSize(int newInstanceCount) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EnsureRenderBuffersAreLargeEnough(
      int maxPossibleItemsInFrustum,
      int totalInstanceCount,
      bool useShadowBuffers,
      int lodCount)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetAppendBufferCounters() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ComputeBuffer GetVisibleBufferForLOD(int lod) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ComputeBuffer GetShadowBufferForLOD(int lod) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DestroyComputeBuffers(ComputeBuffer[] bufferArray) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DestroyComputeBuffers() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ReleaseArgsBuffers() => throw null;
  }
}
