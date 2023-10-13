// Decompiled with JetBrains decompiler
// Type: KSP.Game.Missions.ActivateMissionAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Game.Missions.Definitions;
using Newtonsoft.Json;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Game.Missions
{
  [Serializable]
  public class ActivateMissionAction : MissionActionBase, IMissionAction
  {
    [JsonProperty]
    public string TargetMissionID;
    [JsonProperty]
    public MissionOwner MissionOwner;

    [JsonIgnore]
    protected GameInstance Game
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
    public void SetParentMissionData(MissionData missionData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string GetEditorName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string GetEditorDescription() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ActivateMissionAction() => throw null;
  }
}
