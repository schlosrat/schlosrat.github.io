// Decompiled with JetBrains decompiler
// Type: KSP.Game.SerializedAgencyEntry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game.Missions.Definitions;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game
{
  public class SerializedAgencyEntry
  {
    public const int DEFAULT_AGENCY_ID = 0;
    public const string DEFAULT_AGENCY_NAME = "Kerbal Space Agency";
    public static Color DEFAULT_COLOR_BASE;
    public static Color DEFAULT_COLOR_ACCENT;
    public static string DEFAULT_FLAG_SPRITE_LOCATION;
    public static List<MissionData> DEFAULT_MISSIONS;
    [JsonProperty("AgencyId")]
    public int AgencyId;
    [JsonProperty("AgencyName")]
    public string AgencyName;
    [JsonProperty("ColorBase")]
    public Color ColorBase;
    [JsonProperty("ColorAccent")]
    public Color ColorAccent;
    [JsonProperty("FlagSpriteLocation")]
    public string FlagSpriteLocation;
    [JsonProperty("MissionData")]
    public List<MissionData> Missions;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedAgencyEntry() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedAgencyEntry(AgencyEntry src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    ~SerializedAgencyEntry() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Uninit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetAllValues() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetDebugString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static SerializedAgencyEntry() => throw null;
  }
}
