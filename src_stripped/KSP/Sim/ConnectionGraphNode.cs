// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ConnectionGraphNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
