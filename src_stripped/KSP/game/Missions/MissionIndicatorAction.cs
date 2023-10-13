// Decompiled with JetBrains decompiler
// Type: KSP.Game.Missions.MissionIndicatorAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Assets;
using KSP.Game.Missions.Definitions;
using KSP.UI;
using Newtonsoft.Json;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game.Missions
{
  [Serializable]
  public class MissionIndicatorAction : MissionActionBase, IMissionAction
  {
    [JsonIgnore]
    public IndicatorData indicatorData;
    [JsonProperty]
    public string title;
    [JsonProperty]
    public string body;
    [JsonProperty]
    public string prefabKey;
    [JsonProperty]
    public string tagName;
    [JsonProperty]
    public Vector2 normalizedPos;
    [JsonProperty]
    public Vector2 offset;
    [JsonProperty]
    public string mainSpriteKey;
    [JsonProperty]
    public string mainTextureKey;
    [JsonProperty]
    public Vector2 imageSize;
    [JsonProperty]
    public bool stayAnchored;
    [JsonProperty]
    public bool animateOffScreen;
    [JsonProperty]
    public bool showTitleOnly;
    [JsonProperty]
    public float closeTime;
    [JsonProperty]
    public string trackingObjectID;
    [JsonProperty]
    public string trackingGUID;
    [JsonProperty]
    public string loopVideoKey;
    [JsonProperty]
    public string partName;
    [JsonProperty]
    public bool lastPartPlaced;
    [JsonIgnore]
    protected Indicator spawnedIndicator;
    [JsonIgnore]
    public string ParentMissionID;

    [JsonIgnore]
    protected GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [JsonIgnore]
    protected AssetProvider Assets
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Activate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Deactivate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnMissionReset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string GetEditorName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string GetEditorDescription() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetParentMissionData(MissionData missionData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void InitializeData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void GetTrackingObjectOrPart() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void TryLoadPrefab() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void PrefabLoadedSuccesfully(Indicator indicator) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnIndicatorAppear() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnIndicatorDisappear() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MissionIndicatorAction() => throw null;
  }
}
