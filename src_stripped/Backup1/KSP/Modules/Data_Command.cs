// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_Command
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.Definitions;
using KSP.Sim.ResourceSystem;
using KSP.UI.Binding;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  [Serializable]
  public sealed class Data_Command : ModuleData
  {
    [HideInInspector]
    [LocalizedField("PartModules/Command/ControlStatus")]
    [KSPState]
    [PAMDisplayControl(SortIndex = 2)]
    public ModuleProperty<CommandControlState> controlStatus;
    [LocalizedField("PartModules/Command/CommandEnabled")]
    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(SortIndex = 3)]
    [HideInInspector]
    public ModuleProperty<bool> isCommandEnabled;
    [LocalizedField("PartModules/Command/ActiveControlName")]
    [KSPState]
    [PAMDisplayControl(SortIndex = 5)]
    [HideInInspector]
    public ModuleProperty<string> activeControlName;
    [LocalizedField("PartModules/Command/Hibernate")]
    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(SortIndex = 6)]
    public ModuleProperty<bool> hibernate;
    [KSPState(CopyToSymmetrySet = true)]
    [LocalizedField("PartModules/Command/HibernateInWarp")]
    [PAMDisplayControl(SortIndex = 7)]
    public ModuleProperty<bool> hibernateInWarp;
    [KSPDefinition]
    public int minimumCrew;
    [KSPDefinition]
    public List<PartModuleResourceSetting> requiredResources;
    [KSPDefinition]
    public bool hasHibernation;
    [KSPDefinition]
    public float hibernationMultiplier;
    [KSPDefinition]
    public bool requiresCommNet;
    [KSPDefinition]
    public Data_Command.ControlPoint[] alternateControlOrientations;
    private DictionaryValueList<string, Data_Command.ControlPoint> _controlPoints;
    public ResourceFlowRequestCommandConfig[] RequestConfigs;
    private DropdownItemList _dropdownItems;
    internal ResourceDefinitionID? MissingResource;
    internal int CurrentCrew;

    public override System.Type ModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsHibernating
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [JsonIgnore]
    public DictionaryValueList<string, Data_Command.ControlPoint> ControlPoints
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal override void OnPartBehaviourModuleInit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeControlPoints() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetActiveControlDisplayName(object name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetControlStatus(object state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Copy(ModuleData sourceModuleData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SetupResourceRequest(
      ResourceFlowRequestBroker resourceFlowRequestBroker)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal override List<OABPartData.PartInfoModuleEntry> GetPartInfoEntries(
      System.Type partBehaviourModuleType,
      List<OABPartData.PartInfoModuleEntry> delegateList)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetMinCrewString(OABPartData.OABSituationStats oabSituationStats) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<OABPartData.PartInfoModuleSubEntry> GetResourceStrings(
      OABPartData.OABSituationStats oabSituationStats)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Data_Command() => throw null;

    [Serializable]
    public class ControlPoint
    {
      public string Id;
      public Vector3 Orientation;
      public Vector3 Position;
      public static string DefaultID;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public ControlPoint(string id, Vector3 position, Vector3 orientation) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public string GetDisplayName() => throw null;

      public static Data_Command.ControlPoint Default
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      static ControlPoint() => throw null;
    }
  }
}
