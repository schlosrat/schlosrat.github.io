// Decompiled with JetBrains decompiler
// Type: KSP.OAB.AssemblyCheckerMissingHeatShield
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  [Serializable]
  public class AssemblyCheckerMissingHeatShield : EngineeringReportFlawListCheckerBase
  {
    [Tooltip("List of Part Families that the Missing Heat Shield check will limit to.")]
    public string[] limitedToPartFamilies;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override EngineeringReportFlawListCheckResult Check(OABSessionInformation sessionInfo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AssemblyCheckerMissingHeatShield() => throw null;
  }
}
