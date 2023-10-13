// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.ReferenceSpecs
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
