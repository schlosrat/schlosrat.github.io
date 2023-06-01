// Decompiled with JetBrains decompiler
// Type: KSP.OAB.LaunchpadFileIO
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.IO;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  public class LaunchpadFileIO
  {
    private GameInstance _game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LoadWorkspaceFromFile(string filename, IOProvider.DataLocation dataLocation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LoadWorkspaceFromFile(TextAsset file) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OABHistoricalSnapshot GetSnapshotFromFile(
      string filename,
      IOProvider.DataLocation dataLocation)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplySnapshot(OABHistoricalSnapshot snapshot) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LaunchpadFileIO() => throw null;
  }
}
