// Decompiled with JetBrains decompiler
// Type: I2.Loc.LocalizeTarget_UnityStandard_AudioSource
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace I2.Loc
{
  public class LocalizeTarget_UnityStandard_AudioSource : LocalizeTarget<AudioSource>
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    static LocalizeTarget_UnityStandard_AudioSource() => throw null;

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
    public LocalizeTarget_UnityStandard_AudioSource() => throw null;
  }
}
