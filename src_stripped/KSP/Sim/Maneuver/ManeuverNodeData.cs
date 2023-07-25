// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Maneuver.ManeuverNodeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.impl;
using Newtonsoft.Json;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Sim.Maneuver
{
  public class ManeuverNodeData : IComparable<ManeuverNodeData>
  {
    public IGGuid RelatedSimID;
    public bool IsOnManeuverTrajectory;
    [JsonIgnore]
    public PatchedConicsOrbit ManeuverTrajectoryPatch;
    [JsonIgnore]
    public double CachedManeuverPatchEndUT;
    public Guid NodeID;
    public string NodeName;
    public double Time;
    public Vector3d BurnVector;
    [JsonIgnore]
    public TransformModel SimTransform;
    public double BurnRequiredDV;
    public double BurnDuration;
    public bool showOutOfFuelMessage;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ManeuverNodeData(IGGuid relatedSimID, bool isOnManeuverTrajectory, double timeParamater) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetManeuverState(PatchedConicsOrbit maneuverPatch) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int CompareTo(ManeuverNodeData other) => throw null;
  }
}
