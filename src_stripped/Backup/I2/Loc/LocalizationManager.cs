// Decompiled with JetBrains decompiler
// Type: I2.Loc.LocalizationManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.OAB;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using UnityEngine;

namespace I2.Loc
{
  public static class LocalizationManager
  {
    private static string mCurrentLanguage;
    private static string mLanguageCode;
    private static CultureInfo mCurrentCulture;
    private static bool mChangeCultureInfo;
    public static bool IsRight2Left;
    public static bool HasJoinedWords;
    public static List<ILocalizationParamsManager> ParamManagers;
    public static LocalizationManager.FnCustomApplyLocalizationParams CustomApplyLocalizationParams;
    private static string[] LanguagesRTL;
    public static List<LanguageSourceData> Sources;
    public static string[] GlobalSources;
    public static Func<LanguageSourceData, bool> Callback_AllowSyncFromGoogle;
    private static string mCurrentDeviceLanguage;
    public static List<ILocalizeTargetDescriptor> mLocalizeTargets;
    private static bool mLocalizeIsScheduled;
    private static bool mLocalizeIsScheduledWithForcedValue;
    public static bool HighlightLocalizedTargets;
    public static bool DebugLocalizationIsOn;
    public static List<Localize> LocalizationList;
    public static string OverrideSpecialization;
    private static string _locKey;
    private static string _workspaceName;
    private static string _vehicleName;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void InitializeIfNeeded() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetVersion() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int GetRequiredWebServiceVersion() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetWebServiceURL(LanguageSourceData source = null) => throw null;

    public static string CurrentLanguage
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public static string CurrentLanguageCode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public static string CurrentRegion
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public static string CurrentRegionCode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public static CultureInfo CurrentCulture
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SetLanguage(string LanguageName, bool RememberLanguage = true, bool Force = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SetLanguageAndCode(
      string LanguageName,
      string LanguageCode,
      bool RememberLanguage = true,
      bool Force = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static CultureInfo CreateCultureForCode(string code) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void EnableChangingCultureInfo(bool bEnable) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void SetCurrentCultureInfo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void SelectStartupLanguage() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool HasLanguage(
      string Language,
      bool AllowDiscartingRegion = true,
      bool Initialize = true,
      bool SkipDisabled = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetSupportedLanguage(string Language, bool ignoreDisabled = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetLanguageCode(string Language) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetLanguageFromCode(string Code, bool exactMatch = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<string> GetAllLanguages(bool SkipDisabled = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<string> GetAllLanguagesCode(bool allowRegions = true, bool SkipDisabled = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsLanguageEnabled(string Language) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void LoadCurrentLanguage() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void PreviewLanguage(string NewLanguage) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void AutoLoadGlobalParamManagers() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ApplyLocalizationParams(
      ref string translation,
      bool allowLocalizedParameters = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ApplyLocalizationParams(
      ref string translation,
      GameObject root,
      bool allowLocalizedParameters = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ApplyLocalizationParams(
      ref string translation,
      Dictionary<string, object> parameters,
      bool allowLocalizedParameters = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ApplyLocalizationParams(
      ref string translation,
      LocalizationManager._GetParam getParam,
      bool allowLocalizedParameters = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static string GetLocalizationParam(string ParamName, GameObject root) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static string GetPluralType(
      MatchCollection matches,
      string langCode,
      LocalizationManager._GetParam getParam)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string ApplyRTLfix(string line) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string ApplyRTLfix(string line, int maxCharacters, bool ignoreNumbers) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string FixRTL_IfNeeded(string text, int maxCharacters = 0, bool ignoreNumber = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsRTL(string Code) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool UpdateSources() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void UnregisterDeletededSources() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void RegisterSceneSources() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void RegisterSourceInResources() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool AllowSyncFromGoogle(LanguageSourceData Source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void AddSource(LanguageSourceData Source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static IEnumerator Delayed_Import_Google(
      LanguageSourceData source,
      float delay,
      bool justCheck)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void RemoveSource(LanguageSourceData Source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsGlobalSource(string SourceName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static LanguageSourceData GetSourceContaining(string term, bool fallbackToFirst = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static UnityEngine.Object FindAsset(string value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ApplyDownloadedDataFromGoogle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetCurrentDeviceLanguage(bool force = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void DetectDeviceLanguage() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void RegisterTarget(ILocalizeTargetDescriptor desc) => throw null;

    public static event LocalizationManager.OnLocalizeCallback OnLocalizeEvent
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetTermTranslation(
      string Term,
      bool FixForRTL = true,
      int maxLineLengthForRTL = 0,
      bool ignoreRTLnumbers = true,
      bool applyParameters = false,
      GameObject localParametersRoot = null,
      string overrideLanguage = null,
      bool allowLocalizedParameters = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool TryGetTranslation(
      string Term,
      out string Translation,
      bool FixForRTL = true,
      int maxLineLengthForRTL = 0,
      bool ignoreRTLnumbers = true,
      bool applyParameters = false,
      GameObject localParametersRoot = null,
      string overrideLanguage = null,
      bool allowLocalizedParameters = true,
      string overrideSpecialization = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static T GetTranslatedObject<T>(string AssetName, Localize optionalLocComp = null) where T : UnityEngine.Object => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static T GetTranslatedObjectByTermName<T>(string Term, Localize optionalLocComp = null) where T : UnityEngine.Object => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetAppName(string languageCode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void LocalizeAll(bool Force = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static IEnumerator Coroutine_LocalizeAll() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void DoLocalizeAll(bool Force = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<string> GetCategories() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<string> GetTermsList(string Category = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TermData GetTermData(string term) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TermData GetTermData(string term, out LanguageSourceData source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ToggleLocalizationDebugMode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void UpdateLocalizationWithPlatform() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetTranslation(string Term, params object[] Params) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetTranslation(
      string Term,
      bool FixForRTL = true,
      int maxLineLengthForRTL = 0,
      bool ignoreRTLnumbers = true,
      bool applyParameters = false,
      GameObject localParametersRoot = null,
      string overrideLanguage = null,
      bool allowLocalizationParameters = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool TryGetWorkspaceEntryName(
      string workspaceName,
      string vehicleName,
      OABVariant oABVariant,
      out string Translation)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool TryGetWorkspaceDescription(
      string workspaceName,
      string availableDescription,
      OABVariant oABVariant,
      out string Translation)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static string GetLocKey(OABVariant OABVariant, string workspaceName, string suffix) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static LocalizationManager() => throw null;

    public delegate bool FnCustomApplyLocalizationParams(
      ref string translation,
      LocalizationManager._GetParam getParam,
      bool allowLocalizedParameters);

    public delegate object _GetParam(string param);

    public delegate void OnLocalizeCallback();
  }
}
