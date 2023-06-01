// Decompiled with JetBrains decompiler
// Type: KSP.Sim.SerializedSaveGameMetadata
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  [Serializable]
  public class SerializedSaveGameMetadata : VersionedBase
  {
    public string Name;
    public string Description;
    public string Filepath;
    public double UniverseTime;
    public string ThumbnailImagePath;
    public string HostPlayerActiveVesselName;
    public DateTime SaveCreatedTime;
    public SavedGameType SavedGameType;
    public CampaignMode CampaignMode;
    public CampaignType CampaignType;
    public DifficultyLevel DifficultyLevel;
    public DifficultyOptionsData DifficultyOptions;
    public DifficultyOptionsData DefaultDifficultyOptions;
    public bool NewPlayerIsFTUEEnabled;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedSaveGameMetadata() => throw null;

    protected override string CurrentVersionString
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }
  }
}
