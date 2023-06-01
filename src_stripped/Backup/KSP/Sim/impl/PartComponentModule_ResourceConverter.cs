// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.PartComponentModule_ResourceConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.Modules;
using KSP.Sim.ResourceSystem;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class PartComponentModule_ResourceConverter : PartComponentModule
  {
    private FlowRequestResolutionState _returnedRequestResolution;
    private bool _hasPendingRequests;
    private string _inputsString;
    private string _outputsString;
    private string _cachedInput;
    private string _cachedOutput;
    private List<ResourceUnitsPair> _currentIngredientUnits;
    private List<ResourceUnitsPair> _currentProductUnits;
    private ResourceContainerGroup _containerGroup;
    private ResourceDefinitionDatabase _resourceDB;
    protected Data_ResourceConverter _dataResourceConverter;
    private const int UI_RESOURCE_DISPLAY_DIGITS = 6;
    private const int UI_RESOURCE_ELECTRICITY_DISPLAY_DIGITS = 1;

    public override Type PartBehaviourModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private GameInstance _game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnStart(double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnUpdate(double universalTime, double deltaUniversalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RefreshIngredientDataStructures() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetResourceRates(double timeStep) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnRecipeChanged(string activeRecipe) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnShutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartComponentModule_ResourceConverter() => throw null;
  }
}
