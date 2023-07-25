// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.GroundMaterialHit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using UnityEngine;

namespace VehiclePhysics
{
  public struct GroundMaterialHit
  {
    public PhysicMaterial physicMaterial;
    public Collider collider;
    public Vector3 hitPoint;
  }
}
