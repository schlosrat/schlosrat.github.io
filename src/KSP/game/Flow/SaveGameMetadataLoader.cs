// Decompiled with JetBrains decompiler
// Type: KSP.Game.Flow.SaveGameMetadataLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Game.Flow
{
  public class SaveGameMetadataLoader
  {
    private List<SavedGameMetaDataLoaderInstance> metaDataLoaders;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Shutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LoadMetadataFromSavedGame(
      string filepath,
      SaveLoadManager.GameMetadataFinishedDelegate finishedCallback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnLoaderCleanup(SavedGameMetaDataLoaderInstance instance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SaveGameMetadataLoader() => throw null;
  }
}
