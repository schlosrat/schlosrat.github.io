// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_Decouple
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Sim;
using KSP.Sim.Definitions;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  [Serializable]
  public sealed class Data_Decouple : ModuleData
  {
    [PAMDisplayControl(SortIndex = 2)]
    [KSPState(CopyToSymmetrySet = true)]
    [SteppedRange(1f, 15f, 1f)]
    [LocalizedField("PartModules/Decoupler/Impulse")]
    public ModuleProperty<float> EjectionImpulse;
    [HideInInspector]
    [KSPState(CopyToSymmetrySet = false)]
    [PAMDisplayControl(ExcludeFromContext = true)]
    public ModuleProperty<bool> isDecoupled;
    [KSPDefinition]
    public float ejectionForce;
    [KSPDefinition]
    public bool IsStageable;
    [KSPDefinition]
    public bool isOmniDecoupler;
    [KSPDefinition]
    public bool automaticDir;
    [KSPDefinition]
    public string explosiveNodeID;
    [KSPDefinition]
    public string anchorName;

    public override System.Type ModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetImpulseString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Copy(ModuleData sourceModuleData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal override List<OABPartData.PartInfoModuleEntry> GetPartInfoEntries(
      System.Type partBehaviourModuleType,
      List<OABPartData.PartInfoModuleEntry> delegateList)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetEjectionForce(OABPartData.OABSituationStats oabSituationStats) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Data_Decouple() => throw null;
  }
}
