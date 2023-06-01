// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.Planets.QuadDataGPU
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using UnityEngine;

namespace KSP.Rendering.Planets
{
  public struct QuadDataGPU
  {
    public Matrix4x4 quadMatrix;
    public Matrix4x4 inverseQuadMatrix;
    public int Index;
    public int UniversalIndex;
    public Vector3 position;
    public int EdgeIndex;
    public Vector3 positionOffset;
    public int Id;
    public Vector3 PositionPlanet;
  }
}
