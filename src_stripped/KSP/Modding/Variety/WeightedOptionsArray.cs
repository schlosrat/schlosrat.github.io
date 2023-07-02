// Decompiled with JetBrains decompiler
// Type: KSP.Modding.Variety.WeightedOptionsArray
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Networking.MP.Utils;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Modding.Variety
{
  public class WeightedOptionsArray
  {
    private const string DEFAULT_UNASSIGNED_WEIGHTEDOPTIONS_NAME = "Un-Initialized Weighted Options Array";
    public string Name;
    private Type _type;
    private WeightedOptionsArray.WeightedOption[] _weightedOptionsArray;
    private uint _totalCumulativeWeighting;

    public Type OptionType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public WeightedOptionsArray.WeightedOption[] WeightedOptions
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public WeightedOptionsArray(JSONFriendlyWeightedOptionArray JSONMiddleData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void BuildWeightedOptionsArray(Dictionary<string, int> dictionaryFromJSON) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private object ConvertJSONStringToObjectOfType(string jsonInput) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsValidList() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public object GetRandomWeightedOption(ref MPRandom externalRandomizer) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public object GetRandomWeightedOption(
      ref MPRandom externalRandomizer,
      IList<WeightedOptionsArray.WeightedOption> weightedOptions,
      uint totalCumulativeWeight)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetFilteredWeightedOption(
      ref MPRandom externalRandomizer,
      string onlyIncludeIfContainsThisSubString,
      out object result)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private uint RebuildCumulativeWeightsForSubList(
      ref IList<WeightedOptionsArray.WeightedOption> targetList)
    {
      throw null;
    }

    public class WeightedOption
    {
      public uint CumulativeWeight;
      protected object _option;
      protected uint _weight;

      public object Option
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
      }

      public uint Weight
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public WeightedOption(object option, uint weight) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public bool IsOptionValid() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public bool IsWeightValid() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static int Sort(
        WeightedOptionsArray.WeightedOption a,
        WeightedOptionsArray.WeightedOption b)
      {
        throw null;
      }
    }
  }
}
