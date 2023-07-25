// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.Planets.QuadDataGPU
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
