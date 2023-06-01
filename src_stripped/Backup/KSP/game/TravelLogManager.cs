// Decompiled with JetBrains decompiler
// Type: KSP.Game.TravelLogManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Messages;
using KSP.Sim;
using KSP.Sim.impl;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Game
{
  public class TravelLogManager
  {
    public const string LOG_VESSEL_LAUNCHED = "Flight/FlightReport/Log/Vessel Launched";
    public const string LOG_VESSEL_RECOVERED = "Flight/FlightReport/Log/Vessel Recovered";
    public const string LOG_VESSEL_DESTROYED = "Flight/FlightReport/Log/Vessel Destroyed";
    public const string LOG_VESSEL_LANDED = "Flight/FlightReport/Log/Vessel Landed";
    public const string LOG_VESSEL_ENTERED_SOI = "Flight/FlightReport/Log/Entered SOI";
    public const string LOG_PART_CRASHED = "Flight/FlightReport/Log/Part Crashed";
    public const string LOG_PART_EXPLODED = "Flight/FlightReport/Log/Part Exploded";
    public const string LOG_PART_EXP_OVERHEAT = "Flight/FlightReport/Log/Part Exploded Overheat";
    public const string LOG_PART_JOINT_BROKEN = "Flight/FlightReport/Log/Part Joint Broken";
    private const bool REMOVE_ENTRIES_ON_LOAD = true;
    public double MaxSpeedOverGroundAltitudeLimit;
    private DictionaryValueList<string, TravelEventDefinition> _events;
    private DictionaryValueList<IGGuid, TravelObject> _objects;
    private List<TravelObjectEvent> _objectEvents;
    private Dictionary<IGGuid, List<TravelObjectEvent>> _lookupEventsByTravelId;
    private static readonly TravelEventDefinition _eventVesselLaunched;
    private static readonly TravelEventDefinition _eventVesselLanded;
    private static readonly TravelEventDefinition _eventVesselDestroyed;
    private static readonly TravelEventDefinition _eventVesselRecovered;
    private static readonly TravelEventDefinition _eventVesselSOIEntered;
    private static readonly TravelEventDefinition _eventPartCrashed;
    private static readonly TravelEventDefinition _eventPartExploded;
    private static readonly TravelEventDefinition _eventPartExplodedOverheat;
    private static readonly TravelEventDefinition _eventPartJointBroken;

    public GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Shutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BuildEventDefinitionsList() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryAddEventDefinition(TravelEventDefinition newEvent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetEventDefinition(string eventKey, out TravelEventDefinition eventDefinition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselSplit(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselLaunched(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselLanded(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselDestroyed(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselRecovered(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnSOIEntered(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPartCrashed(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPartExploded(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPartJointBroken(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddVesselEvent(
      VesselComponent vessel,
      double ut,
      TravelEventDefinition eventDef,
      params string[] flightReportArgs)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void UpdateVesselStatistics(
      VesselComponent vessel,
      TravelObjectVesselUpdateData vesselData)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddSerializedObjectEvent(SerializedTravelObjectEvent tEvent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddObjectsEvent(
      List<IGGuid> travelIds,
      double ut,
      TravelEventDefinition eventDef,
      params string[] flightReportArgs)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddObjectsEvent(
      List<IGGuid> travelIds,
      double ut,
      bool fireEvent,
      TravelEventDefinition eventDef,
      params string[] flightReportArgs)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private TravelObject GetValidTravelObject(IGGuid travelObjectId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void RemoveTravelObject(IGGuid guid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetVesselTravelObject(VesselComponent vessel, out TravelObject tObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetTravelObject(IGGuid travelObjectId, out TravelObject tObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<TravelObjectEvent> GetTravelObjectEvents(IGGuid travelObjectId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<TravelObjectEvent> GetVesselTravelEvents(VesselComponent vessel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<TravelObjectEvent> GetTravelObjectsEvents(List<IGGuid> travelObjectIds) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Load(SerializedTravelLog travelLogDataFromSave) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Save(ref SerializedTravelLog newSaveData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClearLists() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<IGGuid> GetAllVesselTravelObjectIDs() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TravelLogManager() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static TravelLogManager() => throw null;
  }
}
