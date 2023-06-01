// Decompiled with JetBrains decompiler
// Type: NestedContentSizeFitterFixer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

[ExecuteInEditMode]
[DisallowMultipleComponent]
[RequireComponent(typeof (RectTransform))]
public class NestedContentSizeFitterFixer : UIBehaviour
{
  public bool runOnDimensionChange;
  private Transform cachedParent;
  private static HashSet<RectTransform> toProcess;
  private static HashSet<NestedContentSizeFitterFixer.RectUpdateNode> scratchNodeRoots;
  private static Dictionary<RectTransform, NestedContentSizeFitterFixer.RectUpdateNode> scratchNodeMapping;
  private static List<RectTransform> scratchReverseRebuildOrder;
  private static Queue<NestedContentSizeFitterFixer.RectUpdateNode> scratchReoderQueue;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected override void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected override void OnDisable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected override void OnRectTransformDimensionsChange() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected override void OnCanvasHierarchyChanged() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void QueueForUpdate(RectTransform rect) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static void ResolveQueuedUpdates() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static RectTransform CheckIsValid(RectTransform rect) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static void StoreInHierarchy(
    RectTransform toStore,
    Dictionary<RectTransform, NestedContentSizeFitterFixer.RectUpdateNode> nodeMapping,
    HashSet<NestedContentSizeFitterFixer.RectUpdateNode> roots)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static void OrderedExtract(
    NestedContentSizeFitterFixer.RectUpdateNode rootNode,
    List<RectTransform> ordered)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public NestedContentSizeFitterFixer() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static NestedContentSizeFitterFixer() => throw null;

  private class RectUpdateNode
  {
    public RectTransform rect;
    public NestedContentSizeFitterFixer.RectUpdateNode parent;
    public List<NestedContentSizeFitterFixer.RectUpdateNode> children;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool Equals(object obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int GetHashCode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RectUpdateNode() => throw null;
  }
}
