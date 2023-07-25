// Decompiled with JetBrains decompiler
// Type: KSP.Sim.DeltaV.IDeltaVPartExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Modules;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim.DeltaV
{
  public static class IDeltaVPartExtensions
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsPartDecoupler(this IDeltaVPart PartRef, out Data_Decouple dataDecoupler) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsPartLaunchClamp(
      this IDeltaVPart PartRef,
      out Data_GroundLaunchClamp dataLaunchClamp)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsPartDockingPort(
      this IDeltaVPart PartRef,
      out Data_DockingNode dataDockingPort)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsPartEngine(this IDeltaVPart PartRef, out Data_Engine dataEngine) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsPartFairing(this IDeltaVPart PartRef) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsPartAirIntake(this IDeltaVPart PartRef, out Data_ResourceIntake intake) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsPartSolarPanel(this IDeltaVPart PartRef, out Data_SolarPanel solarPanel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsPartGenerator(this IDeltaVPart PartRef, out Data_ModuleGenerator generator) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IDeltaVPart Get(this IEnumerable<IDeltaVPart> list, IDeltaVPart partToMatch) => throw null;
  }
}
