// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Vegetation.VegetationItemInstanceInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using AwesomeTechnologies.VegetationSystem;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.Vegetation
{
  public class VegetationItemInstanceInfo : MonoBehaviour
  {
    public string VegetationItemInstanceID;
    public Vector3 Position;
    public Vector3 Scale;
    public Quaternion Rotation;
    public string VegetationItemID;
    public VegetationType VegetationType;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MaskVegetationItem() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VegetationItemInstanceInfo() => throw null;
  }
}
