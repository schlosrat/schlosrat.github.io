// Decompiled with JetBrains decompiler
// Type: KSP.Game.Missions.Definitions.ActiveMissions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Game.Missions.Definitions
{
  public class ActiveMissions
  {
    public MissionOwner Owner;
    public int OwnerId;
    public List<MissionData> MissionDatas;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ActiveMissions() => throw null;
  }
}
