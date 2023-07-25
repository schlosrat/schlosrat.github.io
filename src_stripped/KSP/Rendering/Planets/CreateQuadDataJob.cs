// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.Planets.CreateQuadDataJob
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

namespace KSP.Rendering.Planets
{
  [BurstCompile(CompileSynchronously = true)]
  public struct CreateQuadDataJob : IJobParallelFor
  {
    [ReadOnly]
    public NativeArray<PQJob.PQ> PQs;
    public NativeArray<QuadDataGPU> AllQuadDataList;
    public int VertexCount;
    public int UniversalVertexCount;
    public Vector3 PqsPosition;
    public Vector3 CameraPosition;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Execute(int index) => throw null;
  }
}
