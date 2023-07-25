// Decompiled with JetBrains decompiler
// Type: KSP.OAB.AssemblyCheckMissingRCS
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
