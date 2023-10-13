// Decompiled with JetBrains decompiler
// Type: OABPartData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.OAB;
using KSP.Sim.Definitions;
using KSP.Sim.impl;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class OABPartData : IObjectAssemblyAvailablePart
{
  private List<Dictionary<string, object>> legacyModules;
  private List<OABPartData.PartInfoModuleEntry> partInfoModuleEntries;
  private static GameObject placeholder_cylinder;
  private static GameObject placeholder_cube;
  private static GameObject placeholder_sphere;
  private int _maxSizeFilterType;
  private IObjectAssemblyAvailablePartNode[] _partNodes;
  private List<IObjectAssemblyResource> resources;
  private GameObject _modelPrefab;
  private static Dictionary<System.Type, List<System.Type>> _partInfoCrossModuleAdditions;
  private Dictionary<System.Type, List<OABPartData.PartInfoModuleEntry>> _lookupPartInfoModuleDelegates;
  public static OABPartData.OABSituationStats DefaultOABSituationStats;

  public PartData PartData
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
  }

  public List<ModuleData> Modules
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public OABPartData(PartCore core) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static void LazilyCreatePlaceholderParts() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private GameObject GetPlaceholderPrefab() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void RemovePlaceholderParts() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public T GetModuleData<T>() where T : ModuleData => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static void SetMaterialColor(GameObject obj, Color color) => throw null;

  public OABEditorPartCategory oabEditorCategory
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public AssemblyPartTypeFilter PartType
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public IObjectAssemblyResource[] Resources
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public IObjectAssemblyAvailablePartNode[] Nodes
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public PartCategories Category
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public string Family
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public OABEditorPartCategory EditorPartCategory
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public AttachNodeDefinition? SurfaceAttachDefinition
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public Vector3 SurfaceAttachmentPositionOffset
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public float SurfaceAttachmentVisualSize
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public Quaternion SurfaceAttachmentRotationOffset
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public Quaternion BaseAttachmentRotation
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public Vector3 PickUpPointOffset
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public Vector3 PickupRotationPointOffset
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public Vector3 CollisionVolumeBoundsScale
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public string Name
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public string Description
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public string Tags
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public bool CanAttachToSurfaces
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public bool CanHaveSurfaceAttachedTo
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public AssemblyPartStageType StageType
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public string StagingIconAssetAddress
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public bool VisualsLoaded
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public AssemblySizeFilterType Size
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public List<AssemblyPartsFuelTypeFilter> ResourceContainers
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public List<AssemblyPartsFuelTypeFilter> ResourceConsumables
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public List<PartResourceCostDefinition> ResourceCosts
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public List<AssemblyPartsCostFilter> ResourceGenerators
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public AssemblyPartsTechLevelFilter TechLevel
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public float Mass
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public float WetMass
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public float TotalMass
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public string Title
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public int CrewCapacity
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public float CrashTolerance
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public float ExplosionPotential
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public float ImpactTolerance
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public double MaxTemp
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public string SubCategory
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public bool IsCompound
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public MirrorTechnique MirrorTechnique
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public OABOrientation OrientationPreference
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public bool CanSuggestOrientation
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public bool FuelCrossFeed
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public GameObject ModelPrefab
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public IObjectAssemblyPart CreateEditorPart(
    List<SerializedPartModule> rawPartModules,
    ObjectAssemblyAssets prefabs)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool TryGetPartInfoModuleEntries(
    System.Type partBehaviourType,
    out List<OABPartData.PartInfoModuleEntry> delegates)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void PreparePartInfoData() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void AddPartInfoModuleData(System.Type partBehaviourModuleType, SerializedPartModule sourceSPM) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public object FindLegacyModuleObject(System.Type moduleType, string attributeName) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static OABPartData() => throw null;

  public class OABSituationStats
  {
    public double PressureAtm;
    public CelestialBodyComponent OABCelestialBody;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OABSituationStats() => throw null;
  }

  public class PartInfoModuleEntry
  {
    public string DisplayName;

    public OABPartData.PartInfoModuleEntryValueDelegate ValueDelegate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public OABPartData.PartInfoModuleMultipleEntryValueDelegate MultiValueDelegate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartInfoModuleEntry(string displayName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartInfoModuleEntry(
      string displayName,
      OABPartData.PartInfoModuleEntryValueDelegate valueDelegate)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartInfoModuleEntry(
      string displayName,
      OABPartData.PartInfoModuleMultipleEntryValueDelegate multiValueDelegate)
    {
      throw null;
    }
  }

  public class PartInfoModuleSubEntry
  {
    public string SubEntryName;

    public string SubEntryValue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public List<OABPartData.PartInfoModuleSubEntry> SubEntryMultiValues
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartInfoModuleSubEntry(string subEntryName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartInfoModuleSubEntry(string subEntryName, string subEntryValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartInfoModuleSubEntry(
      string subEntryName,
      List<OABPartData.PartInfoModuleSubEntry> subEntryMultiValues)
    {
      throw null;
    }
  }

  public delegate string PartInfoModuleEntryValueDelegate(
    OABPartData.OABSituationStats oabSituationStats);

  public delegate List<OABPartData.PartInfoModuleSubEntry> PartInfoModuleMultipleEntryValueDelegate(
    OABPartData.OABSituationStats oabSituationStats);
}
