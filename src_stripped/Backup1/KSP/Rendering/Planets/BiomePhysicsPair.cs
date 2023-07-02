// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.Planets.BiomePhysicsPair
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
