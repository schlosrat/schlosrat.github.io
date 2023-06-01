// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.OrbiterDefinition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
