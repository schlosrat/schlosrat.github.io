// Decompiled with JetBrains decompiler
// Type: KSP.UI.SettingsConfigVariables
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  public class SettingsConfigVariables : MonoBehaviour
  {
    private Dictionary<string, CVar> configVariables;
    private Dictionary<string, Action<CVar>> onChangedDelegates;
    private Dictionary<string, CVar> unsavedUpdatedCVars;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BoolCVar RegisterCVar(string key, bool defaultValue, Action<CVar> onChanged) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BoolCVar RegisterCVar(
      string key,
      bool currentValue,
      bool defaultValue,
      Action<CVar> onChanged)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IntCVar RegisterCVar(string key, int defaultValue, Action<CVar> onChanged) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IntCVar RegisterCVar(
      string key,
      int currentValue,
      int defaultValue,
      Action<CVar> onChanged)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FloatCVar RegisterCVar(string key, float defaultValue, Action<CVar> onChanged) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FloatCVar RegisterCVar(
      string key,
      float currentValue,
      float defaultValue,
      Action<CVar> onChanged)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StringCVar RegisterCVar(string key, string defaultValue, Action<CVar> onChanged) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StringCVar RegisterCVar(
      string key,
      string currentValue,
      string defaultValue,
      Action<CVar> onChanged)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CVar GetCVar(string key) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnregisterCVars() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddUnsavedCVar(string key, bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddUnsavedCVar(string key, int value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddUnsavedCVar(string key, float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddUnsavedCVar(string key, string value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Apply() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Revert() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CheckUnsavedSettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CheckUnsavedSettings(string key) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SettingsConfigVariables() => throw null;
  }
}
