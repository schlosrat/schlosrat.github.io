// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.VSPInstanceData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using Unity.Mathematics;
using UnityEngine;

namespace AwesomeTechnologies.VegetationSystem
{
  public struct VSPInstanceData
  {
    public Vector3 WordspacePosition;
    public Vector2 UV;
    public Vector3 Normal;
    public Matrix4x4 Matrix;
    public Vector4 ControlData;
    public int4 OutputIndex;
    public Vector4 OutputDensity;
  }
}
