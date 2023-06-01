// Decompiled with JetBrains decompiler
// Type: KSP.Game.Missions.Definitions.MissionStateSaveList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using Newtonsoft.Json;
using System.Collections.Generic;

namespace KSP.Game.Missions.Definitions
{
  public struct MissionStateSaveList
  {
    [JsonProperty]
    public List<MissionStateSave> missionProgress;
  }
}
