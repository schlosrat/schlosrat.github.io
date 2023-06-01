// Decompiled with JetBrains decompiler
// Type: KSP.Game.DifficultyOptionsDataManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game
{
  public class DifficultyOptionsDataManager
  {
    public const GameInstance DEFAULT_GAME = null;
    private GameInstance _game;
    private Dictionary<DifficultyModeAndLevel, DifficultyOptionsData> _singleLookupDict;
    private Dictionary<CampaignMode, Dictionary<DifficultyLevel, DifficultyOptionsData>> _doubleLookupDict;

    public GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

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
    private void AddDifficultyOptionsData(DifficultyOptionsData difficultyOptionsData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemoveDifficultyOptionsData(DifficultyOptionsData difficultyOptionsData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDifficultyAssetLoaded(TextAsset difficultyTextAsset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Load() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DifficultyOptionsData FindDefaultOptionOriginalInstance(
      DifficultyModeAndLevel difficultyModeAndLevel)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DifficultyOptionsData FindDefaultOptionOriginalInstance(
      CampaignMode campaignMode,
      DifficultyLevel difficultyLevel)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DifficultyOptionsData FindDefaultOptionCopy(
      CampaignMode campaignMode,
      DifficultyLevel difficultyLevel)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DifficultyOptionsData FindDefaultOptionCopy(DifficultyModeAndLevel difficultyModeAndLevel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DifficultyOptionsData GetDefaultOptionOriginalInstance(
      DifficultyModeAndLevel difficultyModeAndLevel)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DifficultyOptionsData GetDefaultOptionOriginalInstance(
      CampaignMode campaignMode,
      DifficultyLevel difficultyLevel)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DifficultyOptionsData GetDefaultOptionCopy(
      CampaignMode campaignMode,
      DifficultyLevel difficultyLevel)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DifficultyOptionsData GetDefaultOptionCopy(DifficultyModeAndLevel difficultyModeAndLevel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<DifficultyOptionsData> GetAllDifficultyOptionsDataListOrNull() => throw null;
  }
}
