// Decompiled with JetBrains decompiler
// Type: KSP.Game.AgencyManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game.Missions.Definitions;
using KSP.Sim;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game
{
  public class AgencyManager
  {
    public const OnAgencyEventCallback DEFAULT_ON_AGENCY_EVENT_CALLBACK = null;
    public const bool DEFAULT_PROPAGATE_EVENTS_FLAG = false;
    private List<AgencyEntry> _list;
    private Dictionary<int, AgencyEntry> _agencyIdDict;
    private OnAgencyEventCallback _onAgencyEventCallback;
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

    public OnAgencyEventCallback OnAgencyEventCallback
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetOnAgencyEventCallback(OnAgencyEventCallback onAgencyEventCallback) => throw null;

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
    public void SetAllFoundFlags(bool foundFlag) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAllFoundFlags() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearAllFoundFlags() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AgencyEntry FindAgencyEntryByIndex(int index) => throw null;

    public AgencyEntry AgencyEntryFirst
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public AgencyEntry AgencyEntryLast
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AgencyEntry FindAgencyEntryByAgencyId(int agencyId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AgencyEntry FindAgencyEntryFirstNotFound() => throw null;

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
      List<MissionData> missions)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AgencyEntry CreateAgencyEntry(
      string agencyName,
      Color colorBase,
      Color colorAccent,
      string flagSpritelocation,
      List<MissionData> missions)
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
