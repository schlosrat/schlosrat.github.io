// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.Planets.CreateQuadStatesJob
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
