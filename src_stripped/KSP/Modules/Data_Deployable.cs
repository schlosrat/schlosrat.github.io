// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_Deployable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.Definitions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  [Serializable]
  public sealed class Data_Deployable : ModuleData
  {
    [LocalizedField("Extend Part")]
    [PAMDisplayControl(SortIndex = 1)]
    [KSPState(CopyToSymmetrySet = true)]
    [HideInInspector]
    public ModuleProperty<bool> toggleExtend;
    [KSPState]
    [PAMDisplayControl(SortIndex = 3)]
    [LocalizedField("PartModules/Deployable/Status")]
    [HideInInspector]
    public ModuleProperty<string> statusTxt;
    [SteppedRange(0.0f, 1f, 0.01f)]
    [PAMDisplayControl(SortIndex = 4)]
    [LocalizedField("PartModules/Deployable/DeployLimit")]
    [KSPState(CopyToSymmetrySet = true)]
    [HideInInspector]
    public ModuleProperty<float> DeployLimit;
    [HideInInspector]
    [KSPState]
    public ModuleProperty<float> AnimationNormalizedTime;
    [PAMDisplayControl(ExcludeFromContext = true)]
    [JsonProperty]
    [KSPState(CopyToSymmetrySet = true)]
    public ModuleProperty<Data_Deployable.DeployState> CurrentDeployState;
    [JsonIgnore]
    public Data_Deployable.DeployState DefaultDeployState;
    [KSPDefinition]
    public bool showStatus;
    [KSPDefinition]
    public bool isTracking;
    [KSPDefinition]
    public bool applyShielding;
    [KSPDefinition]
    public bool applyShieldingExtend;
    [KSPDefinition]
    public bool retractable;
    [KSPDefinition]
    public bool extendable;
    [KSPDefinition]
    public float TrackingAlignmentOffset;
    [KSPDefinition]
    public float trackingSpeed;
    [KSPDefinition]
    public float EditorAnimSpeedMul;
    [KSPDefinition]
    public string pivotName;
    [KSPDefinition]
    public string alignType;
    [KSPDefinition]
    public string secondaryTransform;
    [KSPDefinition]
    public string animationName;
    [KSPDefinition]
    public Data_Deployable.TrackingMode trackingMode;
    public Data_Deployable.RotationMode rotationMode;
    [KSPDefinition]
    public Quaternion originalRotation;
    [KSPDefinition]
    public Quaternion currentRotation;
    [KSPDefinition]
    public string targetGUID;
    [KSPDefinition]
    public bool LimitRotation;
    [KSPDefinition]
    public bool UseDeployLimit;
    [KSPDefinition]
    public Vector2 AxisMinMaxRotation;
    [KSPDefinition]
    public KSPActionGroup DefaultActionGroup;
    [KSPDefinition]
    public double deployCrashTolerance;
    [KSPDefinition]
    public double deployMaxTemp;
    [KSPDefinition]
    public float deployBreakingForce;
    [KSPDefinition]
    public float deployBreakingTorque;
    public string AnimDeployStateKey;
    public string AnimSpeedMultiplierKey;
    public string AnimReverseStateTransitionTriggerKey;
    public string AnimDeployLimitKey;
    public float DefaultRetractedAnimSpeedValue;
    public float DefaultExtendedAnimSpeedValue;
    [KSPDefinition]
    public string DeployPartTypeName;
    [KSPDefinition]
    public string OneTimeExtendActionName;
    [KSPDefinition]
    public string DeployToggleActionName;
    [KSPDefinition]
    public string ActionGroupToggleName;
    [KSPDefinition]
    public string ActionGroupExtendName;
    [KSPDefinition]
    public string ActionGroupRetractName;
    [KSPDefinition]
    public string DeployStateRetractedName;
    [KSPDefinition]
    public string DeployStateExtendedName;
    [KSPDefinition]
    public string DeployStateMovingName;
    [KSPDefinition]
    public string DeployStateBlockedName;
    [KSPDefinition]
    public string DeployStateExtendedCannotRetractName;
    [KSPDefinition]
    public string DeployRetractedCannotRetractName;

    public override System.Type ModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsExtended
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsRetracted
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsRetracting
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsExtending
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal override List<OABPartData.PartInfoModuleEntry> GetPartInfoEntries(
      System.Type partBehaviourModuleType,
      List<OABPartData.PartInfoModuleEntry> delegateList)
    {
      throw null;
    }

    public bool UseAnimation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal override void OnPartBehaviourModuleInit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetStatusString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetDeployLimitString(object value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Data_Deployable() => throw null;

    [Serializable]
    public enum DeployState : byte
    {
      [Description("PartModules/Deployable/Retracted")] Retracted,
      [Description("PartModules/Deployable/Extended")] Extended,
      [Description("PartModules/Deployable/Rectracting")] Retracting,
      [Description("PartModules/Deployable/Extending")] Extending,
      [Description("PartModules/Deployable/Broken")] Broken,
    }

    [Serializable]
    public enum TrackingMode
    {
      None,
      Sun,
      Home,
      Current,
      Vessel,
      Star,
      Guid,
    }

    [Serializable]
    public enum RotationMode
    {
      YAW,
      YAW_PITCH,
    }
  }
}
