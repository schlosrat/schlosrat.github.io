// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Vegetation.PersistentStorage.PersistentVegetationItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using UnityEngine;

namespace AwesomeTechnologies.Vegetation.PersistentStorage
{
  [Serializable]
  public struct PersistentVegetationItem
  {
    public Vector3 Position;
    public Vector3 Scale;
    public Quaternion Rotation;
    public int VegetationSourceID;
    public float DistanceFalloff;
  }
}
