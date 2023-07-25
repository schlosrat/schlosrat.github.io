// Decompiled with JetBrains decompiler
// Type: KSP.Localization.PartLocalization
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Localization
{
  public static class PartLocalization
  {
    public const string PartTitlePrefix = "Parts/Title/";
    public const string PartSubtitlePrefix = "Parts/Subtitle/";
    public const string PartManufacturerPrefix = "Parts/Manufacturer/";
    public const string PartDescriptionPrefix = "Parts/Description/";

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool TryGetPartString(
      string partName,
      PartLocalization.PartPrefixedStrings prefixType,
      out string localizedString)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetPartString(
      string partName,
      PartLocalization.PartPrefixedStrings prefixType)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool TryGetPartTitle(string partName, out string localizedTitle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool TryGetPartSubtitle(string partName, out string localizedSubtitle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool TryGetPartManufacturer(string partName, out string localizedManufacturer) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool TryGetPartDescription(string partName, out string localizedDescription) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetPartTitle(string partName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetPartSubtitle(string partName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetPartManufacturer(string partName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetPartDescription(string partName) => throw null;

    public enum PartPrefixedStrings
    {
      Title,
      Subtitle,
      Manufacturer,
      Description,
    }
  }
}
