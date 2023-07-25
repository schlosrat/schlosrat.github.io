// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.SplatMapRuleJob
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace AwesomeTechnologies.VegetationSystem
{
  [BurstCompile(CompileSynchronously = true)]
  public struct SplatMapRuleJob : IJobParallelForDefer
  {
    public NativeArray<byte> Excluded;
    public NativeArray<byte> TerrainTextureData;
    public NativeArray<float3> Position;
    [ReadOnly]
    public NativeArray<ARGBBytes> SplatMapArray;
    public float MinValue;
    public float MaxValue;
    public int SplatmapIndex;
    public int Width;
    public int Height;
    public float3 TerrainPosition;
    public float2 SplatCellSize;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Execute(int index) => throw null;
  }
}
