// Decompiled with JetBrains decompiler
// Type: KSP.OAB.EngineeringReportFlawListSetup
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
  public class EngineeringReportFlawListSetup
  {
    [Header("Assembly Contains Part of Category")]
    public List<AssemblyCheckerContainsPartCategory> CheckersContainsCategory;
    [Header("Assembly Fits in OAB")]
    public List<AssemblyCheckerWithinOABBounds> CheckersWithinOABBounds;
    [Header("OAB has Enough Resources")]
    public List<AssemblyCheckerOABHasEnoughResources> CheckersHasEnoughResources;
    [Header("Assembly has Command Pod with Parachute")]
    public List<AssemblyCheckerCommandPodWithNoParachute> CheckersCommandPodWithNoParachutes;
    [Header("Assembly has Command Pod but no heatshield")]
    public List<AssemblyCheckerMissingHeatShield> CheckersMissingHeatShield;
    [Header("Assembly has heat generating part but no Radiator")]
    public List<AssemblyCheckerMissingRadiator> CheckersMissingRadiator;
    [Header("Assembly is Missing an RCS Engine")]
    public List<AssemblyCheckMissingRCS> CheckersMissingRCS;
    [Header("Assembly has a Founder's Module but No Crew")]
    public List<AssemblyCheckerNoCrewWithFoundersModule> CheckersNoCrewWithFoundersModule;
    [Header("Assembly has no communication antenna part")]
    public List<AssemblyCheckMissingDataTransmitter> CheckersNoDataTransmitterModule;
    [Header("Assembly has not enough thrust to take off")]
    public List<AssemblyCheckNotEnoughThrust> CheckersNotEnoughThrust;
    [Header("Assembly has at least one engine lacking necessary fuels to operate")]
    public List<AssemblyCheckEnginesNecessaryFuels> CheckerEnginesMissingNecessaryFuels;
    [Header("Assembly has a part missing resource depending on Flow")]
    public List<AssemblyCheckMissingResource> CheckerPartMissingResource;

    public List<EngineeringReportFlawListCheckerBase> BakedCheckerList
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public EngineeringReportFlawListSetup() => throw null;
  }
}
