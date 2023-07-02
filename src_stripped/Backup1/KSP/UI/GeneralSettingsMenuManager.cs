// Decompiled with JetBrains decompiler
// Type: KSP.UI.GeneralSettingsMenuManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Game;
using KSP.UI.Binding;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace KSP.UI
{
  public class GeneralSettingsMenuManager : SettingsSubMenu
  {
    private const string IS_MAIN_MENU = "IsMainMenu";
    private const string LANGUAGE_PROPERTY_KEY = "Language";
    private const string DIFFICULTY_LEVEL_PROPERTY_KEY = "DifficultyLevel";
    private const string ALLOW_REVERT_PROPERTY_KEY = "AllowRevert";
    private const string ALLOW_QUICKLOAD_PROPERTY_KEY = "AllowQuickload";
    private const string INCLUDE_STOCK_VESSELS_PROPERTY_KEY = "IncludeStockVessels";
    private const string INFINITE_PROPELLANT_PROPERTY_KEY = "InfinitePropellant";
    private const string INFINITE_ELECTRICITY_PROPERTY_KEY = "InfiniteElectricity";
    private const string UNBREAKABLE_JOINTS_PROPERTY_KEY = "UnbreakableJoints";
    private const string NO_CRASH_DAMAGE_PROPERTY_KEY = "NoCrashDamage";
    private const string DOCKING_TOLERANCE_DISTANCE_PROPERTY_KEY = "DockingToleranceDistance";
    private const string PROBES_SIGNAL_REQUIRE_PROPERTY_KEY = "ProbesSignalRequire";
    private const string SET_TO_CUSTOM_DIFFICULTY_ACTION_KEY = "SetToCustomDifficulty";
    public static string EASY_DIFFICULTY_LOC_KEY;
    private const string NORMAL_DIFFICULTY_LOC_KEY = "Menu/DifficultyLevels/Normal";
    public static string HARD_DIFFICULTY_LOC_KEY;
    public static string ROCKETSCIENTIST_DIFFICULTY_LOC_KEY;
    private const string CUSTOM_DIFFICULTY_LOC_KEY = "Menu/DifficultyLevels/Custom";
    public string LanguageLocalizationPrefix;
    private string _currentDifficultyLocKey;
    private List<string> _availableLanguages;
    [SerializeField]
    private TMP_Dropdown languageDropDown;
    [SerializeField]
    private ContextBindRoot _bindRoot;
    private DataContext _dataContext;
    private Property<string> _languageSetting;
    private Property<string> _difficultyLevel;
    private Property<bool> _allowRevertSetting;
    private Property<bool> _allowQuickLoadSetting;
    private Property<bool> _includeStockVesselsSetting;
    private Property<bool> _infinitePropellantSetting;
    private Property<bool> _infiniteElectricitySetting;
    private Property<bool> _unbreakableJointsSetting;
    private Property<bool> _noCrashDamageSetting;
    private Property<float> _dockingToleranceDistanceSetting;
    private Property<bool> _probesSignalRequireSetting;
    private DifficultyOptionsData _difficultyOptionsData;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Revert() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Apply() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnShow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateDifficultyData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Relocalize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeDifficultyOptions() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeContextBinding() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeCallbacks() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UninitializeCallbacks() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnAllowRevertChanged(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnAllowQuickLoadChanged(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnIncludeStockVesselsChanged(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnInfiniteFuelChanged(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnInifinitePowerChanged(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnUnbreakableJointsChanged(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnNoCrashChanged(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDockingToleranceChanged(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCommnetRequiredChanged(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetDifficultyLevelText() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnLanguageChanged(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyLanguageChange(string selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetDifficultyToCustom() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeLanguageDropdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GeneralSettingsMenuManager() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static GeneralSettingsMenuManager() => throw null;
  }
}
