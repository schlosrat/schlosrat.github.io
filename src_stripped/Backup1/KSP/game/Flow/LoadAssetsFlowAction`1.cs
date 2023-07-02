// Decompiled with JetBrains decompiler
// Type: KSP.Game.Flow.LoadAssetsFlowAction`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Assets;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Game.Flow
{
  public class LoadAssetsFlowAction<T> : FlowAction where T : UnityEngine.Object
  {
    private AssetProvider _assetProvider;
    private string[] _keys;
    private Action<T> _assetLoadedCallback;
    private Action<bool, IList<T>> _resultCallback;
    private Action _resolve;
    private Action<string> _reject;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LoadAssetsFlowAction(
      string name,
      string[] keys,
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
