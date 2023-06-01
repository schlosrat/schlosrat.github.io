// Decompiled with JetBrains decompiler
// Type: KSP.OAB.AssemblyCheckMissingRCS
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  [Serializable]
  public class AssemblyCheckMissingRCS : EngineeringReportFlawListCheckerBase
  {
    [Tooltip("Part names to check")]
    public List<string> landingParts;
    [Tooltip("If false it just checks if the string of the part name contains, rather than exact match")]
    public bool exactPartNameMatch;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override EngineeringReportFlawListCheckResult Check(OABSessionInformation sessionInfo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AssemblyCheckMissingRCS() => throw null;
  }
}
