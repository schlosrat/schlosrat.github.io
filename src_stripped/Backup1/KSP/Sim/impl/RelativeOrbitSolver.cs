// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.RelativeOrbitSolver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
