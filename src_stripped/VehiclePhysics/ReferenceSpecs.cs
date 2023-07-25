// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.ReferenceSpecs
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
