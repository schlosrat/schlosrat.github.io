// Decompiled with JetBrains decompiler
// Type: KSP.Map.GeneratedPointsData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
