// Decompiled with JetBrains decompiler
// Type: KSP.Game.DifficultyOptionsDataManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game
{
  public class DifficultyOptionsDataManager
  {
    public const string DIFFICULTY_OPTION_LOC_SLUG = "Menu/Settings/";
    private Dictionary<DifficultyLevel, DifficultyOptionsData> _lookupDict;

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
    private void OnDifficultyAssetLoaded(TextAsset difficultyTextAsset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Load() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DifficultyOptionsData GetDefaultOptionOriginalInstance(DifficultyLevel difficultyLevel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DifficultyOptionsData GetDefaultOptionCopy(DifficultyLevel difficultyLevel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DifficultyPreset GetDifficultyPreset(DifficultyLevel difficultyLevel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<DifficultyOption> GetModeDifficultyOptions() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<DifficultyOptionsData> GetAllDifficultyOptionsDataListOrNull() => throw null;
  }
}
