// Decompiled with JetBrains decompiler
// Type: KSP.Sim.GetConnectedNodesJob
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
