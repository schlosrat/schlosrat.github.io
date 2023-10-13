// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_WheelSuspension
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
  public sealed class Data_WheelSuspension : ModuleData
  {
    [KSPDefinition]
    [Tooltip("The Suspension Transform Name")]
    public string suspensionTransformName;
    [Tooltip("The Suspension Offset.\nThis is the offset between the suspension transform and the wheel collider transform.\nThis is a KSP customization.")]
    [KSPDefinition]
    public float suspensionOffset;
    [KSPDefinition]
    [Tooltip("The distance the Suspension moves.\nLength of the suspension travel (m).\nRefer to Suspension settings https://vehiclephysics.com/components/wheel-collider/#suspension-parameters")]
    public float suspensionDistance;
    [KSPDefinition]
    [Tooltip("The Wheel collider Target (anchor) position.\nRelative position in the suspension travel (compression) where the wheel is located at design time.\nIt's a normalized value between 0 and 1 (0 - 100%)\nRefer to Suspension settings https://vehiclephysics.com/components/wheel-collider/#suspension-parameters")]
    public float targetPosition;
    [KSPDefinition]
    [Tooltip("Spring Ratio.\nRefer to Suspension settings https://vehiclephysics.com/components/wheel-collider/#suspension-parameters")]
    public float springRatio;
    [Tooltip("Damper Ratio.\nRefer to Suspension settings https://vehiclephysics.com/components/wheel-collider/#suspension-parameters")]
    [KSPDefinition]
    public float damperRatio;
    [Tooltip("The Boost Ratio. KSP suspension can be boosted.")]
    [KSPDefinition]
    public float boostRatio;
    [Tooltip("The maximum load for the wheel suspension.")]
    [KSPDefinition]
    public float maximumLoad;
    [KSPDefinition]
    [Tooltip("Set true to use mass distrubited across all the vehicles wheels.\nLeave this as true.")]
    public bool useDistributedMass;
    [KSPDefinition]
    [Tooltip("Set false to not use KSP suspension boost.")]
    public bool useAutoBoost;
    [KSPDefinition]
    [Tooltip("The transform name where the wheel coillider is.\nShould be a separate transform from the rest of the model and have a disabled Unity Wheel Collider component on it.")]
    public string suspensionColliderName;
    [Tooltip("Set to true and Gee for the wheel is > highGeeThreshold autoBoost will be turned off\nand highGeeSpringTweakable applied only if autoSpringDamper is true.")]
    [KSPDefinition]
    public bool adjustForHighGee;
    [Tooltip("The GeeASL where high gee spring will be applied.")]
    [KSPDefinition]
    public float highGeeThreshold;
    [Tooltip("The spring tweakable setting that will be applied if adjustForHighGee is true.")]
    [KSPDefinition]
    public float highGeeSpringTweakable;
    [Tooltip("The damper tweakable setting that will be applied if adjustForHighGee is true.")]
    [KSPDefinition]
    public float highGeeDamperTweakable;
    [KSPDefinition]
    [Tooltip("The Local Axis the Ssuspension transform travels in.")]
    public Data_WheelSuspension.TransformDir SuspensionDirection;
    [KSPState]
    [HideInInspector]
    public Vector3 suspensionPos;
    [KSPState]
    [HideInInspector]
    public Vector3 suspensionDefaultPos;
    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(SortIndex = 14)]
    [LocalizedField("PartModules/Wheels/AutomaticSpringDamper")]
    public ModuleProperty<bool> autoSpringDamper;
    [KSPState]
    [HideInInspector]
    public float autoBoost;
    [LocalizedField("PartModules/Wheels/SpringStrength")]
    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(SortIndex = 15)]
    [SteppedRange(0.05f, 3f, 0.05f)]
    public ModuleProperty<float> springTweakable;
    [LocalizedField("PartModules/Wheels/DamperStrength")]
    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(SortIndex = 16)]
    [SteppedRange(0.05f, 2f, 0.05f)]
    public ModuleProperty<float> damperTweakable;

    public override System.Type ModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetSpringString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetDamperString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetAutoSpringDamperString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Data_WheelSuspension() => throw null;

    public enum TransformDir
    {
      X,
      Y,
      Z,
    }
  }
}
