// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPGroundMaterialManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  [AddComponentMenu("Vehicle Physics/Ground Materials/Ground Material Manager")]
  public class VPGroundMaterialManager : GroundMaterialManagerBase
  {
    public GroundMaterial[] groundMaterials;
    public GroundMaterial fallback;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override GroundMaterial GetGroundMaterial(
      VehicleBase vehicle,
      GroundMaterialHit groundHit)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VPGroundMaterialManager() => throw null;
  }
}
