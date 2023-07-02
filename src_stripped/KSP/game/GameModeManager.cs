// Decompiled with JetBrains decompiler
// Type: KSP.Game.GameModeManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
    private const string GAME_MODE_ASSET_LABEL = "game_mode";
    private GameInstance _game;
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
    public IReadOnlyList<string> GetAllGameModeIds() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetCurrentModeNameLocalized() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<GameModeFeature> GetAllGameModeFeatures() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetGameModeFeature(string featureId, out GameModeFeature? feature) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<DifficultyOption> GetAllOptions() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetOption(string optionId, out DifficultyOption difficultyOption) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<DifficultyPreset> GetAllPresets() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetPreset(
      DifficultyLevel difficultyLevel,
      out DifficultyPreset? difficultyPreset)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameModeManager() => throw null;
  }
}
