// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Vegetation.PersistentStorage.PersistentVegetationItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
