// Decompiled with JetBrains decompiler
// Type: KSP.Map.OrbitRendererConfiguration
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using Shapes;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Map
{
  [CreateAssetMenu(fileName = "OrbitRendererConfiguration", menuName = "ScriptableObjects/Orbit Renderer Configuration")]
  public class OrbitRendererConfiguration : ScriptableObject
  {
    [Space]
    [Range(0.0f, 32f)]
    public int MaxIterations;
    public SubdivisionHeuristic SubdivisionHeuristics;
    [Header("Subdivision Heuristic: TriangleArea")]
    [Range(1f, 40f)]
    public double TriangleAreaMin;
    [Header("Subdivision Heuristic: ScreenSizeRatio")]
    [Range(1f, 0.0f)]
    public double ScreenSizeRatioMax;
    [Range(1f, 0.0f)]
    [Header("Subdivision Heuristic: SquaredPerimeter")]
    public double SquarePerimeterSizeRatioMin;
    [Range(1f, 40f)]
    public double SquaredPerimeterMin;
    [Min(4f)]
    [Space]
    public int SeedPointsPerPeriod;
    [Min(32f)]
    public int MaxSeedPointsToGenerate;
    [Min(32f)]
    public int MaxCountPerPeriod;
    [Space]
    [Min(0.0f)]
    public float GenerationDelay;
    [Header("Point Rendering", order = 1)]
    [Space(order = 0)]
    public bool UsePolyline;
    public ShapesBlendMode BlendMode;
    public ThicknessSpace ThicknessSpace;
    [Space]
    public bool ThicknessUsesMapScale;
    [Space]
    public bool FadeScreenspaceThickness;
    [Min(1f)]
    public float MinScreenspacePixelThickness;
    public Color ThicknessFadeColor;
    [Space]
    public Color DefaultMapObjectColor;
    public Color ActiveVesselMapColor;
    public Color NonActiveVesselColor;
    public int MapDefaultDottedLineSize;
    [Space]
    public Color TrajectoryOrbitStartColor;
    public Color TrajectoryOrbitEndColor;
    [Min(0.0f)]
    public float TrajectoryOrbitThickness;
    public OrbitRenderSegment.RenderStyle TrajectoryOrbitRenderStyle;
    [Min(0.0f)]
    public float TrajectoryOrbitDashLength;
    [Min(0.0f)]
    public float TrajectoryOrbitDashGap;
    [Space]
    public Color ManeuverCoastingStartColor;
    public Color ManeuverCoastingEndColor;
    [Min(0.0f)]
    public float ManeuverOrbitThickness;
    public OrbitRenderSegment.RenderStyle ManeuverOrbitRenderStyle;
    [Min(0.0f)]
    public float ManeuverOrbitDashLength;
    [Min(0.0f)]
    public float ManeuverOrbitDashGap;
    [Space]
    public Color ManeuverNonImpulseStartColor;
    public Color ManeuverNonImpulseEndColor;
    public OrbitRenderSegment.RenderStyle ManeuverNonImpulseRenderStyle;
    [Min(0.0f)]
    public float ManeuverNonImpulseDashLength;
    [Min(0.0f)]
    public float ManeuverNonImpulseDashGap;
    [Space]
    [Min(0.0f)]
    public float CelestialBodyOrbitThickness;
    public OrbitRenderSegment.RenderStyle CelestialBodyRenderStyle;
    [Min(0.0f)]
    public float CelestialBodyOrbitDashLength;
    [Min(0.0f)]
    public float CelestialBodyOrbitDashGap;
    [Space]
    public Color NonActiveVesselOrbitStartColor;
    public Color NonActiveVesselOrbitEndColor;
    [Space]
    public Color NonLocallyOwnedOrbitStartColor;
    public Color NonLocallyOwnedOrbitEndColor;
    [Space]
    public Color TargetOrbitStartColor;
    public Color TargetOrbitEndColor;
    [Space]
    public Color AnDnColor;
    public float AnDnLineThickness;
    [Space]
    [Min(0.0f)]
    public float TrajectoryConnectorThickness;
    [Min(0.0f)]
    public float TrajectoryConnectorDashLength;
    [Min(0.0f)]
    public float TrajectoryConnectorDashGap;
    [Space]
    public bool PerPatchGradients;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OrbitRendererConfiguration() => throw null;
  }
}
