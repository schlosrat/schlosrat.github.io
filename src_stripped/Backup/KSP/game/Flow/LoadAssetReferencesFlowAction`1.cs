// Decompiled with JetBrains decompiler
// Type: KSP.Game.Flow.LoadAssetReferencesFlowAction`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Assets;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.AddressableAssets;

namespace KSP.Game.Flow
{
  public class LoadAssetReferencesFlowAction<T> : FlowAction where T : UnityEngine.Object
  {
    private AssetProvider _assetProvider;
    private IList<AssetReferenceT<T>> _assetReferences;
    private Action<T> _assetLoadedCallback;
    private Action<bool, IList<T>> _resultCallback;
    private Action _resolve;
    private Action<string> _reject;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LoadAssetReferencesFlowAction(
      string name,
      IList<AssetReferenceT<T>> assetReferences,
      AssetProvider assetProvider,
      Action<T> assetLoadedCallback,
      Action<bool, IList<T>> result)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void DoAction(Action resolve, Action<string> reject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnLoadFinished(IList<T> assets) => throw null;
  }
}
