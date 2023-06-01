// Decompiled with JetBrains decompiler
// Type: KSP.Sim.DeltaV.DeltaVExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Logging;
using System.Runtime.CompilerServices;

namespace KSP.Sim.DeltaV
{
  public static class DeltaVExtensions
  {
    public const LogFilter LOGTAG = LogFilter.Gameplay;
    public const string PREFIX = "[DeltaVSystem] ";

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static T GetSwitchedValue<T>(
      this DeltaVSituationOptions situation,
      T asl,
      T actual,
      T vac)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int CurrentStage(VesselDeltaVComponent vesselDV) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool CurrentStageActive(VesselDeltaVComponent vesselDV) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int LastStage(VesselDeltaVComponent vesselDV) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int LastStageWithEngine(VesselDeltaVComponent vesselDV) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool ModeIsFlight(VesselDeltaVComponent vesselDV) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool ModeIsOAB(VesselDeltaVComponent vesselDV) => throw null;
  }
}
