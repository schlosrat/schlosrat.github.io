// Decompiled with JetBrains decompiler
// Type: KSP.Game.Flow.SavedGameMetaDataLoaderInstance
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game.Flow
{
  public class SavedGameMetaDataLoaderInstance
  {
    private string _filepath;
    private SaveLoadManager.GameMetadataFinishedDelegate _finishedCallback;
    private OnLoadCleanup _cleanupCallback;
    private Coroutine _loadMetaDataCoroutine;
    private bool _active;

    public GameInstance _game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SavedGameMetaDataLoaderInstance(
      string filepath,
      SaveLoadManager.GameMetadataFinishedDelegate finishedCallback,
      OnLoadCleanup cleanup)
    {
      throw null;
    }

    public bool IsActive
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator LoadMetaDataCoroutine(
      string filepath,
      SaveLoadManager.GameMetadataFinishedDelegate finishedCallback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Shutdown() => throw null;
  }
}
