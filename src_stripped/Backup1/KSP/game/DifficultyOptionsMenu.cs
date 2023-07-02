// Decompiled with JetBrains decompiler
// Type: KSP.Game.DifficultyOptionsMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.UI.Binding;
using KSP.Utilities;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.Game
{
  public class DifficultyOptionsMenu : KerbalMonoBehaviour
  {
    public static string DIFFICULTY_EASY;
    public static string DIFFICULTY_NORMAL;
    public static string DIFFICULTY_HARD;
    public static string DIFFICULTY_ROCKETSCIENTIST;
    public static string DIFFICULTY_CUSTOM;
    [SerializeField]
    private ContextBindRoot _bindRoot;
    [SerializeField]
    private CreateCampaignMenu _createCampaignMenuManager;
    [Space]
    [SerializeField]
    private GameObject _explorationModeMenu;
    [SerializeField]
    private GameObject _sandboxModeMenu;
    [SerializeField]
    private Transform _sectionsParent;
    [Header("Difficulty Toggles")]
    [SerializeField]
    private ToggleExtended _easyToggle;
    [SerializeField]
    private ToggleExtended _normalToggle;
    [SerializeField]
    private ToggleExtended _hardToggle;
    [SerializeField]
    private ToggleExtended _rocketScientistoggle;
    [SerializeField]
    private ToggleExtended _customToggle;
    [Header("Prefabs")]
    [SerializeField]
    private ContextBindRoot _sectionPrefab;
    [SerializeField]
    private ContextBindRoot _togglePrefab;
    [SerializeField]
    private ContextBindRoot _sliderPrefab;
    private List<ContextBindRoot> _modeSections;
    private GameObjectPool<ContextBindRoot> _modeTogglePool;
    private GameObjectPool<ContextBindRoot> _modeSliderPool;
    [Header("Keys")]
    [SerializeField]
    private string _sectionTitleKey;
    private DataContext _dataContext;
    private DifficultyLevel _currentSelectedDifficultyLevel;
    private ToggleExtended _currentSelectedToggle;
    private DifficultyOptionsData _difficultyOptionsData;
    private Property<bool> _allowRevert;
    private Property<bool> _allowQuickLoad;
    private Property<bool> _includeStockVessels;
    private Property<bool> _destructibleBuildings;
    private Property<bool> _partGForces;
    private Property<float> _partGForceTolerance;
    private Property<float> _dockingTolerance;
    private Property<bool> _commNetRequired;
    private Property<bool> _unbreakableJoints;
    private Property<bool> _noCrashDamage;
    private Property<bool> _allCBsDiscovered;
    private Property<bool> _allResourcesDiscovered;
    private Property<float> _startingScience;
    private Property<float> _scienceReward;
    private Property<bool> _partCost;
    private Property<float> _partCostScaling;
    private Property<bool> _infiniteFuel;
    private Property<bool> _infinitePower;

    public DifficultyOptionsData DifficultyOptionsData
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PopulateGameModeOptions() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TeardownGameModeOptions() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeContextBinding() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeCallbacks() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetDifficulty(DifficultyLevel difficultyLevel, bool resetDotween = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetEasyDifficulty() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetNormalDifficulty() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetHardDifficulty() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetRocketScientistDifficulty() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetCustomDifficulty() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetToDefault() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetOptionsToDifficultyPreset(DifficultyLevel difficultyLevel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ManuallyApplyOptions() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateOptionStateForDifficulty(DifficultyLevel difficultyLevel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetOptionValueFloat(string optionId, float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetOptionValueBool(string optionId, bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DifficultyOptionsMenu() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static DifficultyOptionsMenu() => throw null;
  }
}
