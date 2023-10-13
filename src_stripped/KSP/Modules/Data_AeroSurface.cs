// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_AeroSurface
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Sim;
using KSP.Sim.Definitions;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  [Serializable]
  public sealed class Data_AeroSurface : ModuleData
  {
    [KSPDefinition]
    [Tooltip("This is the uncased max temp for the part skin.")]
    [Header("Aero Surface")]
    public float UncasedMaxTemp;
    [KSPDefinition]
    [Tooltip("This is the cased (inclosed) max temp for the part skin.")]
    public float CasedMaxTemp;
    [Tooltip("Set true if deployment should be reversed angle.")]
    [KSPDefinition]
    public bool BrakeDeployInvert;
    public ModuleProperty<bool> IsBraking;

    public override System.Type ModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetAuthorityLimiterString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetDeployAngleString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Data_AeroSurface() => throw null;
  }
}
