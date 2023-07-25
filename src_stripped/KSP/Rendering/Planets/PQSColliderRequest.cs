// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.Planets.PQSColliderRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Rendering;

namespace KSP.Rendering.Planets
{
  public class PQSColliderRequest
  {
    public readonly ComputeBuffer ColliderVerticesBuffer;
    public NativeList<QuadDataGPU> QuadDataList;
    public NativeArray<Vector3> ColliderVertices;
    public AsyncGPUReadbackRequest ReadbackRequest;
    public int QuadCount;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PQSColliderRequest(int quadCount, int bufferSize, int dataSize) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;
  }
}
