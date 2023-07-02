// Decompiled with JetBrains decompiler
// Type: KSP.Game.LocalPlayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Game
{
  public class LocalPlayer
  {
    public const string DEFAULT_PLAYER_NAME_STRING = "";
    public const string DEFAULT_PLAYER_GUID_STRING = "";
    public const byte DEFAULT_PLAYER_ID = 0;
    public const bool DEFAULT_IS_PLAYER_HOST = false;
    public const bool DEFAULT_IS_PLAYER_HOST_IN_MP_GAME = false;
    public const int DEFAULT_MAX_PLAYERS = 1;
    public const byte DEFAULT_PLAYER_ID_HOST = 0;
    private string _playerNameString;
    private string _playerGuidString;
    private byte _playerId;
    private bool _isPlayerHost;
    private bool _isPlayerHostInMPGame;
    private int _maxPlayers;
    private byte _playerIdHost;

    public static GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string PlayerNameString
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPlayerNameString(string playerNameString) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetPlayerNameString() => throw null;

    public string PlayerGuidString
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPlayerGuidString(string playerGuidString) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetPlayerGuidString() => throw null;

    public byte PlayerId
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPlayerId(byte playerId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetPlayerId() => throw null;

    public bool IsPlayerHost
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetIsPlayerHost(bool isPlayerHost) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetIsPlayerHost() => throw null;

    public bool IsPlayerHostInMPGame
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetIsPlayerHostInMPGame(bool isPlayerHostInMPGame) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetIsPlayerHostInMPGame() => throw null;

    public int MaxPlayers
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMaxPlayers(int maxPlayers) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetMaxPlayers() => throw null;

    public byte PlayerIdHost
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPlayerIdHost(byte playerIdHost) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetPlayerIdHost() => throw null;

    public int AgencyId
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LocalPlayer() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    ~LocalPlayer() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Uninit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetAllDataValues() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetDebugPlayerIdAndNameString() => throw null;
  }
}
