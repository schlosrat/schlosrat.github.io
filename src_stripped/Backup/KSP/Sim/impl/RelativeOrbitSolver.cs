// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.RelativeOrbitSolver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class RelativeOrbitSolver
  {
    private const string TARGET_GUID_STR = "target";
    private readonly ISimulationModelMap _simMap;
    private readonly ITransformModel _targetRefFrameITransformModel;
    private readonly IOrbit _targetOrbit;
    private readonly Dictionary<TransformModel, IOrbit> _transformOrbitTable;
    private readonly ITransformModel _viewerITransformModel;
    private TransformModel _subTreeRoot;
    private TransformModel _targetTransform;
    private TransformModel _viewerTransform;
    private bool _isInitialized;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RelativeOrbitSolver(
      ITransformModel viewerITransformModel,
      IOrbit targetOrbit,
      ISimulationModelMap map)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d GetOrbitPositionTargetToViewerAtUt(double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d GetOrbitVelocityTargetToViewerAtUt(double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PopulateTransformOrbitTable(
      TransformModel subTreeTransformModel,
      ISimulationModelMap simMap)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private TransformModel GetTransformFromGuidInMap(string guid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateAllPositions(double universalTime) => throw null;
  }
}
