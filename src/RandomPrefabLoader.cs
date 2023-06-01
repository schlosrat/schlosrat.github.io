// Decompiled with JetBrains decompiler
// Type: RandomPrefabLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Assets;
using KSP.Game;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

public class RandomPrefabLoader : KerbalMonoBehaviour
{
  [Tooltip("Name is just so Devs can organize what this component is being used for, to other devs who come across it.")]
  [SerializeField]
  [FormerlySerializedAs("Name")]
  private string _name;
  [SerializeField]
  private SingleUnityLayer _loadLayer;
  [SerializeField]
  private float _minLoadDelay;
  [SerializeField]
  private float _maxLoadDelay;
  [SerializeField]
  private List<string> _prefabTargetsToLoad;
  [Space(10f)]
  [SerializeField]
  private List<GameState> _gameStatesToBeEnabledIn;
  private AssetProvider _assetProvider;
  private RandomPrefabLoader_Target _curActiveTarget;
  private string _curActiveKey;
  private bool _doCountdownToNextLoad;
  private float _curCountdownToNextLoad;
  private System.Random _randomizer;
  private List<string> _targetsToLoad;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void LateUpdate() => throw null;

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
  private void RemoveBadTargetAndTryToReload(string badTargetToRemove) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ResetTargetsToLoadList() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public RandomPrefabLoader() => throw null;
}
