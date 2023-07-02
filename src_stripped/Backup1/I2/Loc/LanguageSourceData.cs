// Decompiled with JetBrains decompiler
// Type: I2.Loc.LanguageSourceData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

namespace I2.Loc
{
  [ExecuteInEditMode]
  [Serializable]
  public class LanguageSourceData
  {
    [NonSerialized]
    public ILanguageSource owner;
    public bool UserAgreesToHaveItOnTheScene;
    public bool UserAgreesToHaveItInsideThePluginsFolder;
    public bool GoogleLiveSyncIsUptoDate;
    [NonSerialized]
    public bool mIsGlobalSource;
    public List<TermData> mTerms;
    public bool CaseInsensitiveTerms;
    [NonSerialized]
    public Dictionary<string, TermData> mDictionary;
    public LanguageSourceData.MissingTranslationAction OnMissingTranslation;
    public string mTerm_AppName;
    public List<LanguageData> mLanguages;
    public bool IgnoreDeviceLanguage;
    public LanguageSourceData.eAllowUnloadLanguages _AllowUnloadingLanguages;
    public string Google_WebServiceURL;
    public string Google_SpreadsheetKey;
    public string Google_SpreadsheetName;
    public string Google_LastUpdatedVersion;
    public LanguageSourceData.eGoogleUpdateFrequency GoogleUpdateFrequency;
    public LanguageSourceData.eGoogleUpdateFrequency GoogleInEditorCheckFrequency;
    public LanguageSourceData.eGoogleUpdateSynchronization GoogleUpdateSynchronization;
    public float GoogleUpdateDelay;
    public List<UnityEngine.Object> Assets;
    [NonSerialized]
    public Dictionary<string, UnityEngine.Object> mAssetDictionary;
    private string mDelayedGoogleData;
    public static string EmptyCategory;
    public static char[] CategorySeparators;

    public UnityEngine.Object ownerObject
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public event LanguageSource.fnOnSourceUpdated Event_OnSourceUpdateFromGoogle
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsEqualTo(LanguageSourceData Source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal bool ManagerHasASimilarSource() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearAllData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsGlobalSource() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Editor_SetDirty() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateAssetDictionary() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UnityEngine.Object FindAsset(string Name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasAsset(UnityEngine.Object Obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddAsset(UnityEngine.Object Obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string Export_I2CSV(char Separator = ',', bool specializationsAsRows = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void AppendI2Term(
      StringBuilder Builder,
      int nLanguages,
      string Term,
      TermData termData,
      char Separator,
      string forceSpecialization)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void AppendI2Text(StringBuilder Builder, string text) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string Export_Language_to_Cache(int langIndex, bool fillTermWithFallback) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string Export_CSV(char Separator = ',', bool specializationsAsRows = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void AppendTerm(
      StringBuilder Builder,
      int nLanguages,
      string Term,
      TermData termData,
      string specialization,
      char Separator)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void AppendString(StringBuilder Builder, string Text, char Separator) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void AppendTranslation(
      StringBuilder Builder,
      string Text,
      char Separator,
      string tags)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UnityWebRequest Export_Google_CreateWWWcall(eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string Export_Google_CreateData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string Import_CSV(
      string Category,
      string CSVstring,
      eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace,
      char Separator = ',')
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string Import_I2CSV(
      string Category,
      string I2CSVstring,
      eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string Import_CSV(
      string Category,
      List<string[]> CSV,
      eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool ArrayContains(string MainText, params string[] texts) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static eTermType GetTermType(string type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Import_Language_from_Cache(
      int langIndex,
      string langData,
      bool useFallback,
      bool onlyCurrentSpecialization)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void FreeUnusedLanguages() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Import_Google_FromCache() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsNewerVersion(string currentVersion, string newVersion) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Import_Google(bool ForceUpdate, bool justCheck) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetSourcePlayerPrefName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator Import_Google_Coroutine(bool JustCheck) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyDownloadedDataOnSceneLoaded(Scene scene, LoadSceneMode mode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ApplyDownloadedDataFromGoogle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UnityWebRequest Import_Google_CreateWWWcall(bool ForceUpdate, bool justCheck) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasGoogleSpreadsheet() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string Import_Google_Result(
      string JsonString,
      eSpreadsheetUpdateMode UpdateMode,
      bool saveInPlayerPrefs = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetLanguageIndex(string language, bool AllowDiscartingRegion = true, bool SkipDisabled = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LanguageData GetLanguageData(string language, bool AllowDiscartingRegion = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsCurrentLanguage(int languageIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetLanguageIndexFromCode(string Code, bool exactMatch = true, bool ignoreDisabled = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int GetCommonWordInLanguageNames(string Language1, string Language2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool AreTheSameLanguage(string Language1, string Language2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetLanguageWithoutRegion(string Language) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddLanguage(string LanguageName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddLanguage(string LanguageName, string LanguageCode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveLanguage(string LanguageName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<string> GetLanguages(bool skipDisabled = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<string> GetLanguagesCode(bool allowRegions = true, bool skipDisabled = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsLanguageEnabled(string Language) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EnableLanguage(string Language, bool bEnabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool AllowUnloadingLanguages() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetSavedLanguageFileName(int languageIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LoadLanguage(
      int languageIndex,
      bool UnloadOtherLanguages,
      bool useFallback,
      bool onlyCurrentSpecialization,
      bool forceLoad)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LoadAllLanguages(bool forceLoad = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnloadLanguage(int languageIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SaveLanguages(bool unloadAll, PersistentStorage.eFileType fileLocation = PersistentStorage.eFileType.Temporal) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasUnloadedLanguages() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<string> GetCategories(bool OnlyMainCategory = false, List<string> Categories = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetKeyFromFullTerm(string FullTerm, bool OnlyMainCategory = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetCategoryFromFullTerm(string FullTerm, bool OnlyMainCategory = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void DeserializeFullTerm(
      string FullTerm,
      out string Key,
      out string Category,
      bool OnlyMainCategory = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateDictionary(bool force = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetTranslation(
      string term,
      string overrideLanguage = null,
      string overrideSpecialization = null,
      bool skipDisabled = false,
      bool allowCategoryMistmatch = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetTranslation(
      string term,
      out string Translation,
      string overrideLanguage = null,
      string overrideSpecialization = null,
      bool skipDisabled = false,
      bool allowCategoryMistmatch = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool TryGetFallbackTranslation(
      TermData termData,
      out string Translation,
      int langIndex,
      string overrideSpecialization = null,
      bool skipDisabled = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TermData AddTerm(string term) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TermData GetTermData(string term, bool allowCategoryMistmatch = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ContainsTerm(string term) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<string> GetTermsList(string Category = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TermData AddTerm(string NewTerm, eTermType termType, bool SaveSource = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveTerm(string term) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ValidateFullTerm(ref string Term) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LanguageSourceData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static LanguageSourceData() => throw null;

    public enum MissingTranslationAction
    {
      Empty,
      Fallback,
      ShowWarning,
      ShowTerm,
    }

    public enum eAllowUnloadLanguages
    {
      Never,
      OnlyInDevice,
      EditorAndDevice,
    }

    public enum eGoogleUpdateFrequency
    {
      Always,
      Never,
      Daily,
      Weekly,
      Monthly,
      OnlyOnce,
      EveryOtherDay,
    }

    public enum eGoogleUpdateSynchronization
    {
      Manual,
      OnSceneLoaded,
      AsSoonAsDownloaded,
    }
  }
}
