// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_ProceduralPart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
  public sealed class Data_ProceduralPart : ModuleData, IMassModifier, IResourceCostModifier
  {
    [HideInInspector]
    [KSPState]
    [FormerlySerializedAs("TargetPartIndex")]
    public int meshOptionIndex;
    [HideInInspector]
    [KSPState]
    public Dictionary<string, float> sliderData;
    [HideInInspector]
    [KSPState]
    public Dictionary<string, bool> toggleData;
    [KSPState]
    [HideInInspector]
    public Dictionary<string, bool> visibleMeshData;
    [KSPState]
    [HideInInspector]
    public float MassModifierAmount;
    [KSPState]
    [HideInInspector]
    public float ResourceCostModifierAmount;
    [HideInInspector]
    [JsonIgnore]
    [KSPState]
    public DragCube MeshCube;
    [Tooltip("Part density is the initially set mass from the part prefab / the initial default mesh area.\nIt is used to modify the mass and cost of the procedural part based on the shape set by the player at runtime.\nIf you do not set this value (or reset it to -1) it will be calculated and set when you export the prefab to the part JSON file.")]
    [KSPDefinition]
    public float BasePartDensity;
    [KSPState]
    [HideInInspector]
    [JsonIgnore]
    public ProceduralPartDefinition ProceduralPartDefinition;
    [KSPDefinition]
    public string ProceduralPartTypeName;

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

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Data_ProceduralPart() => throw null;
  }
}
