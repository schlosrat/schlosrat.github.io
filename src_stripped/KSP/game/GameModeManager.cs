// Decompiled with JetBrains decompiler
// Type: KSP.Game.GameModeManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game
{
  public class GameModeManager
  {
    public const string DEFAULT_GAME_MODE = "SandboxMode";
    public const string GAMEMODE_LOC_SLUG = "GameMode/";
    public const string GAMEMODE_DESCRIPTION_LOC_SLUG = "GameMode/Description/";
    private const string GAME_MODE_ASSET_LABEL = "game_mode";
    public Action OnGameModeChanged;
    private GameMode? _currentGameMode;
    private List<GameMode> _allGameModes;
    private List<string> _gameModeIdsCached;
    private string _localizedIdCached;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LoadAllGameModes(Action resolve) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGameModeAssetLoaded(TextAsset gameModeAsset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(GameInstance gameInstance, Action resolve) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TrySetGameMode(string gameModeId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetCurrentGameModeId() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IReadOnlyList<string> GetAllGameModeIds() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetCurrentModeNameLocalized() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetGameModeFeature(string featureId, out GameModeFeature? feature) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<DifficultyOption> GetDifficultyOptionDefinitions() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetOptionDefinition(string optionId, out DifficultyOption? difficultyOption) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<DifficultyLevelOptionStates> GetAllPresets() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetPreset(
      DifficultyLevel difficultyLevel,
      out DifficultyLevelOptionStates difficultyPreset)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameModeManager() => throw null;
  }
}
