// Decompiled with JetBrains decompiler
// Type: KSP.OAB.OABSavedWorkspaceMetaInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.OAB
{
  [Serializable]
  public class OABSavedWorkspaceMetaInfo : VersionedBase
  {
    public string Name;
    public string VehicleName;
    public string Description;
    public string ThumbnailPath;
    public float Mass;
    public long SaveTime;
    public int Parts;
    public int Stages;
    public bool IsAutoSave;
    public string CampaignName;
    public bool IsBackupWorkspace;
    public List<string> CriticalConcernLocTerms;
    [JsonIgnore]
    private string _partsInStagesString;

    protected override string CurrentVersionString
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [JsonIgnore]
    public string PartsStages
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OABSavedWorkspaceMetaInfo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OABSavedWorkspaceMetaInfo(
      int partCount,
      int stageCount,
      float mass,
      string versionString)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyFrom(OABSavedWorkspaceMetaInfo existingMetadata) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetPartsInStagesString() => throw null;
  }
}
