// Decompiled with JetBrains decompiler
// Type: KSP.Game.Flow.LoadAssetReferenceFlowAction`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Assets;
using System;
using System.Runtime.CompilerServices;
using UnityEngine.AddressableAssets;

namespace KSP.Game.Flow
{
  public class LoadAssetReferenceFlowAction<T> : FlowAction where T : UnityEngine.Object
  {
    private AssetProvider _assetProvider;
    private AssetReferenceT<T> _assetReference;
    private Action<bool, T> _resultCallback;
    private Action _resolve;
    private Action<string> _reject;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LoadAssetReferenceFlowAction(
      string name,
      AssetReferenceT<T> assetReference,
      AssetProvider assetProvider,
      Action<bool, T> result)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void DoAction(Action resolve, Action<string> reject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnLoadFinished(T asset) => throw null;
  }
}
