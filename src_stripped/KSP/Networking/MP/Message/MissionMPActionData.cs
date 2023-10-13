// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.Message.MissionMPActionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;

namespace KSP.Networking.MP.Message
{
  public class MissionMPActionData
  {
    public static Route DEFAULT_ROUTE;
    public const MissionMPAction DEFAULT_GAME_DEBUG_MP_ACTION = MissionMPAction.None;
    public const string DEFAULT_STRING_PARAM = "";
    private MissionMPAction _missionMPAction;
    private string _stringParam;
    public Route Route;

    public MissionMPAction MissionMPAction
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMissionMPAction(MissionMPAction missionMPAction) => throw null;

    public string StringParam
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetStringParam(string stringParam) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MissionMPActionData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MissionMPActionData(MissionMPActionData src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MissionMPActionData(Route route, MissionMPAction missionMPAction, string stringParam) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MissionMPActionData(Route route, MissionMPAction missionMPAction) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(MissionMPActionData src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(Route route, MissionMPAction missionMPAction, string stringParam) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(Route route, MissionMPAction missionMPAction) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetAllValues() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set(MissionMPActionData src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set(Route route, MissionMPAction missionMPAction, string stringParam) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set(Route route, MissionMPAction missionMPAction) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetDebugString(bool abbrev) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static MissionMPActionData() => throw null;
  }
}
