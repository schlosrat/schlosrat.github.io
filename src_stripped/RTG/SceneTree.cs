// Decompiled with JetBrains decompiler
// Type: RTG.SceneTree
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class SceneTree
  {
    private static float _nonMeshObjectSize;
    private SphereTree<GameObject> _objectTree;
    private List<SphereTreeNodeRayHit<GameObject>> _nodeHitBuffer;
    private List<SphereTreeNode<GameObject>> _nodeBuffer;
    private Dictionary<GameObject, SphereTreeNode<GameObject>> _objectToNode;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameObjectRayHit RaycastMeshObject(Ray ray, GameObject gameObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameObjectRayHit RaycastSpriteObject(Ray ray, GameObject gameObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool RaycastAll(
      Ray ray,
      SceneRaycastPrecision raycastPresicion,
      List<GameObjectRayHit> hits)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool OverlapBox(OBB obb, List<GameObject> gameObjects) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsObjectRegistered(GameObject gameObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool RegisterObject(GameObject gameObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool UnregisterObject(GameObject gameObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnObjectTransformChanged(Transform objectTransform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveNodesWithNullObjects() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DebugDraw() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool CanRegisterObject(GameObject gameObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SceneTree() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static SceneTree() => throw null;
  }
}
