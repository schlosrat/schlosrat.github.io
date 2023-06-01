// Decompiled with JetBrains decompiler
// Type: KSP.Modding.Variety.VarietyRangeRule
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Modding.Variety
{
  public struct VarietyRangeRule
  {
    public string name;
    public Type valueType;
    public VarietyRangeType varietyRangeType;
    public float probabilityOfEmpty;
    public object min;
    public object max;
    public object overrideValue;
    public List<object> specificOptions;
    public string subcategoryKey;
    public string attachToName;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static VarietyRangeRule Defaults() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static VarietyRangeRule CreateNewRange<T>(
      string name,
      T minValue,
      T maxValue,
      float emptyPercentageChance = 0.0f)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static VarietyRangeRule CreateNewRange<T>(
      string name,
      string varietyCategoryName,
      string attachToName = null,
      float emptyPercentageChance = 0.0f)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static VarietyRangeRule CreateNewRange<T>(
      string name,
      List<T> statOptions,
      float emptyPercentageChance = 0.0f)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static VarietyRangeRule CreateNewRange<T>(string name, T staticValue) => throw null;
  }
}
