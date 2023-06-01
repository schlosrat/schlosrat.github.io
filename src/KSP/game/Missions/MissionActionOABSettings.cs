// Decompiled with JetBrains decompiler
// Type: KSP.Game.Missions.MissionActionOABSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game.Missions
{
  [Serializable]
  public class MissionActionOABSettings : MissionActionBase, IMissionAction
  {
    [JsonProperty]
    public bool RevertBackupVesselToOAB;
    [JsonIgnore]
    public string ParentMissionID;
    [JsonProperty]
    public bool ClearSelectedWorkspacesToLoadOnStart;
    [JsonProperty]
    public List<WorkspaceSelectionData> SelectedWorkspaces;
    [JsonProperty]
    public List<string> FavoriteParts;
    [JsonProperty]
    public PartCategories PartCategory;
    [JsonProperty]
    public string VesselBackupFileKey;
    [JsonIgnore]
    private TextAsset _missionSaveTextAsset;

    [JsonIgnore]
    private GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Activate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Deactivate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnMissionReset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetEditorDescription() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetEditorName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetParentMissionID(string missionID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void LoadSelectedWorkspaces() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddFavoriteParts() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetCategory() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override IMissionAction DeepCopy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MissionActionOABSettings() => throw null;
  }
}
