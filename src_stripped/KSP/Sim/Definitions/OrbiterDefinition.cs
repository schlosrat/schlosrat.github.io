// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.OrbiterDefinition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.impl;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.Definitions
{
  [Serializable]
  public struct OrbiterDefinition
  {
    public Color orbitColor;
    public Color nodeColor;
    public float lowerCamVsSmaRatio;
    public float upperCamVsSmaRatio;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Defaults(out OrbiterDefinition defaults) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void FromOrbiterComponent(OrbiterComponent cb, out OrbiterDefinition definition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static OrbiterDefinition FromSerializedOrbiterDefinition(
      SerializedOribiterDefinition serializedOrbiterDefinition)
    {
      throw null;
    }
  }
}
