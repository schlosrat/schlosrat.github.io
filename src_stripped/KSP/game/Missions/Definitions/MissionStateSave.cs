// Decompiled with JetBrains decompiler
// Type: KSP.Game.Missions.Definitions.MissionStateSave
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game.Missions.State;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace KSP.Game.Missions.Definitions
{
  public struct MissionStateSave
  {
    [JsonProperty]
    public string ID;
    [JsonProperty]
    public MissionState state;
    [JsonProperty]
    public List<MissionDataStageSave> missionStageSave;
    [JsonProperty]
    public int currentStage;
  }
}
