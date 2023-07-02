// Decompiled with JetBrains decompiler
// Type: KSP.Map.GeneratedPointsData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
