// Decompiled with JetBrains decompiler
// Type: KSP.Units
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace KSP
{
  public class Units
  {
    private static Dictionary<string, UnitDefinition> _unitDefinitions;
    public static double TonnesToGrams;
    private static readonly string[] shortSIprefixes;
    private static readonly string[] longSIprefixes;
    private static readonly double[] prefixMults;
    private static readonly double[] digitsScale;
    private const int indexOfCommonUnit = 8;

    public static string SymbolUnits
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static string SymbolMeters
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static string SymbolGrams
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static string SymbolMetersSquared
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static string SymbolSeconds
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static string SymbolMinutes
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static string SymbolHours
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static string SymbolDays
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static string SymbolKiloNewtons
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static string SymbolKiloNewtonsSecond
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static string SymbolMetersPerSecond
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static string SymbolMetersPerSecondSquared
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static string SymbolElectricChargePerSecond
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static string SymbolPascal
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static string SymbolKilogramPerMeterCubed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static string SymbolKelvin
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static string SymbolDegree
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static string SymbolKiloWatt
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static string SymbolWatt
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static string SymbolTonne
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static string SymbolGramsPerSecond
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static string TextUnits
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static string TextMeters
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static string TextGrams
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static string TextMetersSquared
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static string TextSeconds
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static string TextMinutes
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static string TextHours
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static string TextDays
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static string TextKiloNewtons
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static string TextKiloNewtonsSecond
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static string TextMetersPerSecond
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static string TextMetersPerSecondSquared
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static string TextElectricChargePerSecond
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static string TextPascal
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static string TextKilogramPerMeterCubed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static string TextKelvin
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static string TextDegree
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static string TextKiloWatt
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static string TextWatt
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static string TextTonne
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static string TextGramsPerSecond
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static CultureInfo DefaultUnitCulture
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Units() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double ParseDouble(string toParse) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<Tuple<string, string>> EmitGlossary() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string PrintSI(
      double amount,
      string unitName,
      int significantFigures = 3,
      bool longPrefix = false,
      bool fullUnitName = false,
      bool showPrefix = true,
      bool useFixedExponent = false,
      int fixedExponent = 0)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int FindSIExponent(double amount) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string PrintFormattedRate(
      double rate,
      string units,
      double rateSecondsMin = 0.001,
      double rateMinutesMin = 0.001,
      double rateHoursMin = 0.001,
      int numDigits = 4)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    static Units() => throw null;
  }
}
