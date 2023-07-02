// Decompiled with JetBrains decompiler
// Type: RTG.GameObjectEx
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public static class GameObjectEx
  {
    private static List<Transform> _transformsChildren;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SetStatic(this GameObject gameObject, bool isStatic, bool affectChildren) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsRTGAppObject(this GameObject gameObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static GameObjectType GetGameObjectType(this GameObject gameObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool HierarchyHasMesh(this GameObject root) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool HierarchyHasSprite(this GameObject root) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool HierarchyHasObjectsOfType(this GameObject root, GameObjectType typeFlags) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<GameObject> GetMeshObjectsInHierarchy(this GameObject root) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<GameObject> GetSpriteObjectsInHierarchy(this GameObject root) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SetHierarchyWorldScaleByPivot(
      this GameObject root,
      Vector3 worldScale,
      Vector3 pivotPoint)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<GameObject> GetAllChildren(this GameObject gameObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<GameObject> GetAllChildrenAndSelf(this GameObject gameObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void GetAllChildrenAndSelf(
      this GameObject gameObject,
      List<GameObject> childrenAndSelf)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Mesh GetMesh(this GameObject gameObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Renderer GetMeshRenderer(this GameObject gameObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Sprite GetSprite(this GameObject gameObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<GameObject> GetRoots(IEnumerable<GameObject> gameObjects) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<GameObject> FilterParentsOnly(IEnumerable<GameObject> gameObjects) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static GameObjectEx() => throw null;
  }
}
