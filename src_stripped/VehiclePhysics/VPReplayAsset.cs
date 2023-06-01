// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPReplayAsset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  public class VPReplayAsset : ScriptableObject
  {
    public float timeStep;
    public string vehicleName;
    public string sceneName;
    public Vector3 velocity;
    public Vector3 angularVelocity;
    public List<VPReplay.Frame> recordedData;
    public string notes;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VPReplayAsset() => throw null;
  }
}
