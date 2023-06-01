// Decompiled with JetBrains decompiler
// Type: KSP.Game.DifficultyOptionsMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.UI.Binding;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.Game
{
  public class DifficultyOptionsMenu : KerbalMonoBehaviour
  {
    public static string DEFAULT_WINDOW_INFORMATION;
    public static string DIFFICULTY_EASY;
    public static string DIFFICULTY_NORMAL;
    public static string DIFFICULTY_HARD;
    public static string DIFFICULTY_ROCKETSCIENTIST;
    public static string DIFFICULTY_CUSTOM;
    [SerializeField]
    private ContextBindRoot _bindRoot;
    [SerializeField]
    private CreateCampaignMenu _createCampaignMenuManager;
    [SerializeField]
    [Space]
    private GameObject _explorationModeMenu;
    [SerializeField]
    private GameObject _sandboxModeMenu;
    [SerializeField]
    private bool _showGameModeSpecificOptions;
    [SerializeField]
    [Header("Difficulty Toggles")]
    private ToggleExtended _easyToggle;
    [SerializeField]
    private ToggleExtended _normalToggle;
    [SerializeField]
    private ToggleExtended _hardToggle;
    [SerializeField]
    private ToggleExtended _rocketScientistoggle;
    [SerializeField]
    private ToggleExtended _customToggle;
    private DataContext _dataContext;
    private DifficultyModeAndLevel _currentSelectedDifficultyModeAndLevel;
    private ToggleExtended _currentSelectedToggle;
    private CampaignMode _currentSelectedCampaignMode;
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
    private static Property<string> _windowInformation;

    public CampaignMode SelectedCampaignMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public DifficultyOptionsData DifficultyOptionsData
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateGameModeSpecificOptionsVisibility() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeContextBinding() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeCallbacks() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void setWindowInformation(string information) => throw null;

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
    private void SetToDefault() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateDifficultyOptionProperties(DifficultyOptionsData data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ManuallyApplyOptions() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateOptionStateForDifficulty(DifficultyLevel difficultyLevel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DifficultyOptionsMenu() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static DifficultyOptionsMenu() => throw null;
  }
}
