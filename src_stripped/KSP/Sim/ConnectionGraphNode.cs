// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ConnectionGraphNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
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
