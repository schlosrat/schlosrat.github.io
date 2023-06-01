// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.GameClient.ScrapeTrackingInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Networking.MP.Utils;
using System.Runtime.CompilerServices;

namespace KSP.Networking.MP.GameClient
{
  public class ScrapeTrackingInfo
  {
    public const ScrapeTrackingType DEFAULT_SCRAPE_TRACKING_TYPE = ScrapeTrackingType.None;
    public const long DEFAULT_TIME_STAMP = 0;
    public const string DEFAULT_PLAYER_NAME_STRING = "";
    public const string DEFAULT_PLAYER_GUID_STRING = "";
    public const byte DEFAULT_PLAYER_ID = 0;
    public const byte DEFAULT_AUTHORITY_PLAYER_ID = 0;
    public const bool DEFAULT_IS_LOCAL_PLAYER = false;
    private ScrapeTrackingType _scrapeTrackingType;
    private long _timeStamp;
    private string _playerNameString;
    private string _playerGuidString;
    private byte _playerId;
    private byte _authorityPlayerId;
    private bool _isLocalPlayer;

    public ScrapeTrackingType ScrapeTrackingType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScrapeTrackingType(ScrapeTrackingType scrapeTrackingType) => throw null;

    public long TimeStamp
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetTimeStamp(long timeStamp) => throw null;

    public string PlayerNameString
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPlayerNameString(string playerNameString) => throw null;

    public string PlayerGuidString
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPlayerGuidString(string playerGuidString) => throw null;

    public byte PlayerId
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPlayerId(byte playerId) => throw null;

    public byte AuthorityPlayerId
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAuthorityPlayerId(byte authorityPlayerId) => throw null;

    public bool IsLocalPlayer
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetIsLocalPlayer(bool isLocalPlayer) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ScrapeTrackingInfo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ScrapeTrackingInfo(
      ScrapeTrackingType scrapeTrackingType,
      long timeStamp,
      string playerNameString,
      string playerGuidString,
      byte playerId,
      byte authorityPlayerId,
      bool isLocalPlayer)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    ~ScrapeTrackingInfo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(
      ScrapeTrackingType scrapeTrackingType,
      long timeStamp,
      string playerNameString,
      string playerGuidString,
      byte playerId,
      byte authorityPlayerId,
      bool isLocalPlayer)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Uninit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetAllValues() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set(
      ScrapeTrackingType scrapeTrackingType,
      long timeStamp,
      string playerNameString,
      string playerGuidString,
      byte playerId,
      byte authorityPlayerId,
      bool isLocalPlayer)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetDebugPlayerIdNameAndGuidString(StringUtil.PlayerNameFlag playerNameFlags = StringUtil.PlayerNameFlag.Default) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString() => throw null;
  }
}
