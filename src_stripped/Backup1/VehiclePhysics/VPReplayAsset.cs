// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPReplayAsset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
