// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.ModuleData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api;
using KSP.Api.CoreTypes;
using KSP.Game;
using KSP.Sim.impl;
using KSP.Sim.ResourceSystem;
using KSP.UI.Binding;
using KSP.UI.Binding.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace KSP.Sim.Definitions
{
  [Serializable]
  public abstract class ModuleData
  {
    public static string PROPERTY_KEY_IN_SUBCONTEXT;
    public static string ACTION_KEY_IN_SUBCONTEXT;
    public static string STAGE_ACTIVATION_ACTION_KEY;
    public static string MODULE_ACTIVE_KEY;
    public static string PAM_ISVISIBLE_KEY;
    public static string PAM_ISINTERACTABLE_KEY;
    public static string PAM_DROPDOWNDATA_KEY;
    public static string PAM_FIELD_SORT_INDEX_KEY;
    [JsonIgnore]
    [NonSerialized]
    private Dictionary<string, DataContext> _propertyContextLookup;
    private bool _isDataContextPrepared;
    private bool _isCached;
    [JsonIgnore]
    [NonSerialized]
    protected DataContext _moduleDataContext;
    private ModuleProperty<bool> _isActiveInStagingProp;
    [JsonIgnore]
    public ResourceFlowRequestHandle RequestHandle;
    [JsonIgnore]
    private bool _isNotifyingSymmetryPartners;
    private Dictionary<string, IPropertyWritable> _symmetricalProperties;
    private Dictionary<string, FieldInfo> _symmetricalFields;

    public static GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public System.Type DataType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [JsonIgnore]
    public DataContext ModuleDataContext
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public abstract System.Type ModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Copy(ModuleData sourceModuleData) => throw null;

    public ModuleProperty<bool> IsActiveInStagingProp
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ModuleData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void SetupResourceRequest(
      ResourceFlowRequestBroker resourceFlowRequestBroker)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void UpdateGuids(IGGuid oldGuid, IGGuid newGuid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void InitProperties() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal virtual void OnPartBehaviourModuleInit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal virtual List<OABPartData.PartInfoModuleEntry> GetPartInfoEntries(
      System.Type partBehaviourModuleType,
      List<OABPartData.PartInfoModuleEntry> emptyPartInfoEntryList)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void RebuildDataContext() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PrepareDataContext() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddPAMDisplayDefaults(DataContext contextForProperty) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRange(IModuleProperty property, UIValueNumberRange range) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRange(IModuleProperty property, double min, double max, double step) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRange(IModuleProperty property, double min, double max) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLabel(IModuleProperty property, string label) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLabel(IModuleAction action, string label) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetVisible(string propertyContextKey, bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetVisible(IModuleDataContext property, bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetInteractable(IModuleDataContext property, bool isInteractable) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSortIndex(IModuleDataContext property, int sortIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetToStringDelegate(IModuleProperty property, ToStringDelegate newDelegate) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDropdownData(IModuleProperty property, DropdownItemList dropdownData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddProperty(string label, IModuleProperty property) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetProperty<T>(string propertyContextKey, out ModuleProperty<T> moduleProperty) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddAction(string label, IModuleAction action) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddAction(string label, IModuleAction action, int sortIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetStageActivationAction(
      IModuleAction defaultAction,
      PartBehaviourModule hostModule)
    {
      throw null;
    }

    internal event Action OnSymmetricalPropertyChanged
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ModulePropertyOnChangedForSymmetry() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal virtual void SyncAllSymmetricalData(ModuleData sourceModuleData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static ModuleData() => throw null;
  }
}
