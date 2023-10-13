// Decompiled with JetBrains decompiler
// Type: KSP.Game.KerbalVarietySystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Modding.Variety;
using KSP.Networking.MP.Utils;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace KSP.Game
{
  public class KerbalVarietySystem
  {
    public static MPRandom MPGlobalNameRandomizer;
    public const string MALE_TAG = "_M_";
    public const string FEMALE_TAG = "_F_";
    public const string NEUTRAL_TAG = "_N_";
    public const string DEFAULT_ATTRIBUTE_SET_NAME = "KERBALATTRIBUTES_EVA";
    public const string KERBAL_ORIGIN_TYPE_ATTRIBUTE_NAME = "ORIGINTYPE";
    public const string BUNDLELABEL_KERBAL_VARIETY = "kerbal_variety";
    private const string NAME_CATEGORY_KEY = "_names_";
    private const string COLOR_CATEGORY_KEY = "_color_";
    private const string BIO_CATEGORY_KEY = "_bio_";
    private const string WEIGHTEDLIST_CATEGORY_KEY = "_weighted_";
    private const string KERBAL_GAMEOBJECTCATEGORIES_FILE = "KerbalVarietyGameObjectCategories.json";
    private const string KERBAL_RANGERULES_FILE = "KerbalVarietyRangeRules.json";
    private const string KERBAL_ATTRIBUTERULES_NAMEPREFIX = "KerbalAttributes_";
    private const string CUSTOMKERBAL_NAMESUFFIX = "_Kerman.json";
    private const int UNIQUENESS_RANDOMIZE_LIMIT = 100;
    private EmptyOnPurpose _emptyOnPurpose;
    private Dictionary<string, List<string>> VarietyBiographySets;
    private Dictionary<string, List<string>> VarietyStringCategories;
    private Dictionary<string, List<string>> VarietyGameObjectCategories;
    private Dictionary<string, List<Color>> VarietyColorCategories;
    private Dictionary<string, WeightedOptionsArray> VarietyWeightedCategories;
    private Dictionary<string, VarietyRangeRule> VarietyRangeRules;
    private Dictionary<string, Dictionary<string, KerbalVarietyAttributeRule>> VarietyAttributeRules;
    private Dictionary<string, PredefinedKerbalData> _predefinedKerbals;
    private Dictionary<KerbalOriginType, List<string>> _predefinedKerbalsGroupedByOrigin;
    private Dictionary<System.Type, IDictionary> DictionariesByType;
    private KerbalRosterManager _manager;
    private int assetsLoading;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsKerbalPredefined(string nameKey) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool AllAssetsLoaded() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KerbalVarietySystem(KerbalRosterManager manager) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsResourceLocationAJsonFile(
      IResourceLocation curLocation,
      string askingFunctionsName)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LoadVarietyTextAssets() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsKerbalForQA(string kerbalNameToCheck) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsKerbalDevCaricature(string kerbalNameToCheck) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsKerbalFromOrigin(string kerbalNameToCheck, KerbalOriginType origin) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private KerbalOriginType GetKerbalOriginType(Dictionary<string, object> predefinedAttributes) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OrganizePredefinedKerbalsByOrigin(
      Dictionary<string, Dictionary<string, object>> rawCustomKerbals)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddPredefinedKerbalToDictionary(
      string kerbalKey,
      PredefinedKerbalData predefinedKerbalData)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<string> GetAllPredefinedKerbalKeysFromOrigin(KerbalOriginType originType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VarietyRangeRule? GetRangeRuleByName(string ruleName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Dictionary<string, KerbalVarietyAttributeRule> GetAttributeRuleSet(string attributeSet) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryCreateCustomKerbalByName(
      string customKerbalName,
      out KerbalAttributes kerbalAttributes,
      string attributeSetName = "KERBALATTRIBUTES_EVA")
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private KerbalAttributes CreateCustomKerbalByName(
      string customKerbalName,
      string attributeSetName = "KERBALATTRIBUTES_EVA")
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GenerateCustomKerbalAttributesFromRawData(
      Dictionary<string, object> rawCustomKerbalData,
      ref KerbalAttributes kerbalAttributes,
      string attributeSetName = "KERBALATTRIBUTES_EVA")
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetUnusedNameAttributes(out KerbalAttributes newAttributes) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KerbalAttributes GenerateNameAttributes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KerbalAttributes GenerateNameAttributes(string firstName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal List<string> GetAllCustomKerbalKeys() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<string> GetBiographySubgroup(string subsetName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int GenerateAttributeSeed(string fullName, string attributeName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static MPRandom GetSeededRandomizer(
      string firstName,
      string surname,
      string attributeName)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GenerateUnsafeAttributeSeed(string fullName, string attributeName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PreMakeAllAttributeChoices(ref KerbalAttributes kerbalAttributes) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PreMakeAllAttributeChoices(
      Dictionary<string, KerbalVarietyAttributeRule> attributeRules,
      ref KerbalAttributes kerbalAttributes)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RecursivelyPreGenerateAttribute(
      string attributeName,
      KerbalVarietyAttributeRule attributeRule,
      Dictionary<string, KerbalVarietyAttributeRule> attributeRuleDictionary,
      ref KerbalAttributes kerbalAttributes)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RunPreGenerationFunction(
      ref KerbalAttributes kerbalAttributes,
      KerbalVarietyAttributeRule curAttributeRule)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PreGenerateAttribute(
      KerbalVarietyAttributeRule attributeRule,
      VarietyRangeRule rangeRule,
      bool isTyped,
      ref KerbalAttributes kerbalAttributes)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private object PregenerateWeightedManifest(
      VarietyRangeRule rangeRule,
      bool isTyped,
      KerbalAttributes kerbalAttributes,
      MPRandom randomizer)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool TryGetColorFromString(string potentialColorAsString, out Color outputColor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetKerbalTypeTagFromPreloadInfo(VarietyPreloadInfo typePreloadInfo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IList GetVarietySubCategoryByRangeRule(VarietyRangeRule rangeRule) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static KerbalVarietySystem() => throw null;
  }
}
