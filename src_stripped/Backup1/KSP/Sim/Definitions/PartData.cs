// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.PartData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.OAB;
using KSP.Sim.ResourceSystem;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.Sim.Definitions
{
  [Serializable]
  public class PartData
  {
    [Tooltip("A unique key for the part - appears in save files, not user facing.")]
    [Header("Meta data")]
    public string partName;
    [Tooltip("The name of the person or people working on the part")]
    public string author;
    [Header("Descriptors")]
    public PartCategories category;
    public string family;
    public int childStageOffset;
    public int cost;
    public int crewCapacity;
    public int stageOffset;
    public bool isCompound;
    public MetaAssemblySizeFilterType sizeCategory;
    public AssemblyPartStageType stageType;
    public List<PartResourceCostDefinition> resourceCosts;
    public string tags;
    public string stagingIconAssetAddress;
    public double PartSizeDiameter;
    [Header("Properties")]
    public double angularDrag;
    public double breakingForce;
    public double breakingTorque;
    public double buoyancy;
    public bool buoyancyUseSine;
    public Vector3 coLiftOffset;
    public Vector3 coMassOffset;
    [FormerlySerializedAs("coPositionOffset")]
    public Vector3 coPressureOffset;
    public Vector3 coBuoyancy;
    public Vector3 coDisplacement;
    public double crashTolerance;
    public double explosionPotential;
    public bool fuelCrossFeed;
    public double heatConductivity;
    public double mass;
    public double maxTemp;
    public AttachRules attachRules;
    public List<AttachNodeDefinition> attachNodes;
    public List<ContainedResourceDefinition> resourceContainers;
    public bool AllowKinematicPhysicsIfIntersectTerrain;
    [HideInInspector]
    public List<SerializedPartModule> serializedPartModules;
    [HideInInspector]
    public SerializedResourceInfo resourceSummary;
    [Header("Parts Manager Overrides")]
    public List<PartsManagerCore.SerializedPartModuleDisplayOrder> PAMModuleSortOverride;
    public List<PartsManagerCore.SerializedPartModuleDisplayVisuals> PAMModuleVisualsOverride;
    [Header("Editor")]
    public Vector3 collisionVolumeBoundsScale;
    [Header("Captured but unsorted")]
    public double emissiveConstant;
    public double maximumDrag;
    public double minimumDrag;
    public PartPhysicsModes physicsMode;
    public bool inverseStageCarryover;
    public double skinMassPerArea;
    public bool bodyLiftOnlyUnattachedLift;
    public string bodyLiftOnlyAttachName;
    public int maxLength;
    public double radiatorHeadroom;
    public double radiatorMax;
    public double skinMaxTemp;
    public double skinInternalConductionMult;
    public double thermalMassModifier;
    public string buoyancyUseCubeNamed;
    [Header("OAB Settings")]
    public OABEditorPartCategory oabEditorCategory;
    public AssemblyPartTypeFilter partType;
    [Tooltip("Allows a part to specify what orientation it considers its primary. The mode specified will see the part oriented similarly to how it is in the prefab by default. The part will try to maintain this orientation regardless of VAB mode.")]
    public OABOrientation PreferredOrientation;
    [Tooltip("Allows specifying what type of mirror logic is used for this part. May impact how other parts interact with it. The Auto setting is configurable on OAB.prefab")]
    public MirrorTechnique MirrorTechnique;
    [Tooltip("Based on all of the other settings, from orientation preference to mirror technique and category, suggest a rotation for this part only if no use rotation is provided. By default, no suggestions are made.")]
    public bool CanSuggestOrientation;
    [Tooltip("Offset at which the player cursor \"grabs\" the part when in OAB")]
    public Vector3 PickUpPointOffset;
    [Tooltip("Offset at which the part is rotated in the OAB when the player is grabbing a part")]
    public Vector3 PickupRotationPointOffset;
    private string _title;
    private string _subtitle;
    private string _description;
    private string _manufacturer;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static PartData FromPartProperties(PartProperties other) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal bool TryGetPAMModuleSortOverride(System.Type partComponentModuleType, out int sortIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal bool TryGetPAMModuleDisplayOverride(
      System.Type partComponentModuleType,
      out PartsManagerCore.SerializedPartModuleDisplayVisuals visuals)
    {
      throw null;
    }

    public string Title
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string Subtitle
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string Manufacturer
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string Description
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetLocalizationCache() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartData() => throw null;
  }
}
