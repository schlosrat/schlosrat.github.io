// Decompiled with JetBrains decompiler
// Type: KSP.Assets.AssetLoadPropertyHandle`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Assets
{
  public struct AssetLoadPropertyHandle<TAsset> : IDisposable where TAsset : UnityEngine.Object
  {
    private Action<TAsset> _changeCallback;
    private bool _isAlive;

    public readonly AssetLoadProperty<TAsset> LoadProperty
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AssetLoadPropertyHandle(AssetLoadProperty<TAsset> loadProperty) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private AssetLoadPropertyHandle(AssetLoadPropertyHandle<TAsset> other) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetChangeCallback(Action<TAsset> changeCallback) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;
  }
}
