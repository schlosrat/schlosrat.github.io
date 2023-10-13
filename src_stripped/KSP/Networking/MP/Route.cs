// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.Route
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;

namespace KSP.Networking.MP
{
  public struct Route
  {
    public const byte DEFAULT_ORIGINATING_PLAYER_ID = 0;
    public const RouteTo DEFAULT_ROUTE_TO = RouteTo.None;
    public const byte DEFAULT_SPECIFIC_PLAYER_ID = 0;
    public const int DEFAULT_SPECIFIC_AGENCY_ID = 0;
    private byte _originatingPlayerId;
    private RouteTo _routeTo;
    private byte _specificPlayerId;
    private int _specificAgencyId;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static RouteFlag GetRouteFlags(RouteTo routeTo) => throw null;

    public byte OriginatingPlayerId
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetOriginatingPlayerId(byte originatingPlayerId) => throw null;

    public RouteTo RouteTo
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRouteTo(RouteTo routeTo) => throw null;

    public byte SpecificPlayerId
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSpecificPlayerId(byte specificPlayerId) => throw null;

    public int SpecificAgencyId
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSpecificAgencyId(int specificAgencyId) => throw null;

    public RouteFlag RouteFlags
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool NeedPlayerId
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool NeedAgencyId
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Route(
      byte originatingPlayerId,
      RouteTo routeTo,
      byte specificPlayerId,
      int specificAgencyId)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Route(byte originatingPlayerId, RouteTo routeTo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Route(byte originatingPlayerId, RouteTo routeTo, byte specificPlayerId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Route(byte originatingPlayerId, RouteTo routeTo, int agencyPlayerId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Route(RouteTo routeTo, byte specificPlayerId, int specificAgencyId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Route(RouteTo routeTo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Route(RouteTo routeTo, byte specificPlayerId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Route(RouteTo routeTo, int agencyPlayerId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(
      byte originatingPlayerId,
      RouteTo routeTo,
      byte specificPlayerId,
      int specificAgencyId)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(byte originatingPlayerId, RouteTo routeTo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(byte originatingPlayerId, RouteTo routeTo, byte specificPlayerId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(byte originatingPlayerId, RouteTo routeTo, int specificAgencyId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(RouteTo routeTo, byte specificPlayerId, int specificAgencyId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(RouteTo routeTo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(RouteTo routeTo, byte specificPlayerId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(RouteTo routeTo, int specificAgencyId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetAllValues() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set(
      byte originatingPlayerId,
      RouteTo routeTo,
      byte specificPlayerId,
      int specificAgencyId)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set(byte originatingPlayerId, RouteTo routeTo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set(byte originatingPlayerId, RouteTo routeTo, byte specificPlayerId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set(byte originatingPlayerId, RouteTo routeTo, int specificAgencyId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set(RouteTo routeTo, byte specificPlayerId, int specificAgencyId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set(RouteTo routeTo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set(RouteTo routeTo, byte specificPlayerId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set(RouteTo routeTo, int specificAgencyId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetDebugString(bool abbrev) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString() => throw null;

    public bool ShouldProcess
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool ShouldProcessLocally
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool ShouldSendToServer
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }
  }
}
