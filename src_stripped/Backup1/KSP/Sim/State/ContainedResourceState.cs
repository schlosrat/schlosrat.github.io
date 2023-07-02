// Decompiled with JetBrains decompiler
// Type: KSP.Sim.State.ContainedResourceState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using UnityEngine.Serialization;

namespace KSP.Sim.State
{
  [Serializable]
  public struct ContainedResourceState
  {
    public string name;
    [FormerlySerializedAs("amount")]
    public double storedUnits;
    [FormerlySerializedAs("maxAmount")]
    public double capacityUnits;
  }
}
