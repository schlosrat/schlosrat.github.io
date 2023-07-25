// Decompiled with JetBrains decompiler
// Type: KSP.Utilities.SpatialBubbleDatabaseNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Utilities
{
  public class SpatialBubbleDatabaseNode
  {
    public SpatialBubbleDatabase Owner;
    public Vector3 PositionUnitySpace;
    public float RadiusSqr;
    public int Depth;
    private ISpatialDatabaseNode OwningNode;
    private List<SpatialBubbleDatabaseNode> ChildNodes;

    public bool IsLeaf
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryAddNode(ISpatialDatabaseNode node) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SpatialBubbleDatabaseNode GetChildNodeContaining(ISpatialDatabaseNode node) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(ISpatialDatabaseNode node) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool RemoveNode(ISpatialDatabaseNode node) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CollectNodes(ref List<SpatialBubbleDatabaseNode> nodes, bool all) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SpatialBubbleDatabaseNode() => throw null;
  }
}
