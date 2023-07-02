// Decompiled with JetBrains decompiler
// Type: KSP.OAB.AssemblyCheckMissingResource
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  [Serializable]
  public class AssemblyCheckMissingResource : EngineeringReportFlawListCheckerBase
  {
    [Tooltip("The resource required by name.  ie. ElectricCharge")]
    public string ResourceRequired;
    [Tooltip("If True the flawed part will be highlighted when hovering the flaw item.")]
    public bool HighlightFlawedPart;
    [Tooltip("When true, this flaw also requires the resource container.")]
    public bool RequireContainer;
    [Tooltip("When true, this flaw will check for part generating the resource with an OUTFLOW")]
    public bool RequireResourceProducer;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override EngineeringReportFlawListCheckResult Check(OABSessionInformation sessionInfo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AssemblyCheckMissingResource() => throw null;
  }
}
