// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ResourceSystem.Edge
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Sim.ResourceSystem
{
  public class Edge : IFlowEdge
  {
    public bool IsStructureBoundary
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool CanBeFlowSearched
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool IsCrossfeedEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool IsCompoundConnection
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Edge() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Edge NewAttachment(bool crossfeedEnabled = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Edge NewDecoupler(bool crossfeedEnabled = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Edge NewFuelLine(bool crossfeedEnabled = true, bool isCompoundConnection = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Edge NewStrut() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString() => throw null;
  }
}
