// Decompiled with JetBrains decompiler
// Type: RTG.ObjectBounds
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public static class ObjectBounds
  {
    private static ObjectBounds.QueryConfig _defaultQConfig;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static ObjectBounds() => throw null;

    public static ObjectBounds.QueryConfig DefaultQConfig
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Rect CalcScreenRect(
      GameObject gameObject,
      Camera camera,
      ObjectBounds.QueryConfig queryConfig)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static OBB CalcSpriteWorldOBB(GameObject gameObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static AABB CalcSpriteWorldAABB(GameObject gameObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static AABB CalcSpriteModelAABB(GameObject spriteObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static OBB GetMeshWorldOBB(GameObject gameObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static AABB GetMeshWorldAABB(GameObject gameObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static AABB CalcObjectCollectionWorldAABB(
      IEnumerable<GameObject> gameObjectCollection,
      ObjectBounds.QueryConfig queryConfig)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static AABB CalcHierarchyCollectionWorldAABB(
      IEnumerable<GameObject> roots,
      ObjectBounds.QueryConfig queryConfig)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static OBB CalcHierarchyWorldOBB(GameObject root, ObjectBounds.QueryConfig queryConfig) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static AABB CalcHierarchyWorldAABB(GameObject root, ObjectBounds.QueryConfig queryConfig) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static OBB CalcWorldOBB(GameObject gameObject, ObjectBounds.QueryConfig queryConfig) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static AABB CalcWorldAABB(GameObject gameObject, ObjectBounds.QueryConfig queryConfig) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static AABB CalcMeshWorldAABB(GameObject gameObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static AABB CalcHierarchyModelAABB(GameObject root, ObjectBounds.QueryConfig queryConfig) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static AABB CalcMeshModelAABB(GameObject gameObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static AABB CalcModelAABB(
      GameObject gameObject,
      ObjectBounds.QueryConfig queryConfig,
      GameObjectType objectType)
    {
      throw null;
    }

    public struct QueryConfig
    {
      public GameObjectType ObjectTypes;
      public Vector3 NoVolumeSize;
    }
  }
}
