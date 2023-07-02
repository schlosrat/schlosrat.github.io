// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_WheelLock
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.Definitions;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  [Serializable]
  public sealed class Data_WheelLock : ModuleData
  {
    [KSPDefinition]
    [Tooltip("The amount of resting torque (Brake torque) applied.\nThis module is used on landing legs to give them more grip/brake torque.")]
    public float MaxTorque;

    public override System.Type ModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Data_WheelLock() => throw null;
  }
}
