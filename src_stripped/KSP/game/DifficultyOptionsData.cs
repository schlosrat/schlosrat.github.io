// Decompiled with JetBrains decompiler
// Type: KSP.Game.DifficultyOptionsData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using Newtonsoft.Json;
using System.Runtime.CompilerServices;

namespace KSP.Game
{
  public class DifficultyOptionsData
  {
    [JsonIgnore]
    public const DifficultyLevel DEFAULT_DIFFICULTY = DifficultyLevel.Normal;
    [JsonIgnore]
    public const bool DEFAULT_ALLOW_REVERT = true;
    [JsonIgnore]
    public const bool DEFAULT_ALLOW_QUICK_LOAD = true;
    [JsonIgnore]
    public const bool DEFAULT_INCLUDE_STOCK_VESSELS = true;
    [JsonIgnore]
    public const float DEFAULT_DOCKING_TOLERANCE = 100f;
    [JsonIgnore]
    public const bool DEFAULT_COMM_NET_REQUIRED = false;
    [JsonIgnore]
    public const bool DEFAULT_UNBREAKABLE_JOINTS = false;
    [JsonIgnore]
    public const bool DEFAULT_NO_CRASH_DAMAGE = false;
    [JsonIgnore]
    public const bool DEFAULT_INFINITE_FUEL = false;
    [JsonIgnore]
    public const bool DEFAULT_INFINITE_POWER = false;
    [JsonProperty]
    public DifficultyLevel Difficulty;
    [JsonProperty]
    public bool AllowRevert;
    [JsonProperty]
    public bool AllowQuickLoad;
    [JsonProperty]
    public bool IncludeStockVessels;
    [JsonProperty]
    public float DockingTolerance;
    [JsonProperty]
    public bool CommNetRequired;
    [JsonProperty]
    public bool UnbreakableJoints;
    [JsonProperty]
    public bool NoCrashDamage;
    [JsonProperty]
    public bool InfiniteFuel;
    [JsonProperty]
    public bool InfinitePower;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DifficultyOptionsData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DifficultyOptionsData(DifficultyOptionsData src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DifficultyOptionsData(string uberString) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(DifficultyOptionsData src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(string uberString) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetAllValues() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set(DifficultyOptionsData src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetHeader(DifficultyLevel difficultyLevel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DifficultyOptionsData GetCopy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetDebugString(bool abbrev = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Matches(DifficultyOptionsData other) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string ExportUberString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ImportUberString(string uberString) => throw null;

    public static class ChunkName
    {
      public const string NAME = "Name";
      public const string DIFFICULTY = "Difficulty";
      public const string ALLOW_REVERT = "AllowRevert";
      public const string ALLOW_QUICK_LOAD = "AllowQuickLoad";
      public const string INCLUDE_STOCK_VESSELS = "IncludeStockVessels";
      public const string DOCKING_TOLERANCE = "DockingTolerance";
      public const string COMM_NET_REQUIRED = "CommNetRequired";
      public const string UNBREAKABLE_JOINTS = "UnbreakableJoints";
      public const string NO_CRASH_DAMAGE = "NoCrashDamage";
      public const string INFINITE_FUEL = "InfiniteFuel";
      public const string INFINITE_POWER = "InfinitePower";
    }
  }
}
