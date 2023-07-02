// Decompiled with JetBrains decompiler
// Type: KSP.Modules.ThrustTransformGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  [Serializable]
  public class ThrustTransformGroup
  {
    [Tooltip("The Thrust Transform name in the model for this ThrustTransform - Multiplier combo.\n")]
    public string ThrustTransformName;
    [Tooltip("Proportional contribution of this Thrust Transform.\nThe sum of all values must be equal to a value of exactly 1 (which represents 100%).")]
    public float ThrustTransformMultiplier;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ThrustTransformGroup() => throw null;
  }
}
