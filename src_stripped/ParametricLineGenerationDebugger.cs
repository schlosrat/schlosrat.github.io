// Decompiled with JetBrains decompiler
// Type: ParametricLineGenerationDebugger
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

[ExecuteInEditMode]
public class ParametricLineGenerationDebugger : MonoBehaviour
{
  public bool debugPrint;
  [Min(0.0f)]
  public float debugPrintDelay;
  [Header("Points")]
  public bool drawPoints;
  public bool drawLines;
  [Range(0.15f, 25f)]
  public float pointWorldSizeExp;
  [FormerlySerializedAs("sizeIterations")]
  public bool sizePointsByIteration;
  [Range(0.0f, 1f)]
  public float lineOpacity;
  [Header("Bounds")]
  public bool drawBounds;
  [Range(0.0f, 1f)]
  public float boundsOpacity;
  public bool showBoundsMisses;
  [Header("Iteration Debugging")]
  [Range(-1f, 20f)]
  public int drawOnlyIteration;
  public Gradient iterationGradient;
  private bool _canDebugOutput;
  private Dictionary<Camera, ParametricLineGenerator> _cameraGeneratorMap;
  private Dictionary<ParametricLineGenerator, ParametricLineGenerationDebugger.DebugRenderInstance> _generatorInstanceMap;
  private List<Camera> _scratchCameraToRemove;
  private List<ParametricLineGenerator> _scratchGenerators;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void ClearDebug() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void UpdateForDebug(ParametricLineGenerator generator, Camera cam) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDisable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDrawGizmos() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void HandleDebugPrinting(
    ParametricLineGenerationDebugger.DebugRenderInstance instance)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void GrabLineGeneratorValues(ParametricLineGenerator generator) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void HandleDebugDrawing(
    ParametricLineGenerationDebugger.DebugRenderInstance instance)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void HandlePointDrawing(
    ParametricLineGenerationDebugger.DebugRenderInstance instance)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void HandleLineDrawing(
    ParametricLineGenerationDebugger.DebugRenderInstance instance)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void HandleBoundsDrawing(
    ParametricLineGenerationDebugger.DebugRenderInstance instance)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void HandleCameraDrawing(
    ParametricLineGenerationDebugger.DebugRenderInstance instance)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static void DrawPoint(Vector3 point, float size = 0.1f) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static Color FixGammaColor(Color color) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public ParametricLineGenerationDebugger() => throw null;

  public class DebugRenderInstance
  {
    public float debugPrintDelay;
    public float lastPrintTime;
    public ParametricLineGenerator generator;
    public List<Vector3> localPoints;
    public List<double> parameters;
    public List<Color> colors;
    public List<int> iterations;
    public int curIterations;
    public List<ParametricLineGenerator.GenerationStep> generationSteps;
    public List<ParametricLineGenerator.BoundsNode> bounds;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DebugRenderInstance() => throw null;
  }
}
