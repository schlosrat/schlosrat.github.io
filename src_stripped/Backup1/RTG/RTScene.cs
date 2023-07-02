// Decompiled with JetBrains decompiler
// Type: RTG.RTScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace RTG
{
  public class RTScene : MonoSingleton<RTScene>
  {
    [SerializeField]
    private SceneSettings _settings;
    private List<IHoverableSceneEntityContainer> _hoverableSceneEntityContainers;
    private SceneTree _sceneTree;
    private HashSet<GameObject> _ignoredRootObjects;
    private List<GameObject> _childrenAndSelfBuffer;
    private List<GameObject> _rootGameObjectsBuffer;
    private List<GameObjectRayHit> _objectHitBuffer;

    public SceneSettings Settings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRootObjectIgnored(GameObject root, bool ignored) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnGameObjectWillBeDestroyed(GameObject gameObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AABB CalculateBounds() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsAnySceneEntityHovered() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterHoverableSceneEntityContainer(IHoverableSceneEntityContainer container) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsAnyUIElementHovered() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<RaycastResult> GetHoveredUIElements() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameObject[] GetSceneObjects() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool OverlapBox(OBB obb, List<GameObject> gameObjects) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool OverlapBox(OBB obb, SceneOverlapFilter overlapFilter, List<GameObject> gameObjects) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SceneRaycastHit Raycast(
      Ray ray,
      SceneRaycastPrecision rtRaycastPrecision,
      SceneRaycastFilter raycastFilter)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool RaycastAllObjects(
      Ray ray,
      SceneRaycastPrecision rtRaycastPrecision,
      List<GameObjectRayHit> hits)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool RaycastAllObjectsSorted(
      Ray ray,
      SceneRaycastPrecision raycastPresicion,
      List<GameObjectRayHit> hits)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool RaycastAllObjectsSorted(
      Ray ray,
      SceneRaycastPrecision rtRaycastPrecision,
      SceneRaycastFilter raycastFilter,
      List<GameObjectRayHit> hits)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameObjectRayHit RaycastMeshObject(Ray ray, GameObject meshObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameObjectRayHit RaycastMeshObjectReverseIfFail(Ray ray, GameObject meshObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameObjectRayHit RaycastSpriteObject(Ray ray, GameObject spriteObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameObjectRayHit RaycastTerrainObject(Ray ray, GameObject terrainObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameObjectRayHit RaycastTerrainObject(
      Ray ray,
      GameObject terrainObject,
      TerrainCollider terrainCollider)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameObjectRayHit RaycastTerrainObjectReverseIfFail(Ray ray, GameObject terrainObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public XZGridRayHit RaycastSceneGridIfVisible(Ray ray) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Update_SystemCall() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RTScene() => throw null;
  }
}
