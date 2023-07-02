// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.CameraComputeBuffers
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;

namespace AwesomeTechnologies.VegetationSystem
{
  public class CameraComputeBuffers
  {
    public const int MAX_SCATTER_LODS = 4;
    public readonly GraphicsBuffer[] VisibleBuffers;
    public readonly GraphicsBuffer[] ShadowBuffers;
    private GraphicsBuffer dummyRenderAppendBuffer;
    private readonly uint[] _args;
    public readonly List<GraphicsBuffer>[] ArgsBuffers;
    public readonly List<GraphicsBuffer>[] ShadowArgsBuffers;
    private readonly uint[] _billboardArgs;
    public GraphicsBuffer BillboardMergeBuffer;
    public GraphicsBuffer BillboardArgsBuffer;
    private const int NORENDER_CLEANUP_FRAME_COUNT = 60;
    public int FramesSinceLastRendered;
    public int FramesSinceLastRenderedBillboard;
    public const int DefaultComputeBufferSize = 5000;
    private static readonly int BillboardMergeBufferItemSize;
    private static readonly int MeshInstanceBufferItemSize;
    private const int COMPUTE_BUFFER_PADDING = 5000;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MaybeCleanUpIfNoRenderThisFrame(bool anythingRendered) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MaybeCleanupIfNoRenderBillboardThisFrame(bool anythingRendered) => throw null;

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
    public void EnsureBillboardBufferLargeEnough(int requiredCount) => throw null;

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
    public GraphicsBuffer GetVisibleBufferForLOD(int lod) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GraphicsBuffer GetShadowBufferForLOD(int lod) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DestroyComputeBuffers(GraphicsBuffer[] bufferArray) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DestroyComputeBuffers() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ReleaseArgsBuffers() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static CameraComputeBuffers() => throw null;

    private struct ScatterRenderInstanceData
    {
      private float4x4 PositionMatrix;
      private float4 LODFadeInfo;
    }

    private struct BillboardRenderInstanceData
    {
      private float4x4 PositionMatrix;
      private float4 LODFadeInfo;
    }
  }
}
