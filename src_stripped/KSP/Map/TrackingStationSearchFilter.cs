// Decompiled with JetBrains decompiler
// Type: KSP.Map.TrackingStationSearchFilter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Game;
using KSP.UI.Binding;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Map
{
  public class TrackingStationSearchFilter : KerbalMonoBehaviour
  {
    public ContextBindRoot BindRoot;
    public DataContext DataContext;
    private Property<bool> _isGridView;
    private Dictionary<TrackingStationObjectTypeFilter, TrackingStationSearchFilter.FilterToggle> filterToggles;
    private ContextListProperty<TrackingStationSearchFilter.FilterToggle> filterContext;
    private List<TrackingStationObjectTypeFilter> filters;
    private MapUI _mapUI;
    private bool _isInitialized;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeContextBinding() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateFilterData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CreateFilterToggles() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HandleFilterToggle(TrackingStationObjectTypeFilter filter, bool toggle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ToggleFuelTypeFilters(TrackingStationObjectTypeFilter type, bool toggle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearAllFilters() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DataContext GetDataContext() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TrackingStationSearchFilter() => throw null;

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
