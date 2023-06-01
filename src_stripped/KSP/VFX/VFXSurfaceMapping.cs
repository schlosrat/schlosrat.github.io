// Decompiled with JetBrains decompiler
// Type: KSP.VFX.VFXSurfaceMapping
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
