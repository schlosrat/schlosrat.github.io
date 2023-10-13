// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ConnectionGraphNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Sim.impl;
using System.Runtime.CompilerServices;
using Unity.Mathematics;

namespace KSP.Sim
{
  public class ConnectionGraphNode
  {
    public IGGuid Owner;
    public double3 Position;
    public double MaxRange;
    public bool IsActive;
    public bool IsControlSource;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ConnectionGraphNode() => throw null;
  }
}
