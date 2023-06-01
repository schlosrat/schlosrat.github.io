// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ResourceSystem.ResourceDefinitionDatabase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Logging;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim.ResourceSystem
{
  public class ResourceDefinitionDatabase
  {
    private const LogFilter LOG_FILTER = LogFilter.Simulation;
    public const string AIR_RESOURCE_NAME = "IntakeAir";
    public const string ELECTRICITY_RESOURCE_NAME = "ElectricCharge";
    private bool _isDefinitionDataFrozen;
    private ResourceSystemUtilities.ErrorReportMode _recipeOverrideReportMode;
    private ResourceSystemUtilities.ErrorReportMode _writeWhenFrozenReportMode;
    private ResourceSystemUtilities.ErrorReportMode _undefinedResourceOnFreezeReportMode;
    private readonly List<ResourceDefinitionDatabase.ResourceDefinitionWrapper> _resourceDefinitionWrappers;
    private readonly Dictionary<string, ResourceDefinitionID> _resourceNameIDMap;
    private readonly List<bool> _resourceIsRecipeLookup;
    private readonly List<string> _resourceNameLookup;
    private bool _dataCacheIsDirty;
    private readonly List<double> _resourceMassCache;
    private readonly List<ResourceUnitsPair[]> _resourceIngredientCache;
    private readonly List<double> _resourceHeatCapacityCache;
    private readonly List<ResourceDefinitionData> _resourceDefinitionDataCache;
    private readonly List<ResourceFlowMode> _resourceFlowModeCache;
    public Dictionary<ResourceDefinitionID, List<ResourceDefinitionID>> ResourceToRecipeMap;
    public Dictionary<ResourceDefinitionID, List<ResourceDefinitionID>> RecipeToResourceMap;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string LOG_PREFIX([CallerMemberName] string memberName = "") => throw null;

    public ResourceSystemUtilities.ErrorReportMode RecipeOverrideReportMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public ResourceSystemUtilities.ErrorReportMode WriteWhenFrozenReportMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public ResourceSystemUtilities.ErrorReportMode UndefinedResourceOnFreezeReportMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool IsDefinitionDataFrozen
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int DataCount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerable<ResourceDefinitionID> GetAllResourceIDs() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void FreezeAndCacheDefinitionValues() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetRecipesForIngredient(
      ResourceDefinitionID ingredient,
      out List<ResourceDefinitionID> recipes)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetIngredientsForRecipe(
      ResourceDefinitionID recipe,
      out List<ResourceDefinitionID> ingredients)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResourceDefinitionID GetResourceIDFromName(string resourceName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetResourceNameFromID(ResourceDefinitionID resourceID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsValidResourceID(ResourceDefinitionID definitionID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResourceDefinitionData GetDefinitionData(ResourceDefinitionID resourceID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResourceFlowMode GetResourceFlowMode(ResourceDefinitionID resourceID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsResourceRecipe(ResourceDefinitionID resourceID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetResourceUnitMass(ResourceDefinitionID resourceID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetResourceMass(ResourceDefinitionID resourceID, double unitsOfResource) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetResourceThermalMass(ResourceDefinitionID resourceID, double unitsOfResource) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double ComputeTotalMassOfResourceUnits(IEnumerable<ResourceUnitsPair> unitsOfResources) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ComputeEachMassOfResourceUnits(
      IEnumerable<ResourceUnitsPair> unitsOfResources,
      ref List<ResourceMassPair> massesOfResources)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetRecipeIngredientUnits(
      ResourceDefinitionID resourceID,
      ref List<ResourceUnitsPair> unitsOfIngredients,
      bool clearList = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetRecipeIngredientUnits(
      ResourceDefinitionID resourceID,
      double unitsOfResource,
      ref List<ResourceUnitsPair> unitsOfIngredients,
      bool clearList = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResourceDefinitionID AddOrUpdateDefinition(ResourceDefinition resourceDefinition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResourceDefinitionID AddOrUpdateDefinition(ResourceRecipeDefinition recipeDefinition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private ResourceUnitsPair[] GetOrAddMixtureIngredients(
      in ResourceRecipeIngredientDefinition[] ingredientDefinitions)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EnsureDataIndexAllocations(int resourceDataIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void StoreResourceDataAtIndex(
      ResourceDefinitionDatabase.ResourceDefinitionWrapper resourceWrapper,
      int resourceDataIndex)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static ResourceDefinitionDatabase.ResourceDefinitionWrapper CreateDataFromResourceDefinition(
      ResourceDefinition definition,
      ResourceDefinitionID resourceID)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static ResourceDefinitionDatabase.ResourceDefinitionWrapper CreateDataFromRecipeDefinition(
      ResourceRecipeDefinition definition,
      ResourceDefinitionID resourceID,
      ResourceUnitsPair[] ingredients)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static ResourceDefinitionDatabase.ResourceDefinitionWrapper CreateDataFromRecipeIngredientDefinition(
      ResourceRecipeIngredientDefinition definition,
      ResourceDefinitionID resourceID)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MarkCacheAsDirty() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateCacheIfDirty(bool force = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private ResourceUnitsPair[] ComputeRecipeIngredientsRecursive(
      ResourceDefinitionID resourceID,
      Dictionary<ResourceDefinitionID, ResourceUnitsPair[]> knownRecipes,
      List<ResourceDefinitionID> recipeStack)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double ComputeMassPerUnitRecursive(
      ResourceDefinitionID resourceID,
      Dictionary<ResourceDefinitionID, double> knownMasses,
      List<ResourceDefinitionID> recipeStack)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandlePotentialRecipeOverrideBehavior(
      ResourceDefinitionDatabase.ResourceDefinitionWrapper recipeWrapper)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ThrowIfCircularRecipe(
      ResourceDefinitionID resource,
      List<ResourceDefinitionID> recipeStack)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool TryGetFirstUndefinedResource(
      out ResourceDefinitionID resourceID,
      out string resourceDefinitionName)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    private bool IsValidDataIndex(int dataIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    private static int GetDataIndexFromID(ResourceDefinitionID resourceID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    private static ResourceDefinitionID GetIDFromDataIndex(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResourceDefinitionDatabase() => throw null;

    public class CircularRecipeException : ResourceSystemUtilities.ResourceSystemException
    {
      [MethodImpl(MethodImplOptions.NoInlining)]
      public CircularRecipeException(string msg) => throw null;
    }

    private enum ResourceDataType
    {
      Resource,
      Recipe,
      Undefined,
    }

    private class ResourceDefinitionWrapper
    {
      public ResourceDefinitionID resourceID;
      public ResourceDefinitionDatabase.ResourceDataType dataType;
      public ResourceDefinition? originalResourceDefinition;
      public ResourceRecipeDefinition? originalRecipeDefinition;
      public ResourceRecipeIngredientDefinition? originalIngredientDefinition;
      public string definitionName;
      public string displayNameKey;
      public string abbreviationNameKey;
      public double definitionMassPerUnit;
      public double specificHeatCapacityPerUnit;
      public ResourceUnitsPair[] definitionIngredients;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public ResourceDefinitionWrapper() => throw null;
    }
  }
}
