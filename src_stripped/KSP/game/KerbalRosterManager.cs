// Decompiled with JetBrains decompiler
// Type: KSP.Game.KerbalRosterManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Assets;
using KSP.Messages;
using KSP.Networking.MP.Utils;
using KSP.OAB;
using KSP.Sim;
using KSP.Sim.impl;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game
{
  public class KerbalRosterManager : IUpdate
  {
    public static KerbalRosterGlobalSettings KERBAL_ROSTER_GLOBAL_SETTINGS;
    private static uint RARE_KERBAL_SPAWN_INTERVAL;
    private const string KERBAL_ROSTER_GLOBAL_SETTINGS_ASSET_TAG = "KerbalRosterGlobalSettings.asset";
    private const string KSC_SIMOBJECT_KEY = "kerbin_KSC_Object";
    private const string KERBAL_PHOTO_BOOTH_KEY = "KerbalPhotoBooth.prefab";
    private const string EVA_KERBAL_PART_NAME = "eva_kerbal";
    private KerbalVarietySystem _varietySystem;
    private static MPRandom _randomizer;
    private DictionaryValueList<IGGuid, KerbalInfo> _kerbals;
    private Dictionary<string, IGGuid> _lookupNameTable;
    private Dictionary<string, List<IGGuid>> _lookupNetworkTable;
    private Dictionary<IGGuid, List<KerbalInfo>> _lookupSimObjectTable;
    private uint _totalKerbalSpawnCount;
    private Dictionary<string, KerbalInfo> _customKerbals;
    private Dictionary<string, uint> _veteranKerbalRefresh;
    private Dictionary<string, bool> _lookupCustomKerbalIsVeteran;
    private KerbalPhotoBooth _portraitRenderer;
    private bool _isVarietySystemReady;
    private bool _isUpdateRegistered;
    private List<string> _uncommonKerbalsReadyToBeSpawned;
    private List<string> _rareKerbalsReadyToBeSpawned;
    private List<string> _veteranKerbalsReadyToBeSpawned;
    private bool _isKerbalAssemblyTemplateInitialized;
    private double _kerbalIVAMass;
    private SimulationObjectModel _ksc;
    private KerbalRosterManager.CustomKerbalHandlingOptions _defaultCustomKerbalOptions;

    public GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public AssetProvider Assets
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public uint TotalKerbalSpawnCount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public KerbalVarietySystem VarietySystem
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public SerializedAssembly KerbalAssemblyTemplate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool IsKerbalAssemblyTemplateInitialized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double KerbalIVAMass
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IGGuid KSCGuid
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private IGGuid _kscGuid
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Shutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Load(SerializedKerbalRoster rosterFromSave) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LoadKerbalRosterGlobalSettingsAsset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemoveCustomNameKeyWeAreAboutToUse(string customKerbalKey) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResetCustomKerbalListsIfNeeded() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResetKerbalListByOriginType(ref List<string> kerbalList, KerbalOriginType origin) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Save(ref SerializedKerbalRoster newSaveData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KerbalInfo CreateKerbal(
      KerbalRosterManager.CustomKerbalHandlingOptions customKerbalOptions = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KerbalInfo CreateKerbal(
      double enrollmentUT,
      KerbalRosterManager.CustomKerbalHandlingOptions customKerbalOptions = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KerbalInfo CreateKerbalByName(string firstNameOrKey) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KerbalInfo CreateKerbalByName(double enrollmentUT, string firstNameOrKey) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KerbalInfo CreateKerbal(
      double enrollmentUT,
      string firstNameOrKey,
      string playerGuidString,
      KerbalRosterManager.CustomKerbalHandlingOptions customKerbalOptions = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private KerbalInfo AddKerbalToRoster(
      KerbalInfo kerbalInfo,
      double enrollmentUT,
      string playerGuidString)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KerbalInfo CreateKerbalFromNetwork(
      IGGuid kerbalInfoID,
      SerializedKerbalInfo serializedKerbalInfo)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool DestroyKerbal(IGGuid kerbalId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SetKerbalLocation(
      KerbalInfo kerbal,
      SimulationObjectModel simObject,
      int positionIndex)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SetKerbalLocation(
      IGGuid kerbalId,
      IGGuid simObjectId,
      IGGuid secondaryId,
      int positionIndex)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SetKerbalLocation(
      KerbalInfo kerbal,
      IGGuid simObjectId,
      IGGuid secondaryId,
      int positionIndex)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool SetKerbalLocationInternal(
      KerbalInfo kerbal,
      IGGuid simObjectId,
      IGGuid secondaryId,
      int positionIndex)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SwapKerbalLocation(IGGuid kerbalAId, IGGuid kerbalBId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SwapKerbalLocation(KerbalInfo kerbalA, KerbalInfo kerbalB) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<KerbalInfo> GetAllKerbals() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetCustomKerbalCount() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KerbalInfo FindCustomKerbalByKey(string customNameKey) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetKerbalByName(string fullname, out KerbalInfo info) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool KerbalExists(string fullname) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsSeatOccupied(IGGuid simObjectId, IGGuid secondaryId, int positionIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetKerbalByID(IGGuid id, out KerbalInfo info) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetKerbalBySimObjectAndIdx(
      IGGuid simObjectId,
      int positionIndex,
      out KerbalInfo foundKerbal)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetKerbalBySimObjectsecondaryIdAndIdx(
      IGGuid simObjectId,
      IGGuid secondaryId,
      int positionIndex,
      out KerbalInfo foundKerbal)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<KerbalInfo> GetAllKerbalsInSimObject(IGGuid simObjectId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<KerbalInfo> GetAllKerbalsInSimAndSubObject(IGGuid simObjectId, IGGuid secondaryId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<KerbalInfo> GetAllKerbalsInVessel(IGGuid vesselId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<KerbalInfo> GetAllKerbalsInAssembly(IGGuid simObjectId, IObjectAssembly assembly) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<KerbalInfo> GetAllKerbalsInAssemblyPart(
      IGGuid simObjectId,
      IObjectAssemblyPart assemblyPart)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddSimObjectLookup(IGGuid simObjectId, KerbalInfo kerbalInfo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemoveSimObjectLookup(IGGuid simObjectId, KerbalInfo kerbalInfo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string AddCustomKerbalByNameKey(double enrollmentUT, string customKeyNameToCreate) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCelestialBodiesLoaded(MessageCenterMessage message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetKerbalAssemblyTemplate(SerializedAssembly newKerbalAssemblyTemplate) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPartDestroyed(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselRecovered(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnAssemblyPartDeleted(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnOABLoaded(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnOABUnloaded(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnNewOABWorkspace() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KerbalInfo DeserializeAndAddKerbal(string jsonString) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<KerbalInfo> GetKerbalsByPlayerId(string playerGuidString) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetKerbalsAsJson(string playerGuidString) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KerbalInfo AddKerbalsfromJson(string data, string playerGuidString) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GenerateCustomKerbalLookups() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnKerbalPhotoBoothLoaded(GameObject photoBoothPrefab) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GenerateKerbalPortrait(KerbalInfo kerbalInfo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KerbalRosterManager() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static KerbalRosterManager() => throw null;

    public class CustomKerbalHandlingOptions
    {
      public bool CanCreateNewVeterans;
      public bool CanCreateNewNonVeterans;
      public bool CanReuseNonVeteranKerbals;
      public bool CanReuseVeteranKerbals;

      public bool CanCreateAnyCustomKerbals
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public bool CanReuseAnyCustomKerbals
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public CustomKerbalHandlingOptions() => throw null;
    }
  }
}
