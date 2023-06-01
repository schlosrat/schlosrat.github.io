// Decompiled with JetBrains decompiler
// Type: KSP.Game.GameManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
    [Tooltip("Provide a reference for the Splash Screens prefab of the game.")]
    [SerializeField]
    private GameObject _splashScreensPrefab;
    [SerializeField]
    [Tooltip("Provide a reference to a prefab to determine the type of Game Instance that will be created.")]
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
    [ReadOnly]
    [SerializeField]
    private GameInstance _game;
    [ReadOnly]
    [SerializeField]
    private SplashScreensManager _splashScreens;
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

    public SequentialFlow LoadingFlow
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateSplashScreensPrefab(Action resolve, Action<string> reject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateGameInstance(Action resolve, Action<string> reject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateGraphicsManager(Action resolve, Action<string> reject) => throw null;

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

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ShutdownGame() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameManager() => throw null;

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
