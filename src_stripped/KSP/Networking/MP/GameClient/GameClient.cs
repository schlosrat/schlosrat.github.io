// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.GameClient.GameClient
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Networking.MP.GameClient
{
  public class GameClient : IDisposable
  {
    public const byte NO_PLAYER_ID = 0;
    public const string NO_PLAYER_NAME_STRING = "";
    public const string NO_PLAYER_GUID_STRING = "";
    public const int JSON_SNAPSHOT_HISTORY_LIST_MAX_SIZE = 24;
    public const string DEFAULT_CONNECTING_FAILURE_REASON_STRING = "";
    public const byte DEFAULT_PLAYER_ID = 0;
    public const string DEFAULT_PLAYER_NAME_STRING = "";
    public const string DEFAULT_PLAYER_GUID_STRING = "";
    public const int DEFAULT_MAX_PLAYERS = 1;
    public const byte DEFAULT_PLAYER_ID_HOST = 0;
    private MPFramework _mp;
    private byte _playerId;
    private string _playerNameString;
    private string _playerGuidString;
    private int _maxPlayers;
    private byte _playerIdHost;
    private Local _local;
    private Remote _remote;

    public MPFramework MP
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public byte PlayerId
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string PlayerNameString
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string PlayerGuidString
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int MaxPlayers
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public byte PlayerIdHost
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Local Local
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Remote Remote
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameClient(MPFramework mpFramework = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    ~GameClient() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(MPFramework mp) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Uninit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnClearedOutLoadingProcessQueueHandler() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPlayerInfo(byte playerId, string playerNameString, string playerGuidString) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearPlayerInfo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMaxPlayers(int maxPlayers) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetMaxPlayers() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPlayerIdHost(byte playerIdHost) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetPlayerIdHost() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnUpdate() => throw null;
  }
}
