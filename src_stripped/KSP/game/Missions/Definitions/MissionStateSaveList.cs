// Decompiled with JetBrains decompiler
// Type: KSP.Game.Missions.Definitions.MissionStateSaveList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
