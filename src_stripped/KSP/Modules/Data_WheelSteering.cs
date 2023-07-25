// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_WheelSteering
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.Definitions;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  [Serializable]
  public sealed class Data_WheelSteering : ModuleData
  {
    [KSPDefinition]
    [Tooltip("This is the caliper transform name (Steering point)")]
    public string CaliperTransformName;
    [KSPDefinition]
    [Tooltip("This curve defines the rate of wheel turn related to the speed of the wheel.\nThe x values of the curve are the speed and the y values are the rate of wheel turn.")]
    public FloatCurve SteeringCurve;
    [Tooltip("This curve defines the maximum steering angle of wheel as a multiplier that will be applied based on the speed of the wheel.\nThe x values of the curve is the speed and the y values are the multiplier. y values are clamped between 0 and 1.")]
    [KSPDefinition]
    public FloatCurve SteeringMaxAngleCurve;
    [Tooltip("This is how fast the wheel will turn/respond to player input.")]
    [KSPDefinition]
    public float SteeringResponse;
    [HideInInspector]
    [KSPState]
    public float SteeringRange;
    [PAMDisplayControl(SortIndex = 1)]
    [KSPState(CopyToSymmetrySet = true)]
    [LocalizedField("PartModules/Wheels/SteeringEnabled")]
    public ModuleProperty<bool> SteeringEnabled;
    [KSPState(CopyToSymmetrySet = true)]
    [LocalizedField("PartModules/Wheels/SteeringDirection")]
    [PAMDisplayControl(SortIndex = 2)]
    public ModuleProperty<bool> SteeringInvert;
    [LocalizedField("PartModules/Wheels/SteeringAdjust")]
    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(SortIndex = 8)]
    [Tooltip("If true steeringCurve and steeringMaxAngleCurve will be applied to the wheel steering.\nIf false the curves will not be applied and the values set via advanced tweakable sliders are applied instead.")]
    public ModuleProperty<bool> AutoSteeringAdjust;
    [LocalizedField("PartModules/Wheels/SteeringAngleLimiter")]
    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(SortIndex = 9)]
    [SteppedRange(0.05f, 10f, 0.05f)]
    public ModuleProperty<float> AngleTweakable;
    [LocalizedField("PartModules/Wheels/SteeringResponse")]
    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(SortIndex = 10)]
    [SteppedRange(0.05f, 10f, 0.05f)]
    public ModuleProperty<float> ResponseTweakable;

    public override System.Type ModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetEnabledString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetInvertedString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetSteeringAdjustString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetAngleTweakableString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetSteeringResponseTweakableString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal override List<OABPartData.PartInfoModuleEntry> GetPartInfoEntries(
      System.Type partBehaviourModuleType,
      List<OABPartData.PartInfoModuleEntry> delegateList)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetSteeringRangeStrings(OABPartData.OABSituationStats oabSituationStats) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Data_WheelSteering() => throw null;
  }
}
