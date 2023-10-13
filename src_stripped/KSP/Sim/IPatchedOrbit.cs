// Decompiled with JetBrains decompiler
// Type: KSP.Sim.IPatchedOrbit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;

namespace KSP.Sim
{
  public interface IPatchedOrbit : IOrbit, IDisposable, IComparable<IPatchedOrbit>
  {
    double StartUT { get; set; }

    double EndUT { get; set; }

    bool ActivePatch { get; set; }

    PatchTransitionType PatchStartTransition { get; set; }

    PatchTransitionType PatchEndTransition { get; set; }

    IPatchedOrbit NextPatch { get; set; }

    IPatchedOrbit PreviousPatch { get; set; }

    double UniversalTimeAtClosestApproach { get; set; }

    double UniversalTimeAtSoiEncounter { get; set; }

    double ClosestApproachDistance { get; set; }

    double TimeToPe { get; set; }

    double TimeToAp { get; set; }
  }
}
