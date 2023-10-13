// Decompiled with JetBrains decompiler
// Type: KSP.Sim.GetConnectedNodesJob
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
