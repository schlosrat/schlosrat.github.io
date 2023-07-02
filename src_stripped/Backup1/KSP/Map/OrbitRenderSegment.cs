// Decompiled with JetBrains decompiler
// Type: KSP.Map.OrbitRenderSegment
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.impl;
using Shapes;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Map
{
  public class OrbitRenderSegment
  {
    public const float MAX_END_PARAM = 1E+15f;
    public string Name;
    public IPatchedOrbit OrbitPatch;
    public Matrix4x4 DrawLocalToWorld;
    public Matrix4x4D GenerationLocalToWorld;
    public Gradient OrbitColorGradient;
    public Color StartOrbitColor;
    public Color EndOrbitColor;
    public OrbitRenderSegment.RenderStyle OrbitRenderStyle;
    public DashStyle DashStyling;
    public bool NeedRenderConnector;
    public DashStyle ConnectorDashStyling;
    public ITransformFrame ReferenceFrame;
    public ITransformModel ViewerTransform;
    public OrbitRenderer.DrawingMode DrawingMode;
    public double StartParam;
    public double EndParam;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OrbitRenderSegment(Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateDrawData(CelestialBodyComponent mainBody) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetColors(Color startOrbitColor, Color endOrbitColor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private ITransformModel GetViewerTransform(
      IPatchedOrbit orbit,
      ITransformModel vesselMainBodyTransformModel)
    {
      throw null;
    }

    public enum RenderStyle
    {
      Solid,
      Dotted,
    }
  }
}
