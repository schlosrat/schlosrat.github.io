// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.RaycastTerranCellSampleJob
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

namespace AwesomeTechnologies.VegetationSystem
{
  [BurstCompile(CompileSynchronously = true)]
  public struct RaycastTerranCellSampleJob : IJobParallelFor
  {
    public NativeArray<Bounds> VegetationCellBoundsList;
    public Rect TerrainRect;
    public float TerrainMinHeight;
    public float TerrainMaxHeight;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Execute(int index) => throw null;
  }
}
