// Decompiled with JetBrains decompiler
// Type: KSP.Game.Missions.MessageBoxAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
    [JsonIgnore]
    public string ParentMissionID;
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
    public void SetParentMissionID(string missionID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Activate() => throw null;

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
