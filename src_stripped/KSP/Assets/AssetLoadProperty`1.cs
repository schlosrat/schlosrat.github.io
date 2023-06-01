// Decompiled with JetBrains decompiler
// Type: KSP.Assets.AssetLoadProperty`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Api.Generic;
using System;
using System.Runtime.CompilerServices;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace KSP.Assets
{
  public class AssetLoadProperty<TAsset> : IDisposable where TAsset : UnityEngine.Object
  {
    private AsyncOperationHandle<TAsset> _assetAsyncOpHandle;
    public readonly string AssetKeyToLoad;
    public readonly Property<TAsset> AssetProp;

    public bool LoadCompleteOrPending
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public int AssetHandleRefCount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AssetLoadProperty(string assetKeyToLoad) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AssetLoadPropertyHandle<TAsset> GetLoadHandle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IProperty<TAsset> DoAssetLoadAsync() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TAsset DoAssetLoadWaitForCompletion() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DoAssetRelease(bool ignoreHandleRefCount = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void IncrementHandleRefCount() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DecrementHandleRefCount(bool doUnloadIfZero = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnAsyncLoadSuccess(AsyncOperationHandle<TAsset> handle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnAsyncLoadFail(AsyncOperationHandle handle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;
  }
}
