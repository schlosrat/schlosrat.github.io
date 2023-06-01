// Decompiled with JetBrains decompiler
// Type: KSP.VFX.FXInstanceAggregator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.Utilities;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.VFX
{
  public class FXInstanceAggregator
  {
    public Dictionary<string, AggregationSet> InstanceSets;

    public GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ContextualFxSystem CFXSystem
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsAggregatable(FXContextualEvent fxevent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetSetKey(FXContextualEvent fxevent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryAddNode(FXContextualEvent fxevent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveNode(FXContextualEvent fxevent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CollectEvents(ref List<SpatialBubbleDatabaseNode> nodes, bool all) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FXInstanceAggregator() => throw null;
  }
}
