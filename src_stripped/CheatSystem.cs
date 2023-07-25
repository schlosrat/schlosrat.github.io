// Decompiled with JetBrains decompiler
// Type: CheatSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.ScriptInterop;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CheatSystem : MonoBehaviour
{
  public static CheatSystem.ItemInfo[] gItemInfoArray;
  private CheatSystem.CheatSystemData _data;

  public static GameInstance Game
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public CheatSystem() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnClientSideCheatSystemValueChangedCallbackHandler(
    CheatSystemItemID cheatSystemItemID,
    bool oldValue,
    bool newValue)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void RegisterEnvironment(IScriptEnvironment scriptEnvironment) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public CheatSystem.CheatSystemData GetCheatSystemData() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool AreAllValuesSetToDefault() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void ResetAllValues() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool Get(CheatSystemItemID cheatSystemItemID) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool Set(CheatSystemItemID cheatSystemItemID, bool val) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public CheatSystemQuickDebugMode GetQuickDebugMode() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void QuickDebugEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void QuickDebugRestore() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool GetNoCrashDamage() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool SetNoCrashDamage(bool noCrashDamage) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool GetInfinitePropellant() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool SetInfinitePropellant(bool infinitePropellant) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool GetInfiniteElectricity() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool SetInfiniteElectricity(bool infiniteElectricity) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool GetUnbreakableJoints() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool SetUnbreakableJoints(bool unbreakableJoints) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool GetUnbreakableParts() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool SetUnbreakableParts(bool unbreakableParts) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool GetDisableGravity() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool SetDisableGravity(bool disableGravity) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool GetDisableAerodynamics() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool SetDisableAerodynamics(bool disableAerodynamics) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool GetDisableThermodynamics() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool SetDisableThermodynamics(bool disableThermodynamics) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool GetIgnoreMaxTemp() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool SetIgnoreMaxTemp(bool ignoreMaxTemp) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void ToTable(Dictionary<string, bool> properties) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void FromTable(Dictionary<string, bool> properties) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static CheatSystem() => throw null;

  public delegate void OnValueChangedCallback(
    CheatSystemItemID cheatSystemItemID,
    bool oldValue,
    bool newValue);

  public class ItemInfo
  {
    public const string DEFAULT_NAME = "";
    public const string DEFAULT_ABBREV = "";
    public const CheatSystemItemID DEFAULT_CHEAT_SYSTEM_ITEM_ID = CheatSystemItemID.None;
    public const bool DEFAULT_DEFAULT_VALUE = false;
    public const CheatSystemItemFlag DEFAULT_CHEAT_SYSTEM_ITEM_FLAGS = CheatSystemItemFlag.None;
    private string _name;
    private string _abbrev;
    private CheatSystemItemID _cheatSystemItemID;
    private bool _defaultValue;
    private CheatSystemItemFlag _cheatSystemItemFlags;

    public string Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string Abbrev
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public CheatSystemItemID CheatSystemItemID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool DefaultValue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public CheatSystemItemFlag CheatSystemItemFlags
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ItemInfo(
      string name,
      string abbrev,
      CheatSystemItemID cheatSystemItemID,
      bool defaultValue,
      CheatSystemItemFlag cheatSystemItemFlags)
    {
      throw null;
    }
  }

  public class CheatSystemData
  {
    private bool[] _array;
    private CheatSystem.OnValueChangedCallback _onValueChangedCallback;

    public CheatSystem.OnValueChangedCallback OnValueChangedCallback
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetOnValueChangedCallback(
      CheatSystem.OnValueChangedCallback onValueChangedCallback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CheatSystemData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Uninit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CheatSystemQuickDebugMode GetQuickDebugMode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void QuickDebugEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void QuickDebugRestore() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnValueChanged(CheatSystemItemID cheatSystemItemID, bool oldValue, bool newValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int ComputeIndex(CheatSystemItemID cheatSystemItemID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool AreAllValuesSetToDefault() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetAllValues() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Set(CheatSystemItemID cheatSystemItemID, bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Get(CheatSystemItemID cheatSystemItemID) => throw null;
  }
}
