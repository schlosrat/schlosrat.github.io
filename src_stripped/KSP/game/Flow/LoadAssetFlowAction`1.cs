// Decompiled with JetBrains decompiler
// Type: KSP.Game.Flow.LoadAssetFlowAction`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Assets;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Game.Flow
{
  public class LoadAssetFlowAction<T> : FlowAction where T : UnityEngine.Object
  {
    private AssetProvider _assetProvider;
    private string _key;
    private Action<bool, T> _resultCallback;
    private Action _resolve;
    private Action<string> _reject;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LoadAssetFlowAction(
      string name,
      string key,
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
