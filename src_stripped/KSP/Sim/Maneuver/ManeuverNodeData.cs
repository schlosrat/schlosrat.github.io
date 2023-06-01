// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Maneuver.ManeuverNodeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
