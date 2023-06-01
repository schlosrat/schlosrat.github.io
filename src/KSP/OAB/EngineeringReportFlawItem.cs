// Decompiled with JetBrains decompiler
// Type: KSP.OAB.EngineeringReportFlawItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using System;
using System.Runtime.CompilerServices;

namespace KSP.OAB
{
  [Serializable]
  public class EngineeringReportFlawItem
  {
    private Property<PartCategories> _flawCategoryProperty;
    private Property<string> _flawTitleProperty;
    private Property<EngineerReportSeverity> _flawSeverity;

    public DataContext DataContext
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public EngineeringReportFlawListCheckerBase FlawListChecker
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IObjectAssemblyPart FlawedPart
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public string TitleLocalizationTerm
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public EngineerReportSeverity Severity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public PartCategories Category
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public EngineeringReportFlawItem(
      EngineeringReportFlawListCheckerBase flawListChecker)
    {
      throw null;
    }
  }
}
