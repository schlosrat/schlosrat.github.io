// Decompiled with JetBrains decompiler
// Type: KSP.VFX.VFXSurfaceMapping
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.VFX
{
  [CreateAssetMenu(fileName = "Biome", menuName = "ScriptableObjects/VFXSurfaceMapping")]
  public class VFXSurfaceMapping : ScriptableObject
  {
    [SerializeField]
    public List<VFXSurfacePair> BiomeTypeToVfxSurfacePairs;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VFXSurfaceMapping() => throw null;
  }
}
