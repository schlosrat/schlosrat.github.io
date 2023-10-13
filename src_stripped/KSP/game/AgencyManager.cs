// Decompiled with JetBrains decompiler
// Type: KSP.Game.AgencyManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Game.Missions.Definitions;
using KSP.Sim;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game
{
  public class AgencyManager
  {
    public const OnAgencyMPActionCallback DEFAULT_ON_AGENCY_MP_ACTION_CALLBACK = null;
    public const bool DEFAULT_PROPAGATE_EVENTS_FLAG = false;
    private List<AgencyEntry> _list;
    private Dictionary<int, AgencyEntry> _agencyIdDict;
    private OnAgencyMPActionCallback _onAgencyMPActionCallback;
    private bool _propagateEventsFlag;

    public GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int NumAgencies
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int IndexOfEntry(AgencyEntry agencyEntry) => throw null;

    public OnAgencyMPActionCallback OnAgencyMPActionCallback
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetOnAgencyMPActionCallback(OnAgencyMPActionCallback onAgencyMPActionCallback) => throw null;

    public bool PropagateEventsFlag
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPropagateEventsFlag(bool propagateEventsFlag) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AgencyManager() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    ~AgencyManager() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Uninit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddAgencyEntry(AgencyEntry agencyEntry) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveAgencyEntry(AgencyEntry agencyEntry) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AgencyEntry FindAgencyEntryByIndex(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AgencyEntry FindAgencyEntryFirst() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AgencyEntry FindAgencyEntryLast() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AgencyEntry FindAgencyEntryByAgencyId(int agencyId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetAgencyEntry(
      int agencyId,
      out AgencyEntry agencyEntryOut,
      bool logWarningIfFail = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetMyAgencyEntry(out AgencyEntry agencyEntryOut, bool logWarningIfFail = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Empty() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int GetNewAgencyId() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AgencyEntry CreateAgencyEntry(
      int agencyId,
      string agencyName,
      Color colorBase,
      Color colorAccent,
      string flagSpritelocation,
      List<MissionSaveData> missionSaveData)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AgencyEntry CreateAgencyEntry(
      string agencyName,
      Color colorBase,
      Color colorAccent,
      string flagSpritelocation,
      List<MissionSaveData> missionSaveData)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AgencyEntry CreateAgencyEntry(SerializedAgencyEntry serializedAgencyEntry) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AgencyEntry CreateNewDebugAgencyEntry() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AgencyEntry FindOrCreateNewAgencyEntry(
      NewPlayerSetupInfo newPlayerSetupInfo,
      bool isFirst)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DestroyAgencyEntry(int agencyId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AgencyEntry ImportSerializedAgencyEntry(SerializedAgencyEntry src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ImportSerializedAgencyEntries(SerializedAgencyEntry[] array) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedAgencyEntry[] ExportSerializedAgencyEntries() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Load(SerializedSavedGame src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Save(SerializedSavedGame dest) => throw null;
  }
}
