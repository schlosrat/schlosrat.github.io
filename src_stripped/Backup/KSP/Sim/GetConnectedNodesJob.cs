// Decompiled with JetBrains decompiler
// Type: KSP.Sim.GetConnectedNodesJob
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Jobs;

namespace KSP.Sim
{
  public struct GetConnectedNodesJob : IJob
  {
    [ReadOnly]
    public int StartIndex;
    [ReadOnly]
    public NativeArray<ConnectionGraph.ConnectionGraphJobNode> Nodes;
    [WriteOnly]
    public NativeArray<int> PrevIndices;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Execute() => throw null;
  }
}
