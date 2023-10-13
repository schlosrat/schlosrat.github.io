// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_ResourceConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
  [DisableCustomEditorBase]
  [Serializable]
  public sealed class Data_ResourceConverter : ModuleData
  {
    [PAMDisplayControl(SortIndex = 1)]
    [HideInInspector]
    [KSPState]
    [LocalizedField("PartModules/Cooler/Enabled")]
    public ModuleProperty<bool> EnabledToggle;
    [LocalizedField("PartModules/ResourceConverter/ConversionRate")]
    [KSPState]
    [HideInInspector]
    [Range(0.0f, 1f)]
    [PAMDisplayControl(SortIndex = 2)]
    public ModuleProperty<float> conversionRate;
    [KSPState]
    [PAMDisplayControl(SortIndex = 3)]
    [HideInInspector]
    [LocalizedField("PartModules/ResourceConverter/Mode")]
    public ModuleProperty<string> Mode;
    [LocalizedField("PartModules/ResourceConverter/Status")]
    [KSPState]
    [PAMDisplayControl(SortIndex = 4)]
    [HideInInspector]
    public ModuleProperty<string> statusTxt;
    [HideInInspector]
    [PAMDisplayControl(SortIndex = 5)]
    [KSPState]
    [LocalizedField("PartModules/ResourceConverter/Input")]
    public ModuleProperty<string> InputTxt;
    [HideInInspector]
    [LocalizedField("PartModules/ResourceConverter/Output")]
    [KSPState]
    [PAMDisplayControl(SortIndex = 6)]
    public ModuleProperty<string> OutputTxt;
    [KSPState]
    [PAMDisplayControl(SortIndex = 7)]
    [LocalizedField("PartModules/Generator/GeneratorHeat")]
    public ModuleProperty<double> HeatGenerated;
    [KSPState]
    [HideInInspector]
    public ResourceConversionState conversionState;
    [KSPState]
    [HideInInspector]
    public bool HasEnoughResources;
    [KSPState]
    [HideInInspector]
    public bool ConverterIsActive;
    [HideInInspector]
    [KSPState]
    public int SelectedFormula;
    [KSPDefinition]
    public string ToggleName;
    [KSPDefinition]
    public string StartActionName;
    [KSPDefinition]
    public string StopActionName;
    [KSPDefinition]
    public string ToggleActionName;
    [KSPDefinition]
    public bool ConvertByMass;
    [KSPDefinition]
    public bool ResourceAutoShutdown;
    [KSPDefinition]
    public List<ResourceConverterFormulaDefinition> FormulaDefinitions;
    [HideInInspector]
    public double FluxGenerated;
    [KSPDefinition]
    public bool ThermalAutoShutdown;
    [KSPDefinition]
    public double AutoShutdownTemperature;
    [KSPDefinition]
    public double SafeOperationTemperature;
    [KSPDefinition]
    public bool UseEmissive;
    [KSPDefinition]
    public bool UseEmissiveTemperature;
    [KSPDefinition]
    public List<string> EmissiveMaterialNames;
    [KSPDefinition]
    public FloatCurve EmissiveTemperatureCurve;
    [KSPDefinition]
    public float EmissiveLerpRateUp;
    [KSPDefinition]
    public float EmissiveLerpRateDown;
    public ResourceDefinitionData ProblematicResource;
    private DictionaryValueList<string, ResourceConverterFormulaDefinition> _formulaeDict;
    private DropdownItemList _dropdownItems;
    public List<ResourceDefinitionID[]> FormulaDefs;
    public List<ResourceFlowRequestCommandConfig[]> RequestConfigs;
    private ResourceDefinitionDatabase _resourceDB;

    public override System.Type ModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [JsonIgnore]
    public DictionaryValueList<string, ResourceConverterFormulaDefinition> DisplayFormulae
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int FindFormulaWithKey(string key) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal override void OnPartBehaviourModuleInit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeFormulae() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static string GetConversionRateString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static string GetConversionStatusString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static string GetConversionInputString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static string GetConversionOutputString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static string GetHeatOutputString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal override List<OABPartData.PartInfoModuleEntry> GetPartInfoEntries(
      System.Type partBehaviourModuleType,
      List<OABPartData.PartInfoModuleEntry> delegateList)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<OABPartData.PartInfoModuleSubEntry> GetConverterFormulas(
      OABPartData.OABSituationStats oabSituationStats)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<OABPartData.PartInfoModuleSubEntry> GetConverterFormulaEntry(
      OABPartData.OABSituationStats oabSituationStats,
      ResourceConverterFormulaDefinition formula)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<OABPartData.PartInfoModuleSubEntry> GetInputStrings(
      OABPartData.OABSituationStats oabSituationStats,
      ResourceConverterFormulaDefinition formula)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<OABPartData.PartInfoModuleSubEntry> GetOutputStrings(
      OABPartData.OABSituationStats oabSituationStats,
      ResourceConverterFormulaDefinition formula)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetHeatString(
      OABPartData.OABSituationStats oabSituationStats,
      ResourceConverterFormulaDefinition formula)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SetupResourceRequest(
      ResourceFlowRequestBroker resourceFlowRequestBroker)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Data_ResourceConverter() => throw null;
  }
}
