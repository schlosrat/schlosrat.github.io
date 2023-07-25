// Decompiled with JetBrains decompiler
// Type: I2.Loc.SpecializationManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace I2.Loc
{
  public class SpecializationManager : BaseSpecializationManager
  {
    public static SpecializationManager Singleton;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private SpecializationManager() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetSpecializedText(string text, string specialization = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string SetSpecializedText(string text, string newText, string specialization) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string SetSpecializedText(Dictionary<string, string> specializations) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Dictionary<string, string> GetSpecializations(
      string text,
      Dictionary<string, string> buffer = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void AppendSpecializations(string text, List<string> list = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static SpecializationManager() => throw null;
  }
}
