// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.Planets.CreateQuadStatesJob
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;

namespace KSP.Rendering.Planets
{
  [BurstCompile(CompileSynchronously = true)]
  public struct CreateQuadStatesJob : IJob
  {
    [ReadOnly]
    public NativeArray<int> addedQuads;
    [ReadOnly]
    public NativeArray<int> changedEdges;
    [ReadOnly]
    public NativeArray<int> changedSubdiv;
    [ReadOnly]
    public NativeArray<int> changedCollapsed;
    public NativeArray<QuadState> QuadStates;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Execute() => throw null;
  }
}
