// Decompiled with JetBrains decompiler
// Type: LanguageFontAsset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
