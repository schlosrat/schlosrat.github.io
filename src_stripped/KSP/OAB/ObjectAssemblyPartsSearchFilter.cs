// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ObjectAssemblyPartsSearchFilter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.UI.Binding;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  public class ObjectAssemblyPartsSearchFilter : MonoBehaviour
  {
    private OABSessionInformation stats;
    private ObjectAssemblyBuilderEvents eventsBuilder;
    private ObjectAssemblyUIEvents eventsUI;
    public ContextBindRoot bindRoot;
    public DataContext context;
    private bool isGridView;
    private PropertyExternal<bool> isGridViewProp;
    private Dictionary<AssemblyPartsFuelTypeFilter, ObjectAssemblyPartsSearchFilter.FilterToggle> fuelFilterToggles;
    private ContextListProperty<ObjectAssemblyPartsSearchFilter.FilterToggle> fuelFilterContext;
    private List<AssemblyPartsFuelTypeFilter> fuelTypeFilters;
    private Dictionary<AssemblyPartsCostFilter, ObjectAssemblyPartsSearchFilter.FilterToggle> costFilterToggles;
    private ContextListProperty<ObjectAssemblyPartsSearchFilter.FilterToggle> costFilterContext;
    private List<AssemblyPartsCostFilter> costFilters;
    private Dictionary<AssemblyPartsTechLevelFilter, ObjectAssemblyPartsSearchFilter.FilterToggle> techLevelFilterToggles;
    private ContextListProperty<ObjectAssemblyPartsSearchFilter.FilterToggle> techLevelFilterContext;
    private List<AssemblyPartsTechLevelFilter> techLevelFilters;
    private Dictionary<AssemblyPartTypeFilter, ObjectAssemblyPartsSearchFilter.FilterToggle> vesselTypeFilterToggles;
    private ContextListProperty<ObjectAssemblyPartsSearchFilter.FilterToggle> vesselTypeFilterContext;
    private List<AssemblyPartTypeFilter> vesselTypeFilters;
    private Dictionary<AssemblyPartsFuelTypeFilter, List<IObjectAssemblyAvailablePart>> partsByFuelFilter;
    private Dictionary<AssemblyPartsCostFilter, List<IObjectAssemblyAvailablePart>> partsByCostFilter;
    private Dictionary<AssemblyPartsTechLevelFilter, List<IObjectAssemblyAvailablePart>> partsByTechLevelFilter;
    private Dictionary<AssemblyPartTypeFilter, List<IObjectAssemblyAvailablePart>> partsByVesselTypeFilter;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(
      OABSessionInformation stats,
      ObjectAssemblyBuilderEvents eventsBuilder,
      ObjectAssemblyUIEvents eventsUI)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateFilterData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CreateFilterToggles() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HandleFuelFilterToggle(AssemblyPartsFuelTypeFilter filter, bool toggle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HandleCostFilterToggle(AssemblyPartsCostFilter filter, bool toggle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HandleTechLevelFilterToggle(AssemblyPartsTechLevelFilter filter, bool toggle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HandleVesselTypeFilterToggle(AssemblyPartTypeFilter filter, bool toggle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemoveCallbacks() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ToggleFuelTypeFilters(AssemblyPartsFuelTypeFilter type, bool toggle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ToggleCostFilters(AssemblyPartsCostFilter type, bool toggle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ToggleTechLevelFilters(AssemblyPartsTechLevelFilter type, bool toggle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ToggleVesselTypeFilters(AssemblyPartTypeFilter type, bool toggle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetLocalizedFilterText(string key, string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DataContext GetDataContext() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectAssemblyPartsSearchFilter() => throw null;

    public class FilterToggle : ApiDataContext
    {
      [DataProperty("toggle")]
      public Property<bool> toggle
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [DataProperty("name")]
      public Property<string> name
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public FilterToggle(string name, bool toggle = false) => throw null;
    }
  }
}
