// Decompiled with JetBrains decompiler
// Type: KSP.Game.Missions.MessageBoxAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.UI;
using Newtonsoft.Json;
using System;
using System.Runtime.CompilerServices;

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
