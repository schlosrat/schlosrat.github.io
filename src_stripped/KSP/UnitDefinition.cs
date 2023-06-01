// Decompiled with JetBrains decompiler
// Type: KSP.UnitDefinition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP
{
  public struct UnitDefinition
  {
    public string Key;
    public string Symbol;
    public string Text;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UnitDefinition(string key, string symbol, string text) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetTranslatedSymbol() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetTranslatedText() => throw null;
  }
}
