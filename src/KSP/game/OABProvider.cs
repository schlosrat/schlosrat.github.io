// Decompiled with JetBrains decompiler
// Type: KSP.Game.OABProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Messages;
using KSP.OAB;
using KSP.Sim;
using KSP.Sim.impl;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game
{
  public class OABProvider
  {
    [HideInInspector]
    public readonly Dictionary<OABProvider.LaunchLocation, string> LAUNCH_LOCATIONS;
    public const string KERBIN_ID = "Kerbin";
    public const string DEFAULT_LAUNCHPAD_ID = "LaunchPad_spawn_01";
    public const string OAB_ID = "ksc_vab_center";
    public const string KSC_CAMERA_ORIGIN = "KSCCameraOrigin";
    public const string KSC_CAMERA_LOOK_AT = "KSCCameraLookAt";
    public const string KSC_SURF_OBJ_NAME = "KSC - Updated";
    public const string OAB_ADDRESSABLE_PATH = "OAB.prefab";
    public const double DEFAULT_LAUNCH_OVERLAP_RADIUS = 100.0;
    public const double DEFAULT_APPROXIMATE_RANGE_CHECK = 100.0;
    public const double DEFAULT_LAUNCH_OVERLAP_RADIUS_SQUARED = 10000.0;
    public const int DEFAULT_PART_SEED_COUNTER_VALUE = 0;
    private string selectedLaunchSiteID;
    private OABProvider.BusyInfoData _busyInfo;
    private Coroutine _loadingCoroutine;
    private GameInstance _game;
    private SubscriptionHandle _handleOnOabLoaded;
    private SubscriptionHandle _handleOnOabUnloaded;
    private int _partSeedCounterValue;
    private bool _skipSaveBackupVessel;
    private bool _openedInTutorial;

    public ObjectAssemblyBuilder Current
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool IsLoaded
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsBusy() => throw null;

    public OABProvider.BusyInfoData BusyInfo
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Coroutine LoadingCoroutine
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OABProvider(GameInstance game) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnCurrentObjectAssemblyBuilderReset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Shutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLaunchSite(OABProvider.LaunchLocation launchSiteID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsSelectedLaunchSiteAvailable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool DoesCollideWithNearbyParts(IObjectAssembly mainAssembly) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CheckSelectedLaunchSiteAvailabilityAndReturnVessels(
      ref List<VesselComponent> nearbyVessels)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CheckLaunchSiteAvailabilityAndReturnVessels(
      string launchLocation,
      ref List<VesselComponent> nearbyVessels)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearVesselsAtSelectedLaunchSite() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearVesselsAtLaunchSite(string launchLocation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetLaunchLocationID() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Position GetSurfaceLaunchPosition(string celestialBodyName, string launchPadName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SerializedLocation GetSurfaceLaunchLocation(string launchLocationName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SerializedLocation GetOrbitalLaunchLocation(double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedLocation GetCurrentLaunchLocation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetPartSeedCounterValue() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPartSeedCounterValue(int partSeedCounterValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetPartSeedCounterValue() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetNextPartSeedCounterValueAndAdvance() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetBusy(
      OABVariant variant,
      OABEnvironmentType environmentType,
      OABConstructionType constructor)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearBusy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnBatchStarted(
      OABVariant variant,
      OABEnvironmentType environmentType,
      OABConstructionType constructor)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnBatchFinished() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void VesselInVABNoLaunch() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void VesselOnLaunchpadViaVAB(Action onLaunchCallback = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void VesselInOrbitViaVAB(Action onLaunchCallback = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PlaneOnRunwayViaVAB(Action onLaunchCallback = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PlaneInOABNoLaunch() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static OABProvider.LaunchLocation LaunchLocationNameToEnum(string location) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OABProvider.LaunchLocation LaunchLocationObjectNameToEnum(string spawnPointObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string LaunchLocationToSpawnName(OABProvider.LaunchLocation location) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool LocationIsKSCLaunchpad(OABProvider.LaunchLocation location) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool LocationIsKSCRunway(OABProvider.LaunchLocation location) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool LocationIsKSCBoatLaunch(OABProvider.LaunchLocation location) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsTimelineLaunchLocation(OABProvider.LaunchLocation location) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ShowOAB(
      OABConfig config,
      OABHistoricalSnapshot snapshot = null,
      Action onLaunchCallback = null,
      Action onShowCompleteCallback = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HideOAB() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator SpawnAfterFade(
      OABConfig config,
      OABHistoricalSnapshot startingSnapshot,
      Action onLaunchCallback,
      Action onShowCompleteCallback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SaveOABInStateTracker(
      SerializedAssembly assembly,
      Action<SerializedAssembly> onComplete)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HandleLaunchButtonPressforMPSpectators(string globalIdStringOfVessel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SpawnAssembly(
      SerializedAssembly assembly,
      bool replaceExistingSimObject = false,
      bool preserveOrientation = true,
      bool fillCommandPartsForControl = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnOabUnloaded(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnOabLoaded(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool IsAnyPartWithinRadius(Position position, VesselComponent vessel) => throw null;

    public class BusyInfoData
    {
      public const int NO_MS = -1;
      public const bool DEFAULT_BUSY_FLAG = false;
      public const OABVariant DEFAULT_OAB_VARIANT = OABVariant.VAB;
      public const OABEnvironmentType DEFAULT_OAB_ENVIRONMENT_TYPE = OABEnvironmentType.None;
      public const OABConstructionType DEFAULT_OAB_CONSTRUCTION_TYPE = OABConstructionType.User;
      public const long DEFAULT_TIME_STAMP = 0;
      public const int DEFAULT_MS = -1;
      private bool _busyFlag;
      private OABVariant _oabVariant;
      private OABEnvironmentType _oabEnvironmentType;
      private OABConstructionType _oabConstructionType;
      private long _timeStamp;
      private int _ms;

      public bool BusyFlag
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public OABVariant OABVariant
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public OABEnvironmentType OABEnvironmentType
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public OABConstructionType OABConstructionType
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public int MS
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public BusyInfoData() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void ResetAllValues() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Set(
        OABVariant oabVariant,
        OABEnvironmentType oabEnvironmentType,
        OABConstructionType oabConstructionType)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Clear() => throw null;
    }

    public enum LaunchLocation : byte
    {
      Invalid,
      Launchpad_1,
      Launchpad_2,
      Launchpad_3,
      Launchpad_4,
      Runway_1,
      Runway_2,
      Boat_Launch,
      Other,
    }
  }
}
