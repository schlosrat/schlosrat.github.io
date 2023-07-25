// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.MeshTerrains.BVHTerrainCellSampleJob
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

namespace AwesomeTechnologies.MeshTerrains
{
  [BurstCompile(CompileSynchronously = true)]
  public struct BVHTerrainCellSampleJob : IJobParallelFor
  {
    public NativeArray<Bounds> VegetationCellBoundsList;
    public Rect TerrainRect;
    public float TerrainMinHeight;
    public float TerrainMaxHeight;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Execute(int index) => throw null;
  }
}
