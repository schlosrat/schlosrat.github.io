// Decompiled with JetBrains decompiler
// Type: I2.Loc.LocalizeTarget_TextMeshPro_Label
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace I2.Loc
{
  public class LocalizeTarget_TextMeshPro_Label : LocalizeTarget<TextMeshPro>
  {
    private TextAlignmentOptions mAlignment_RTL;
    private TextAlignmentOptions mAlignment_LTR;
    private bool mAlignmentWasRTL;
    private bool mInitializeAlignment;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static LocalizeTarget_TextMeshPro_Label() => throw null;

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void AutoRegister() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override eTermType GetPrimaryTermType(Localize cmp) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override eTermType GetSecondaryTermType(Localize cmp) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool CanUseSecondaryTerm() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool AllowMainTermToBeRTL() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool AllowSecondTermToBeRTL() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void GetFinalTerms(
      Localize cmp,
      string Main,
      string Secondary,
      out string primaryTerm,
      out string secondaryTerm)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void DoLocalize(
      Localize cmp,
      string mainTranslation,
      string secondaryTranslation)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static TMP_FontAsset GetTMPFontFromMaterial(Localize cmp, string matName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void InitAlignment_TMPro(
      bool isRTL,
      TextAlignmentOptions alignment,
      out TextAlignmentOptions alignLTR,
      out TextAlignmentOptions alignRTL)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void SetFont(TMP_Text label, TMP_FontAsset newFont) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void SetMaterial(TMP_Text label, Material newMat) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LocalizeTarget_TextMeshPro_Label() => throw null;
  }
}
