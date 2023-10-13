// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.GameClient.Local
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Networking.MP.Message;
using System.Runtime.CompilerServices;

namespace KSP.Networking.MP.GameClient
{
  public class Local
  {
    private KSP.Networking.MP.GameClient.GameClient _gameClient;

    public KSP.Networking.MP.GameClient.GameClient GameClient
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsHost
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Local(KSP.Networking.MP.GameClient.GameClient _gameClient = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    ~Local() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(KSP.Networking.MP.GameClient.GameClient gameClient) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Uninit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InvalidatePlayerId(byte playerId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ApplyPlayerIdForPlayerToSim(byte playerId, string playerGuidString) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool OnMissionMPAction(MissionMPActionData missionMPActionData) => throw null;
  }
}
