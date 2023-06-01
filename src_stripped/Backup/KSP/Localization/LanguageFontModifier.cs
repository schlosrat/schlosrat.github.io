// Decompiled with JetBrains decompiler
// Type: KSP.Localization.LanguageFontModifier
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace KSP.Localization
{
  public class LanguageFontModifier : KerbalMonoBehaviour
  {
    public TextMeshProUGUI TextField;
    [Header("Language Specific Modifications")]
    public List<LanguageFontModifier.LanguageModifications> LanguageSpecificModifications;
    private LanguageFontModifier.LanguageModifications _defaultMods;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnLocalizeEvent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetLanguageModifications(LanguageFontModifier.LanguageModifications mods) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private LanguageFontModifier.LanguageModifications GetLanguageModifications(string language) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LanguageFontModifier() => throw null;

    [Serializable]
    public class LanguageModifications
    {
      public string Language;
      public float FontSize;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public LanguageModifications() => throw null;
    }
  }
}
