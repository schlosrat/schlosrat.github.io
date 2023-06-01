// Decompiled with JetBrains decompiler
// Type: KSP.Game.AgencyEventInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game
{
  public class AgencyEventInfo
  {
    public const int DEFAULT_AGENCY_ID = 0;
    public const AgencyEvent DEFAULT_AGENCY_EVENT = AgencyEvent.None;
    public const AgencyField DEFAULT_AGENCY_FIELD = AgencyField.None;
    public const string DEFAULT_AGENCY_NAME = "";
    public static Color DEFAULT_COLOR_BASE;
    public static Color DEFAULT_COLOR_ACCENT;
    public const string DEFAULT_FLAG_SPRITE_LOCATION = "";
    public const string DEFAULT_MISSIONS_JSON_STRING_OR_NULL = null;
    private int _agencyId;
    private AgencyEvent _agencyEvent;
    private AgencyField _agencyField;
    private string _agencyName;
    private Color _colorBase;
    private Color _colorAccent;
    private string _flagSpritelocation;
    private string _missionsJsonStringOrNull;

    public int AgencyId
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAgencyId(int agencyId) => throw null;

    public AgencyEvent AgencyEvent
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAgencyEvent(AgencyEvent agencyEvent) => throw null;

    public AgencyField AgencyField
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAgencyField(AgencyField agencyField) => throw null;

    public Color ColorBase
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string AgencyName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAgencyName(string agencyName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetColorBase(Color colorBase) => throw null;

    public Color ColorAccent
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetColorAccent(Color colorAccent) => throw null;

    public string FlagSpritelocation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetFlagSpritelocation(string flagSpritelocation) => throw null;

    public string MissionsJsonStringOrNull
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMissionsJsonStringOrNull(string missionsJsonStringOrNull) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AgencyEventInfo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AgencyEventInfo(AgencyEventInfo src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AgencyEventInfo(
      int agencyId,
      AgencyEvent agencyEvent,
      AgencyField agencyField,
      string agencyName,
      Color colorBase,
      Color colorAccent,
      string flagSpritelocation,
      string missionsJsonStringOrNull)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(AgencyEventInfo src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(
      int agencyId,
      AgencyEvent agencyEvent,
      AgencyField agencyField,
      string agencyName,
      Color colorBase,
      Color colorAccent,
      string flagSpritelocation,
      string missionsJsonStringOrNull)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetAllValues() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set(AgencyEventInfo src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set(
      int agencyId,
      AgencyEvent agencyEvent,
      AgencyField agencyField,
      string agencyName,
      Color colorBase,
      Color colorAccent,
      string flagSpritelocation,
      string missionsJsonStringOrNull)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetDebugString(bool abbrev) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static AgencyEventInfo() => throw null;
  }
}
