// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.ReferenceSpecs
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace VehiclePhysics
{
  [Serializable]
  public class ReferenceSpecs
  {
    public float maxSpeed;
    public float maxRpm;
    public float maxTorque;
    public float maxPower;
    public int numGears;
    public float maxSuspensionDistance;
    public float maxSpringRate;
    public float maxAccelerationG;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ReferenceSpecs() => throw null;
  }
}
