// Decompiled with JetBrains decompiler
// Type: KSP.OAB.IObjectAssemblyAvailablePart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using System.Collections.Generic;
using UnityEngine;

namespace KSP.OAB
{
  public interface IObjectAssemblyAvailablePart
  {
    PartData PartData { get; }

    IObjectAssemblyResource[] Resources { get; }

    IObjectAssemblyAvailablePartNode[] Nodes { get; }

    PartCategories Category { get; }

    string Family { get; }

    AssemblySizeFilterType Size { get; }

    List<AssemblyPartsFuelTypeFilter> ResourceContainers { get; }

    List<AssemblyPartsFuelTypeFilter> ResourceConsumables { get; }

    List<AssemblyPartsCostFilter> ResourceGenerators { get; }

    List<PartResourceCostDefinition> ResourceCosts { get; }

    AssemblyPartsTechLevelFilter TechLevel { get; }

    AssemblyPartTypeFilter PartType { get; }

    int CrewCapacity { get; }

    float Mass { get; }

    float TotalMass { get; }

    float CrashTolerance { get; }

    double MaxTemp { get; }

    Vector3 SurfaceAttachmentPositionOffset { get; }

    Quaternion SurfaceAttachmentRotationOffset { get; }

    float SurfaceAttachmentVisualSize { get; }

    Quaternion BaseAttachmentRotation { get; }

    Vector3 PickUpPointOffset { get; }

    Vector3 PickupRotationPointOffset { get; }

    string Title { get; }

    string Name { get; }

    string Description { get; }

    string Tags { get; }

    bool CanAttachToSurfaces { get; }

    bool CanHaveSurfaceAttachedTo { get; }

    bool IsCompound { get; }

    MirrorTechnique MirrorTechnique { get; }

    OABOrientation OrientationPreference { get; }

    bool CanSuggestOrientation { get; }

    bool FuelCrossFeed { get; }

    OABEditorPartCategory EditorPartCategory { get; }

    AssemblyPartStageType StageType { get; }

    string StagingIconAssetAddress { get; }

    GameObject ModelPrefab { get; set; }

    bool VisualsLoaded { get; }

    IObjectAssemblyPart CreateEditorPart(
      List<SerializedPartModule> rawModuleData,
      ObjectAssemblyAssets prefabs);
  }
}
