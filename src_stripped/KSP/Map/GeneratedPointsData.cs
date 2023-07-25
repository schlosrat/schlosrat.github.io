// Decompiled with JetBrains decompiler
// Type: KSP.Map.GeneratedPointsData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using UnityEngine;

namespace KSP.Map
{
  public struct GeneratedPointsData
  {
    public IReadOnlyList<Vector3> Points;
    public IReadOnlyList<double> Parameters;
    public IReadOnlyList<Vector3> GhostPoints;
    public IReadOnlyList<double> GhostParameters;
    public Matrix4x4D LocalToWorld;
    public OrbitRenderer.CameraRenderInstance.RenderData RenderData;
  }
}
