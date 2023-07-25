// Decompiled with JetBrains decompiler
// Type: NestedPrefabSpawner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ThreeEyedGames;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class NestedPrefabSpawner : KerbalMonoBehaviour
{
  [Header("Prefabs")]
  public List<NestedPrefabSpawner.NestedPrefab> Prefabs;
  [Header("Parameters")]
  public NestedPrefabSpawner.SpawnOnEvent SpawnOn;
  public int StartDelay;
  public bool ForceLayer;
  [Tooltip("For layer indices, check here: https://privatedivision.atlassian.net/wiki/spaces/PDMer/pages/1898250779/Unity+Layer+Tech+Plan")]
  public int EnforcedLayer;
  public Action<NestedPrefabSpawner> SpawningFinished;
  private List<AsyncOperationHandle<GameObject>> _spawnedHandles;
  private List<AsyncOperationHandle<GameObject>> _pendingOperationHandles;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private IEnumerator Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDestroy() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool IsFinished() => throw null;

  [ContextMenu("Spawn Prefabs")]
  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SpawnPrefabs() => throw null;

  [ContextMenu("Destroy Spawned Instances")]
  [MethodImpl(MethodImplOptions.NoInlining)]
  public void CleanUp() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public NestedPrefabSpawner() => throw null;

  [Serializable]
  public class NestedPrefab
  {
    public AssetReferenceGameObject PrefabAssetReference;
    public Transform tgtTransform;
    public bool UseTerrainBlendDecals;
    public List<Decal> TerrainBlendDecals;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NestedPrefab() => throw null;
  }

  public enum SpawnOnEvent
  {
    None,
    Awake,
    StartPlusDelay,
  }
}
