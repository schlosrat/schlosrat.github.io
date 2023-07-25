// Decompiled with JetBrains decompiler
// Type: KSP.Utilities.SpatialBubbleDatabase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Utilities
{
  public class SpatialBubbleDatabase
  {
    public NodeCollisionBehavior CollisionBehavior;
    public List<float> NodeRadiiSqr;
    private SpatialBubbleDatabaseNode rootNode;
    public static Stack<SpatialBubbleDatabaseNode> _nodePool;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SpatialBubbleDatabase(NodeCollisionBehavior collisionBehavior, List<float> nodeRadiiSqr) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryAddNode(ISpatialDatabaseNode node) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveNode(ISpatialDatabaseNode node) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CollectNodes(ref List<SpatialBubbleDatabaseNode> nodes, bool all) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SpatialBubbleDatabaseNode AcquireNode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ReleaseNode(SpatialBubbleDatabaseNode node) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static SpatialBubbleDatabase() => throw null;
  }
}
