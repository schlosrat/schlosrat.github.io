// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.GroundMaterialManagerBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  public abstract class GroundMaterialManagerBase : MonoBehaviour
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract GroundMaterial GetGroundMaterial(
      VehicleBase vehicle,
      GroundMaterialHit groundHit)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void GetGroundMaterialCached(
      VehicleBase vehicle,
      GroundMaterialHit groundHit,
      ref GroundMaterialHit cachedGroundHit,
      ref GroundMaterial groundMaterial)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected GroundMaterialManagerBase() => throw null;
  }
}
