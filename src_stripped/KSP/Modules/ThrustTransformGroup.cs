// Decompiled with JetBrains decompiler
// Type: KSP.Modules.ThrustTransformGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
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
