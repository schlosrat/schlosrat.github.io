// Decompiled with JetBrains decompiler
// Type: KSP.VFX.FXPartContextData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using UnityEngine;

namespace KSP.VFX
{
  [Serializable]
  public struct FXPartContextData
  {
    public bool IsPressurized;
    public string FuelType;
    public float FuelQuantity;
    public Vector3 AttachNodePosition;
    public float AttachNodeSize;
    public float ExplosionPotential;
    public float PartTemperature;
    public float ExposedSurfaceArea;
    public Vector3 PartVelocity;
    public float PartSurfaceDistance;
    public Vector3 PartSurfaceVector;
    public Vector3 PartSurfaceVectorReflected;
    public float RaycastDistance;
    public float DeviationFromVertical;
    public float PartRelativeVelocity;
  }
}
