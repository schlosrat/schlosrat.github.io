// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_CompoundPart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Animation;
using KSP.Sim;
using KSP.Sim.Definitions;
using KSP.Sim.impl;
using Newtonsoft.Json;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  [Serializable]
  public class Data_CompoundPart : ModuleData
  {
    [KSPDefinition]
    [Tooltip("Name of the starting anchor object to place at the start anchor end of the compound part.\nIf this is blank then it is assumed the whole part prefab model is placed at the start anchor end.\nYou Must supply both a StartAnchorName and EndAnchorName to use this feature.")]
    public string StartAnchorName;
    [KSPDefinition]
    [Tooltip("Transform where to place the linker/connector object at the start point of the compound part.\nIf this is blank the linker will be placed at the start anchor part transform position")]
    public string StartAnchorTransform;
    [KSPDefinition]
    [Tooltip("Optional Transform that will be made to look at the other Anchor.")]
    public string StartAnchorLookTransform;
    [KSPDefinition]
    [Tooltip("Name of the ending anchor object to place at the end anchor end of the compound part.\nIf this is blank then it is assumed the whole part prefab model is placed at the end anchor end.\nYou Must supply both a StartAnchorName and EndAnchorName to use this feature.")]
    public string EndAnchorName;
    [Tooltip("Transform where to place the linker/connector object at the end point of the compound part.\nIf this is blank the linker will be placed at the end anchor part transform position")]
    [KSPDefinition]
    public string EndAnchorTransform;
    [Tooltip("Optional Transform that will be made to look at the other Anchor.")]
    [KSPDefinition]
    public string EndAnchorLookTransform;
    [Tooltip("Name of the the linker/connector object transform which should be part of the part model.")]
    [KSPDefinition]
    public string LinkerName;
    [KSPDefinition]
    public float LinkerMinLength;
    [KSPDefinition]
    public float LinkerMaxLength;
    [KSPState(CopyToSymmetrySet = false)]
    public IGGuid OtherEndAnchor;
    [KSPState(CopyToSymmetrySet = true)]
    public bool IsFirstAnchor;
    [KSPState(CopyToSymmetrySet = false)]
    public Vector3 LocalOffset;
    [KSPState(CopyToSymmetrySet = true)]
    public bool DisconnectedAnchor;
    [KSPState(CopyToSymmetrySet = true)]
    public SymmetrySetData DisconnectedAnchorSymmetryData;
    [JsonIgnore]
    public StackObjectsBetweenTwoPoints LinkerObject;

    public override System.Type ModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Copy(ModuleData sourceModuleData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void UpdateGuids(IGGuid oldGuid, IGGuid newGuid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Data_CompoundPart() => throw null;
  }
}
