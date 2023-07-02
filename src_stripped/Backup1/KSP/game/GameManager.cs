// Decompiled with JetBrains decompiler
// Type: KSP.Game.GameManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game.Flow;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;

namespace KSP.Game
{
  public class GameManager : MonoBehaviour
  {
    private static GameManager _instance;
    [SerializeField]
    [Tooltip("Provide a reference for the Splash Screens prefab of the game.")]
    private GameObject _splashScreensPrefab;
    [Tooltip("Provide a reference to a prefab to determine the type of Game Instance that will be created.")]
    [SerializeField]
    private GameInstance _gameInstancePrefab;
    [Tooltip("Configuration for the game instance metadata on major states.")]
    [SerializeField]
    private GameStatesConfiguration _gameStatesConfiguration;
    [Tooltip("The name of the initial scene to load")]
    [SerializeField]
    private string _kspFlowScene;
    [SerializeField]
    private string _missionControlSceneName;
    [SerializeField]
    private string _trainingCenterSceneName;
    private const string FIRST_TIME_SPLASH_SCREENS_DISPLAYED = "FirstTimeSplashScreensDisplayed";
    [ReadOnly]
    [SerializeField]
    private GameInstance _game;
    [ReadOnly]
    [SerializeField]
    private SplashScreensManager _splashScreens;
    private readonly DifficultyOptionsDataManager _difficultyOptionsDataManager;
    [ReadOnly]
    private PersistentProfileManager _profileManager;
    private GameModeManager _gameModeManager;
    public List<AsyncOperationHandle> AsyncHandlesStartedDuringBoot;
    public bool HasPhotosensitivityWarningBeenShown;

    public static GameManager Instance
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public RuntimeArguments RuntimeArguments
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public GameModeManager GameModeManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public DifficultyOptionsDataManager DifficultyOptionsDataManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public PersistentProfileManager ProfileManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public SequentialFlow LoadingFlow
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateSplashScreens(Action resolve, Action<string> reject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateGameInstance(Action resolve, Action<string> reject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeDifficultyOptionsManager(Action resolve, Action<string> reject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateGraphicsManager(Action resolve, Action<string> reject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializePersistentProfileManager(Action resolve, Action<string> reject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateGameModeManager(Action resolve, Action<string> reject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void StartBootstrap() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void StartGame() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnLoadingFinished(object sender, EventArgs args) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnLoadingProgress(object sender, float progress) => throw null;

    public bool IsShuttingDownGame
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ShutdownGame() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameManager() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static GameManager() => throw null;

    private class GameShutdownFlowAction : FlowAction
    {
      private readonly GameInstance _game;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public GameShutdownFlowAction(GameInstance game) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      protected override void DoAction(Action resolve, Action<string> reject) => throw null;
    }

    private class DestroyAllGameObjectsFlowAction : FlowAction
    {
      private readonly GameManager _gameManager;
      private Action _resolve;
      private string[] _dontDestroyTags;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public DestroyAllGameObjectsFlowAction(GameManager gameManager) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      protected override void DoAction(Action resolve, Action<string> reject) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private IEnumerator CoroutineDestroyAll(params string[] dontDestroyTags) => throw null;
    }

    private class LoadMainMenuSceneFlowAction : FlowAction
    {
      private readonly GameManager _gameManager;
      private Action _resolve;
      private string _sceneName;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public LoadMainMenuSceneFlowAction(GameManager gameManager, string sceneName) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      protected override void DoAction(Action resolve, Action<string> reject) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private IEnumerator CoroutineLinkDependencies() => throw null;
    }

    private class LoadUIBackgroundScenesFlowAction : FlowAction
    {
      private GameManager _gameManager;
      private Action _resolve;
      private string _trainingCenterSceneName;
      private string _missionControlSceneName;
      private AsyncOperationHandle<SceneInstance> _trainingSceneHandle;
      private AsyncOperationHandle<SceneInstance> _missionControlSceneHandle;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public LoadUIBackgroundScenesFlowAction(
        GameManager gameManager,
        string trainingCenterSceneName,
        string missionControlSceneName)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      protected override void DoAction(Action resolve, Action<string> reject) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void OnMissionControlSceneLoadComplete(AsyncOperationHandle<SceneInstance> handle) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void OnTrainingSceneLoadComplete(AsyncOperationHandle<SceneInstance> handle) => throw null;
    }

    private class InitializeAddressablesFlowAction : FlowAction
    {
      private GameManager _gameManager;
      private Action _resolve;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public InitializeAddressablesFlowAction(GameManager gameManager) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      protected override void DoAction(Action resolve, Action<string> reject) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private IEnumerator CoroutineFoo() => throw null;
    }
  }
}
