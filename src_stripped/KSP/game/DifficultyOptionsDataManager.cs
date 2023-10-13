// Decompiled with JetBrains decompiler
// Type: KSP.Game.DifficultyOptionsDataManager
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
  public class DifficultyOptionsDataManager
  {
    public const string DIFFICULTY_OPTION_LOC_SLUG = "Menu/Settings/";
    private const string DIFFICULTY_PRESET_KEY = "difficulty";
    private const string DEFAULT_DIFFICULTY_SET_KEY = "DifficultyOptionDefinitions.json";
    private Dictionary<DifficultyLevel, DifficultyOptionsData> _lookupDict;
    private Dictionary<DifficultyLevel, DifficultyLevelOptionStates> _basePresetLookup;
    private Dictionary<DifficultyLevel, Dictionary<string, object>> _currentPresetLookup;
    private IReadOnlyList<DifficultyOption> _baseDifficultyOptionDefinitions;
    private Dictionary<string, DifficultyOption> _currentDifficultyOptionDefinitionSet;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DifficultyOptionsDataManager(GameInstance game = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    ~DifficultyOptionsDataManager() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(GameInstance game = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Uninit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Empty() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Load() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDifficultyPresetLoaded(TextAsset difficultyPresetTextAsset) => throw null;

    [Obsolete("This function is being used for legacy DifficultyOptionsData and will be refactored as part of KERBAL2-720")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDifficultyAssetLoaded(TextAsset difficultyTextAsset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDifficultyDefinitionSetLoaded(TextAsset difficultyTextAsset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DifficultyOptionsData GetDefaultOptionOriginalInstance(DifficultyLevel difficultyLevel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DifficultyOptionsData GetDefaultOptionCopy(DifficultyLevel difficultyLevel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RebuildDifficultyDataCache() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Dictionary<string, object> GetDifficultyPreset(DifficultyLevel difficultyLevel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Dictionary<string, DifficultyOption> GetAllDiffficultyOptionDefinitions() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetDifficultyOptionDefinition(
      string difficultyOptionID,
      out DifficultyOption difficultyOption)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<DifficultyOptionsData> GetAllDifficultyOptionsDataListOrNull() => throw null;
  }
}
