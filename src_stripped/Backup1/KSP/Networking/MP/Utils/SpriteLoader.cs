// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.Utils.SpriteLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace KSP.Networking.MP.Utils
{
  public class SpriteLoader : IDisposable
  {
    public const string DEFAULT_SPRITE_LOCATION_STRING = "";
    public const Sprite DEFAULT_SPRITE = null;
    public const bool DEFAULT_IS_LOAD_IN_PROGRESS = false;
    public const SpriteLoaderLoadCompletedCallback DEFAULT_LOAD_COMPLETED_CALLBACK = null;
    public static AsyncOperationHandle<Sprite> DEFAULT_LOAD_HANDLE;
    private string _spriteLocationString;
    private Sprite _sprite;
    private bool _isloadInProgress;
    private SpriteLoaderLoadCompletedCallback _loadCompletedCallback;
    private AsyncOperationHandle<Sprite> _loadHandle;

    public string SpriteLocationString
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Sprite Sprite
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsLoadInProgress
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public SpriteLoaderLoadCompletedCallback LoadCompletedCallback
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SpriteLoader() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    ~SpriteLoader() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Uninit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SpriteLoadCompletedHandler(AsyncOperationHandle<Sprite> handle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void StartLoading(
      string spriteLocationString,
      SpriteLoaderLoadCompletedCallback loadCompletedCallback = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CancelLoad() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static SpriteLoader() => throw null;
  }
}
