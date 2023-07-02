// Decompiled with JetBrains decompiler
// Type: KSP.OAB.EngineeringReportFlawItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
