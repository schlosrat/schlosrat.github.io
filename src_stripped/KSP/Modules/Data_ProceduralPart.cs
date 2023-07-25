// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_ProceduralPart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.OAB;
using KSP.Sim;
using KSP.Sim.Definitions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.Modules
{
  [Serializable]
  public sealed class Data_ProceduralPart : 
    ModuleData,
    IMassModifier,
    IResourceCostModifier,
    IMultiJointScaleModifier
  {
    [HideInInspector]
    [FormerlySerializedAs("TargetPartIndex")]
    [KSPState]
    public int meshOptionIndex;
    [HideInInspector]
    [KSPState]
    public Dictionary<string, float> sliderData;
    [KSPState]
    [HideInInspector]
    public Dictionary<string, bool> toggleData;
    [HideInInspector]
    [KSPState]
    public Dictionary<string, bool> visibleMeshData;
    [KSPState]
    [HideInInspector]
    public float MassModifierAmount;
    [HideInInspector]
    [KSPState]
    public float ResourceCostModifierAmount;
    [KSPState]
    [HideInInspector]
    [JsonIgnore]
    public DragCube MeshCube;
    [Tooltip("Part density is the initially set mass from the part prefab / the initial default mesh area.\nIt is used to modify the mass and cost of the procedural part based on the shape set by the player at runtime.\nIf you do not set this value (or reset it to -1) it will be calculated and set when you export the prefab to the part JSON file.")]
    [KSPDefinition]
    public float BasePartDensity;
    [KSPState]
    [JsonIgnore]
    [HideInInspector]
    public ProceduralPartDefinition ProceduralPartDefinition;
    [KSPDefinition]
    public string ProceduralPartTypeName;
    [Tooltip("Set this string to the Name of the slider in the OffsetSliderSystem that you want to use to set the joint positions along for a multi-joint part that is set to use a single axis.")]
    [KSPDefinition]
    public string PartMultiJointScaleSliderKey;
    [KSPState]
    [HideInInspector]
    public float PartMultiJointLength;

    public override System.Type ModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Copy(ModuleData sourceModuleData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsDefaultValues() => throw null;

    public float MassModifier
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float ResourceCostModifier
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float JointScaleModifier
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Data_ProceduralPart() => throw null;
  }
}
