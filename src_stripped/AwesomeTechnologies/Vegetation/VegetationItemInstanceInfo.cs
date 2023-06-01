// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Vegetation.VegetationItemInstanceInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
