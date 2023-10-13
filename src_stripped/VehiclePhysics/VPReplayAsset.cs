// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPReplayAsset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
