// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ResourceSystem.ResourceDefinitionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim.ResourceSystem
{
  public class ResourceDefinitionData
  {
    public readonly ResourceDefinitionID resourceDatabaseID;
    private string _name;
    private string _displayNameKey;
    private string _displayName;
    private string _abbreviationKey;
    private string _displayAbbreviation;
    public readonly bool isRecipeInDatabase;
    public readonly ResourceDefinitionData.ResourceProperties resourceProperties;
    public readonly ResourceDefinitionData.RecipeProperties recipeProperties;
    public readonly string vfxFuelType;
    public readonly bool IsRecipe;
    public readonly string resourceIconAssetAddress;

    public string name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public string displayNameKey
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateDisplayName() => throw null;

    public string DisplayName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string abbreviationKey
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateDisplayAbbreviation() => throw null;

    public string DisplayAbbreviation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool UsesAir
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResourceDefinitionData(
      ResourceDefinitionID resourceDatabaseID,
      ResourceDefinition resourceDefinition)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResourceDefinitionData(
      ResourceDefinitionID resourceDatabaseID,
      ResourceRecipeDefinition recipeDefinition,
      double computedTotalMass,
      IEnumerable<ResourceUnitsPair> ingredients)
    {
      throw null;
    }

    public class ResourceProperties
    {
      public readonly bool isTweakable;
      public readonly bool isVisible;
      public readonly double massPerUnit;
      public readonly double volumePerUnit;
      public readonly double specificHeatCapacityPerUnit;
      public readonly double massPerVolume;
      public readonly ResourceFlowMode flowMode;
      public readonly ResourceTransferMode transferMode;
      public readonly double costPerUnit;
      public readonly bool ignoreForIsp;
      public bool NonStageable;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public ResourceProperties(ResourceDefinition resourceDefinition) => throw null;
    }

    public class RecipeProperties
    {
      public readonly double totalMasPerUnit;
      public readonly IReadOnlyList<ResourceUnitsPair> ingredients;
      public readonly IReadOnlyList<ResourceDefinitionID> IngredientsResourceIDs;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public RecipeProperties(double totalMassPerUnit, IEnumerable<ResourceUnitsPair> ingredients) => throw null;
    }
  }
}
