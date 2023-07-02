// Decompiled with JetBrains decompiler
// Type: I2.Loc.LocalizeTarget_UnityStandard_GUITexture
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace I2.Loc
{
  public class LocalizeTarget_UnityStandard_GUITexture : LocalizeTarget<Image>
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    static LocalizeTarget_UnityStandard_GUITexture() => throw null;

    [RuntimeInitializeOnLoadMethod]
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
    public LocalizeTarget_UnityStandard_GUITexture() => throw null;
  }
}
