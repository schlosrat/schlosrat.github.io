// Decompiled with JetBrains decompiler
// Type: KSP.Map.OrbitRenderer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Messages;
using KSP.Sim;
using KSP.Sim.impl;
using Shapes;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Map
{
  public class OrbitRenderer : KerbalImmediateModeShapeDrawer
  {
    private Dictionary<IGGuid, OrbitRenderer.OrbitRenderData> _orbitRenderData;
    private Dictionary<Camera, OrbitRenderer.CameraRenderInstance> _cameraRenderInstances;
    private Map3DSpaceProvider _mapSpaceProvider;
    private SubscriptionHandle _handleShutdown;
    private bool _debugGhostOrbits;
    private double ORBIT_SCALE_CELESTIAL;
    private IGGuid _maneuverGuid;
    private IGGuid _currentActiveVesselTarget;

    public Dictionary<Camera, OrbitRenderer.CameraRenderInstance> CameraRenderInstances
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(Map3DSpaceProvider spaceProvider) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SyncManeuverOrbits() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SyncRendersToOrbiter() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateOrbitStyling() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateSegmentsMatrix() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RenderInstanceUpkeep() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateExistingRenderInstances() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddOrbit(IGGuid guid, CelestialBodyComponent celestialBodyComponent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddOrbit(IGGuid guid, VesselComponent vesselComponent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateRenderedManeuver(IGGuid guid, VesselComponent vesselComponent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveManeuverOrbit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OrbitRenderSegment GenerateSegmentFromOrbit(
      IGGuid guid,
      IPatchedOrbit patch,
      CelestialBodyComponent mainBody,
      Color orbitColor,
      int index = 0)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveOrbit(IGGuid guid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemoveRenderInstance(Camera cam) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveAll() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnShutdown(MessageCenterMessage message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void DrawShapes(Camera cam) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeGenerator(
      OrbitRenderer.CameraRenderInstance renderInstance,
      OrbitRenderer.CameraRenderInstance.RenderData data)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GeneratePoints(
      OrbitRenderer.CameraRenderInstance.RenderData data,
      bool generateRelativeOrbitPath)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DrawCameraInstance(OrbitRenderer.CameraRenderInstance instance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DrawConnector(
      OrbitRenderer.CameraRenderInstance.RenderData startData,
      OrbitRenderer.CameraRenderInstance.RenderData endData,
      bool fade)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private PolylinePath GenerateConnectorPath(
      OrbitRenderer.CameraRenderInstance.RenderData startData,
      OrbitRenderer.CameraRenderInstance.RenderData endData)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetPointsFor(
      Camera cam,
      IGGuid guid,
      bool includeGhostOrbit,
      out IReadOnlyList<GeneratedPointsData> pointDataList)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetPointsFor(
      Camera cam,
      IGGuid guid,
      bool getManeuverData,
      bool includeGhostOrbit,
      out IReadOnlyList<GeneratedPointsData> pointDataList)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetPointsForPatch(
      Camera cam,
      IGGuid guid,
      IPatchedOrbit patch,
      bool getManeuverData,
      bool includeGhostOrbit,
      out IReadOnlyList<GeneratedPointsData> pointDataList)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetSegmentDataFor(
      OrbitRenderer.CameraRenderInstance.RenderData data,
      bool isFirst,
      bool getGhostPoints,
      out GeneratedPointsData generatedPointsData)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d GetPointForParameter(
      Camera cam,
      IGGuid orbiterGUID,
      bool isManeuver,
      double parameter)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double ParameterTo01(double parameter, OrbitRenderSegment segment) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Color GetOrbitColor(OrbitRenderSegment segment, double parameter) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ITransformModel GetViewerTransform(
      ITransformModel segmentTransformModel,
      ITransformModel vesselMainBodyTransformModel)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OrbitRenderer() => throw null;

    public class OrbitRenderData
    {
      public IGGuid ParentGuid;
      public bool IsCelestialBody;
      public bool IsManeuver;
      public int Layer;
      public double OrbitThickness;
      public OrbiterComponent Orbiter;
      public VesselComponent Vessel;
      public List<OrbitRenderSegment> Segments;
      public Color DefaultOrbitColor;
      public bool IsHighlighted;
      public bool IsClosedLoop;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public OrbitRenderData(
        IGGuid parentGuid,
        bool isCelestialBody,
        bool isManeuver,
        OrbiterComponent orbiter,
        VesselComponent vessel,
        Color defaultColor,
        double orbitThickness)
      {
        throw null;
      }
    }

    public class CameraRenderInstance : IDisposable
    {
      public Camera RenderCamera;
      public DictionaryValueList<OrbitRenderSegment, OrbitRenderer.CameraRenderInstance.RenderData> CameraRenderData;
      public Dictionary<OrbitRenderer.CameraRenderInstance.RenderData, Coroutine> ActiveRenderOperations;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public CameraRenderInstance(Camera cam) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Dispose() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void UpdateRenderData(
        Dictionary<IGGuid, OrbitRenderer.OrbitRenderData> dataCollection)
      {
        throw null;
      }

      public class RenderData : IDisposable
      {
        public OrbitRenderer.OrbitRenderData OrbitData;
        public OrbitRenderSegment Segment;
        public ParametricLineGenerator Generator;
        public PolylinePath Path;
        public ParametricLineGenerator RelativeOrbitGenerator;
        public PolylinePath RelativeOrbitPath;
        public ParametricLineGenerator GhostGenerator;
        public PolylinePath GhostPath;

        [MethodImpl(MethodImplOptions.NoInlining)]
        public RenderData(OrbitRenderer.OrbitRenderData data, OrbitRenderSegment segment) => throw null;

        [MethodImpl(MethodImplOptions.NoInlining)]
        public void ConfigureGenerator(ParametricLineGenerator generator) => throw null;

        [MethodImpl(MethodImplOptions.NoInlining)]
        public bool PointsInSpace(
          ref List<Vector3> points,
          ref List<double> parameters,
          ref List<Vector3> ghostPoints,
          ref List<double> ghostParameters,
          out Matrix4x4D localToWorld,
          bool isFirstPatch = false,
          bool getGhostPoints = false)
        {
          throw null;
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public void Dispose() => throw null;
      }
    }

    public enum DrawingMode
    {
      LocalToBodyInEccentricAnomaly,
      LocalToBodyInUniversalTime,
      RelativeToInUniversalTime,
    }
  }
}
