// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.PartProperties
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.OAB;
using KSP.Sim.ResourceSystem;
using MoonSharp.Interpreter;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.Definitions
{
  public struct PartProperties
  {
    public string partName;
    public string model;
    public float angularDrag;
    public Vector3 centerOfMassOffset;
    public Vector3 centerOfPressureOffset;
    public Vector3 centerOfLiftOffset;
    public float mass;
    public float maximumDrag;
    public double maxTemp;
    public float minimumDrag;
    public bool activatesEvenIfDisconnected;
    public float alphaCutoff;
    public string author;
    public bool bodyLiftOnlyUnattachedLift;
    public string bodyLiftOnlyAttachName;
    public float buoyancy;
    public bool buoyancyUseSine;
    public Vector3 boundsCentroidOffset;
    public float boundsMultiplier;
    public float breakingForce;
    public float breakingTorque;
    public string bulkheadProfiles;
    public string category;
    public string family;
    public Vector3 centerOfBuoyancy;
    public Vector3 centerOfDisplacement;
    public int childStageOffset;
    public OABEditorPartCategory oabEditorCategory;
    public int cost;
    public float crashTolerance;
    public int crewCapacity;
    public string description;
    public string dragModelType;
    public double emissiveConstant;
    public int entryCost;
    public float explosionPotential;
    public bool fuelCrossFeed;
    public double heatConductivity;
    public double heatConvectiveConstant;
    public Vector3 iconCenter;
    public bool inverseStageCarryover;
    public bool isCompound;
    public string manufacturer;
    public int maxLength;
    public Vector3 mirrorRefAxis;
    public bool noAutoEvaMulti;
    public double radiatorHeadroom;
    public double radiatorMax;
    public bool resourcePriorityUseParentInverseStage;
    public int rimFalloff;
    public string partType;
    public PartPhysicsModes physicsMode;
    public double scale;
    public MetaAssemblySizeFilterType sizeCategory;
    public double skinMassPerArea;
    public double skinMaxTemp;
    public double skinInternalConductionMult;
    public bool skipColliderIgnores;
    public float specPower;
    public int stackSymmetry;
    public int stageOffset;
    public AssemblyPartStageType stageType;
    public string subcategory;
    public string tags;
    public string stagingIconAssetAddress;
    public string techRequired;
    public string title;
    public double thermalMassModifier;
    public bool allowKinematicPhysicsIfIntersectTerrain;
    public List<Dictionary<string, object>> legacyModules;
    public AttachRules attachRules;
    public List<AttachNodeDefinition> attachNodes;
    public List<ContainedResourceDefinition> resources;
    public List<PartResourceCostDefinition> partCosts;
    public bool containsResources;
    public bool consumesResources;
    public bool generatesResources;
    public List<SerializedPartModule> serializedPartModules;
    public SerializedResourceInfo resourceSummary;
    public List<PartsManagerCore.SerializedPartModuleDisplayOrder> PAMModuleSortOverride;
    public List<PartsManagerCore.SerializedPartModuleDisplayVisuals> PAMModuleVisualsOverride;
    public DynValue modulesUnparsed;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Defaults(out PartProperties defaults) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static PartProperties InferFromPartData(PartData other) => throw null;
  }
}
