// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_DockingNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.Definitions;
using KSP.Sim.impl;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Modules
{
  [Serializable]
  public sealed class Data_DockingNode : ModuleData
  {
    [KSPDefinition]
    public string DockingTransformName;
    [KSPDefinition]
    public string ControlTransformName;
    [KSPDefinition]
    public string AttachmentNodeId;
    [KSPDefinition]
    public string[] NodeTypes;
    [KSPDefinition]
    public float UndockEjectionForce;
    [KSPDefinition]
    public float MinDistanceToReengage;
    [KSPDefinition]
    public float AcquireRange;
    [KSPDefinition]
    public float AcquireMinFwdDot;
    [KSPDefinition]
    public float MinRollDot;
    [KSPDefinition]
    public float AcquireForce;
    [KSPDefinition]
    public float AcquireTorque;
    [KSPDefinition]
    public float AcquireTorqueRoll;
    [KSPDefinition]
    public float CaptureRange;
    [KSPDefinition]
    public float CaptureMinFwdDot;
    [KSPDefinition]
    public float CaptureMinRollDot;
    [KSPDefinition]
    public float CaptureMaxRvel;
    [KSPDefinition]
    public string fxDockPrefabName;
    [KSPDefinition]
    public string fxUndockPrefabName;
    [KSPDefinition]
    public bool IsGendered;
    [KSPDefinition]
    public bool IsGenderFemale;
    [KSPDefinition]
    public bool SnapRotation;
    [KSPDefinition]
    public float SnapOffset;
    [KSPState]
    public IGGuid DockedPartId;
    [KSPState]
    public IGGuid PreviousDockedPartId;
    [KSPState]
    public Data_DockingNode.DockingState CurrentState;
    [SteppedRange(0.0f, 1f, 0.1f)]
    [LocalizedField("PartModules/Docking/AcquireForce")]
    [KSPState(CopyToSymmetrySet = true)]
    public ModuleProperty<float> AcquireForcePercent;
    [KSPDefinition]
    public bool IsDeployableDockingPort;

    public override System.Type ModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetAcquireForcePercentString(object value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal override List<OABPartData.PartInfoModuleEntry> GetPartInfoEntries(
      System.Type partBehaviourModuleType,
      List<OABPartData.PartInfoModuleEntry> delegateList)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<OABPartData.PartInfoModuleSubEntry> GetDockingTypesStrings(
      OABPartData.OABSituationStats oabSituationStats)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetCaptureRangeString(OABPartData.OABSituationStats oabSituationStats) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetEjectionForceString(OABPartData.OABSituationStats oabSituationStats) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Data_DockingNode() => throw null;

    [Serializable]
    public enum DockingState : byte
    {
      None,
      Ready,
      Acquire_Dockee,
      Acquire_Docker,
      Docked,
      Disengaged,
    }
  }
}
