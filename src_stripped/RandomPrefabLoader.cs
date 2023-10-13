// Decompiled with JetBrains decompiler
// Type: RandomPrefabLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Assets;
using KSP.Game;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

[DisallowMultipleComponent]
public class RandomPrefabLoader : KerbalMonoBehaviour, IAsyncHandleAccess
{
  [SerializeField]
  [Tooltip("Name is just so Devs can organize what this component is being used for, to other devs who come across it.")]
  private string _name;
  [SerializeField]
  private SingleUnityLayer _loadLayer;
  [SerializeField]
  private float _minLoadDelay;
  [SerializeField]
  private float _maxLoadDelay;
  [SerializeField]
  private List<AssetReferenceT<GameObject>> _managedPrefabsToLoad;
  [SerializeField]
  [Space(10f)]
  private List<GameState> _gameStatesToBeEnabledIn;
  private AssetProvider _assetProvider;
  private AsyncOperationHandle<GameObject> _curAsyncLoadHandle;
  private List<GameState> _gameStatesToStayActiveInAtStartOfLoad;
  private int _curTargetIndex;
  private RandomPrefabLoader_Target _curActiveTarget;
  private AssetReferenceT<GameObject> _curActiveAssetRef;
  private bool _doCountdownToNextLoad;
  private float _curCountdownToNextLoad;
  private System.Random _randomizer;
  private List<AssetReferenceT<GameObject>> _targetsToLoad;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public AsyncOperationHandle<GameObject> GetAsyncHandle() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDisable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void LateUpdate() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void InitAssetProvider() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private bool ValidateContinuedExistenceOfManagedAssets(
    List<GameState> overrideGameStatesToCompareAgainst = null)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnTargetAnimCompleted() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void RemoveAndResetActivePrefab() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ResetTimer() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void LoadRandomEntry() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnRandomPrefabLoadComplete(AsyncOperationHandle<GameObject> handle) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void RemoveBadTargetAndTryToReload(AssetReferenceT<GameObject> badTargetToRemove) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ResetTargetsToLoadList() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public RandomPrefabLoader() => throw null;
}
