// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ConnectionGraphNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
