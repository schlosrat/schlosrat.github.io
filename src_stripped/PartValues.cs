// Decompiled with JetBrains decompiler
// Type: PartValues
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

public class PartValues : EventValueWrapper
{
  public EventValueComparisonObsolete<float> MaxThrottle;
  public EventValueComparisonObsolete<float> HeatProduction;
  public EventValueComparisonObsolete<float> FuelUsage;
  public EventValueComparisonObsolete<float> EnginePower;
  public EventValueComparisonObsolete<float> SteeringRadius;
  public EventValueComparisonObsolete<int> AutopilotSkill;
  public EventValueComparisonObsolete<int> RepairSkill;
  public EventValueComparisonObsolete<int> ScienceSkill;
  public EventValueComparisonObsolete<float> CommsRange;
  public EventValueOperationObsolete<float> ScienceReturnSum;
  public EventValueComparisonObsolete<float> ScienceReturnMax;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public PartValues() => throw null;
}
