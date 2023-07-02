// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_AeroSurface
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
    [Tooltip("This is the cased (inclosed) max temp for the part skin.")]
    [KSPDefinition]
    public float CasedMaxTemp;
    [KSPDefinition]
    [Tooltip("Set true if deployment should be reversed angle.")]
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
