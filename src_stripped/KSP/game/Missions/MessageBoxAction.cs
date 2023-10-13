// Decompiled with JetBrains decompiler
// Type: KSP.Game.Missions.MessageBoxAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Game.Missions.Definitions;
using KSP.UI;
using Newtonsoft.Json;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game.Missions
{
  [Serializable]
  public class MessageBoxAction : MissionActionBase, IMissionAction
  {
    [JsonProperty]
    public string windowTitle;
    [JsonProperty]
    public string title;
    [JsonProperty]
    public string message;
    [JsonProperty]
    public System.Type eventType;
    [JsonProperty]
    public TutorialMessageBoxButtonType buttonType;
    [JsonProperty]
    public string imageKey;
    [JsonProperty]
    public string clipRelativePath;
    [JsonProperty]
    public string nextMissionID;
    [JsonProperty]
    public bool isMissionSummary;
    [JsonProperty]
    public MessageDescriptions messageDescriptions;
    [JsonProperty]
    public bool resetPositionToDefault;
    [JsonProperty]
    public bool useCustomPosition;
    [JsonProperty]
    public Vector2 customPosition;
    [JsonProperty]
    public bool useCustomAnchor;
    [JsonProperty]
    public Vector2 customAnchorMin;
    [JsonProperty]
    public Vector2 customAnchorMax;
    [JsonProperty]
    public bool useCustomPivot;
    [JsonProperty]
    public Vector2 customPivot;

    [JsonIgnore]
    private GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Activate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetParentMissionData(MissionData missionData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Deactivate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnMissionReset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetEditorName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetEditorDescription() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MessageBoxAction() => throw null;
  }
}
