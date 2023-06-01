// Decompiled with JetBrains decompiler
// Type: KSP.Assets.AssetProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace KSP.Assets
{
  public class AssetProvider : MonoBehaviour
  {
    [SerializeField]
    private AssetObjectPool _poolPrefab;
    private Dictionary<string, AssetObjectPool> _pools;
    private List<IResourceLocator> _registeredResourceLocators;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TAsset Get<TAsset>(string key) where TAsset : UnityEngine.Object => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TAsset Create<TAsset>(string key, Transform parent = null) where TAsset : UnityEngine.Object => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CreateAsync<T>(string key, Action<T> resultCallback = null) where T : UnityEngine.Object => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CreateAsync<T>(string key, Transform parent = null, Action<T> resultCallback = null) where T : UnityEngine.Object => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CreateAsync<T>(
      string key,
      Vector3 position,
      Quaternion rotation,
      Transform parent = null,
      Action<T> resultCallback = null)
      where T : UnityEngine.Object
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AsyncOperationHandle<GameObject> CreateAsyncRaw(string key, Transform parent = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TAsset ForceCreate<TAsset>(string key, Transform parent = null) where TAsset : UnityEngine.Object => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Load<TAsset>(object keyObject, Action<TAsset> resultCallback = null, bool logMissingKey = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Load<TAsset>(string key, Action<TAsset> resultCallback = null, bool logMissingKey = true) where TAsset : UnityEngine.Object => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Load<TAsset>(
      string[] keys,
      Action<TAsset> assetLoadCallback,
      Action<IList<TAsset>> resultCallback = null)
      where TAsset : UnityEngine.Object
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Load<TAsset>(AssetReferenceT<TAsset> assetRef, Action<TAsset> resultCallback = null) where TAsset : UnityEngine.Object => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Load<TAsset>(
      IList<AssetReferenceT<TAsset>> assetRefs,
      Action<TAsset> assetLoadCallback,
      Action<IList<TAsset>> resultCallback = null)
      where TAsset : UnityEngine.Object
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AsyncOperationHandle<T> LoadRaw<T>(string key) where T : UnityEngine.Object => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AsyncOperationHandle<T> LoadRaw<T>(IResourceLocation location) where T : UnityEngine.Object => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AsyncOperationHandle<IList<T>> LoadAllRaw<T>(
      IList<IResourceLocation> locations,
      Action<T> assetLoadCallback)
      where T : UnityEngine.Object
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AsyncOperationHandle<IList<T>> LoadAllRaw<T>(object key, Action<T> assetLoadCallback) where T : UnityEngine.Object => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsRaw<T>(object key) where T : UnityEngine.Object => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LoadByLabel<T>(
      string label,
      Action<T> assetLoadCallback,
      Action<IList<T>> resultCallback = null)
      where T : UnityEngine.Object
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LoadAll<T>(
      IList<IResourceLocation> resourceLocations,
      Action<T> assetLoadCallback,
      Action<IList<T>> resultCallback = null)
      where T : UnityEngine.Object
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LoadResourceLocations<T>(
      object key,
      Action<IList<IResourceLocation>> resultCallback)
      where T : UnityEngine.Object
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ReleaseAsset<T>(T asset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Release(AsyncOperationHandle handle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DestroyInstance(GameObject instance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsPooledObject<TAsset>(string key) where TAsset : UnityEngine.Object => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private AssetObjectPool GetOrCreatePool<TAsset>(string key) where TAsset : UnityEngine.Object => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool IsComponent(System.Type type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterResourceLocator(IResourceLocator locator) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnregisterResourceLocator(IResourceLocator locator) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AsyncOperationHandle<TAsset> LoadAssetAsync<TAsset>(object key) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AsyncOperationHandle<IList<T>> LoadAssetsAsync<T>(
      string key,
      Action<T> assetLoadCallback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool LocateAssetInExternalData(object key, System.Type T, out IResourceLocation location) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<IResourceLocation> LocateAssetsInExternalData(object reference) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddressablesExceptionHandler(AsyncOperationHandle handle, Exception ex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AssetProvider() => throw null;
  }
}
