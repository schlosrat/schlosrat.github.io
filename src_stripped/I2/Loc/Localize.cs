// Decompiled with JetBrains decompiler
// Type: I2.Loc.Localize
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace I2.Loc
{
  [AddComponentMenu("I2/Localization/I2 Localize")]
  public class Localize : MonoBehaviour
  {
    public string mTerm;
    public string mTermSecondary;
    [NonSerialized]
    public string FinalTerm;
    [NonSerialized]
    public string FinalSecondaryTerm;
    public Localize.TermModification PrimaryTermModifier;
    public Localize.TermModification SecondaryTermModifier;
    public string TermPrefix;
    public string TermSuffix;
    public bool LocalizeOnAwake;
    private string LastLocalizedLanguage;
    private string LastLocalizedSpecialization;
    public bool IgnoreRTL;
    public int MaxCharactersInRTL;
    public bool IgnoreNumbersInRTL;
    public bool CorrectAlignmentForRTL;
    public bool AddSpacesToJoinedLanguages;
    public bool AllowLocalizedParameters;
    public bool AllowParameters;
    public List<UnityEngine.Object> TranslatedObjects;
    [NonSerialized]
    public Dictionary<string, UnityEngine.Object> mAssetDictionary;
    public UnityEvent LocalizeEvent;
    public static string MainTranslation;
    public static string SecondaryTranslation;
    public static string CallBackTerm;
    public static string CallBackSecondaryTerm;
    public static Localize CurrentLocalizeComponent;
    public bool AlwaysForceLocalize;
    [SerializeField]
    public EventCallback LocalizeCallBack;
    public bool mGUI_ShowReferences;
    public bool mGUI_ShowTems;
    public bool mGUI_ShowCallback;
    public ILocalizeTarget mLocalizeTarget;
    public string mLocalizeTargetName;

    public string Term
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public string SecondaryTerm
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasCallback() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnLocalize(bool Force = false, string overrideSpecialization = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool FindTarget() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetFinalTerms(out string primaryTerm, out string secondaryTerm) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetMainTargetsText() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetFinalTerms(
      string Main,
      string Secondary,
      out string primaryTerm,
      out string secondaryTerm,
      bool RemoveNonASCII)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetTerm(string primary) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetTerm(string primary, string secondary) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal T GetSecondaryTranslatedObj<T>(
      ref string mainTranslation,
      ref string secondaryTranslation)
      where T : UnityEngine.Object
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateAssetDictionary() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal T GetObject<T>(string Translation) where T : UnityEngine.Object => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private T GetTranslatedObject<T>(string Translation) where T : UnityEngine.Object => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DeserializeTranslation(string translation, out string value, out string secondary) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T FindTranslatedObject<T>(string value) where T : UnityEngine.Object => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasTranslatedObject(UnityEngine.Object Obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddTranslatedObject(UnityEngine.Object Obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetGlobalLanguage(string Language) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Localize() => throw null;

    public enum TermModification
    {
      DontModify,
      ToUpper,
      ToLower,
      ToUpperFirst,
      ToTitle,
    }
  }
}
