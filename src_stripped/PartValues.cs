// Decompiled with JetBrains decompiler
// Type: PartValues
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
