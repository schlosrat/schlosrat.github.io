// Decompiled with JetBrains decompiler
// Type: RuntimePrefs
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

public static class RuntimePrefs
{
  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void DeleteAll() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void DeleteKey(string key) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static bool HasKey(string key) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void Save() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void SetInt(string key, int value) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static int GetInt(string key, int defaultValue = 0) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static bool GetIntIfSet(string key, ref int val) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static bool GetIntIfSet(string key, Action<int> callback) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void SetFloat(string key, float value) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static float GetFloat(string key, float defaultValue = 0.0f) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static bool GetFloatIfSet(string key, ref float val) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static bool GetFloatIfSet(string key, Action<float> callback) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void SetString(string key, string value) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static string GetString(string key, string defaultValue = "") => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static bool GetStringIfSet(string key, ref string val) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static bool GetStringIfSet(string key, Action<string> callback) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void SetBool(string key, bool value) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static bool GetBool(string key, bool defaultValue = false) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static bool GetBoolIfSet(string key, ref bool val) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static bool GetBoolIfSet(string key, Action<bool> callback) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void SetDouble(string key, double value) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static double GetDouble(string key, double defaultValue = 0.0) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static bool GetDoubleIfSet(string key, ref double val) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static bool GetDoubleIfSet(string key, Action<double> callback) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void SetEnum<TEnum>(string key, TEnum value) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static TEnum GetEnum<TEnum>(string key, TEnum defaultValue = null) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static bool GetEnumIfSet<TEnum>(string key, ref TEnum val) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static bool GetEnumIfSet<TEnum>(string key, Action<TEnum> callback) => throw null;
}
