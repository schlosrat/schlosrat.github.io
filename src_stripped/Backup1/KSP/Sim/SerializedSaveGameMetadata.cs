﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.SerializedSaveGameMetadata
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
    public CampaignType CampaignType;
    public bool NewPlayerIsFTUEEnabled;
    public string GameMode;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedSaveGameMetadata() => throw null;

    protected override string CurrentVersionString
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }
  }
}
