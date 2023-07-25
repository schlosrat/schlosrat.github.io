// Decompiled with JetBrains decompiler
// Type: LanguageFontAsset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;

[Serializable]
public struct LanguageFontAsset
{
  public string LanguageName;
  public TMP_FontAsset FontAsset;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static bool TryGetFontByName(
    string languageName,
    List<LanguageFontAsset> languageFonts,
    out TMP_FontAsset fontAsset)
  {
    throw null;
  }
}
