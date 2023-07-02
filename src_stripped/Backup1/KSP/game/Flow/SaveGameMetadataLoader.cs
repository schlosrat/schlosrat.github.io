// Decompiled with JetBrains decompiler
// Type: KSP.Game.Flow.SaveGameMetadataLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
