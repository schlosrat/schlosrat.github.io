// Decompiled with JetBrains decompiler
// Type: KSP.Game.NewGameSetupInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Game
{
  public class NewGameSetupInfo
  {
    public const DifficultyLevel DEFAULT_DIFFICULTY_LEVEL = DifficultyLevel.Normal;
    private DifficultyOptionsData _defaultDifficultyOptionsData;
    private DifficultyOptionsData _initialDifficultyOptionsData;
    private DifficultyLevel _difficultyLevel;

    public DifficultyOptionsData DefaultDifficultyOptionsData
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDefaultDifficultyOptionsData(DifficultyOptionsData defaultDifficultyOptionsData) => throw null;

    public DifficultyOptionsData InitialDifficultyOptionsData
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetInitialDifficultyOptionsData(DifficultyOptionsData initialDifficultyOptionsData) => throw null;

    public DifficultyLevel DifficultyLevel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDifficultyLevel(DifficultyLevel difficultyLevel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NewGameSetupInfo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NewGameSetupInfo(
      DifficultyOptionsData defaultDifficultyOptionsData,
      DifficultyOptionsData initialDifficultyOptionsData,
      DifficultyLevel difficultyLevel)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NewGameSetupInfo(NewGameSetupInfo src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    ~NewGameSetupInfo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(
      DifficultyOptionsData defaultDifficultyOptionsData,
      DifficultyOptionsData initialDifficultyOptionsData,
      DifficultyLevel difficultyLevel)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(NewGameSetupInfo src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Uninit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetAllValues() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set(
      DifficultyOptionsData defaultDifficultyOptionsData,
      DifficultyOptionsData initialDifficultyOptionsData,
      DifficultyLevel difficultyLevel)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set(NewGameSetupInfo src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetDebugString(bool abbrev = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Matches(NewGameSetupInfo other) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SanityChecks() => throw null;
  }
}
