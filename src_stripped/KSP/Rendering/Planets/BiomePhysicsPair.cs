// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.Planets.BiomePhysicsPair
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering.Planets
{
  [Serializable]
  public class BiomePhysicsPair
  {
    public PQSData.KSP2BiomeType BiomeType;
    public PhysicMaterial PhysicsMat;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BiomePhysicsPair() => throw null;
  }
}
