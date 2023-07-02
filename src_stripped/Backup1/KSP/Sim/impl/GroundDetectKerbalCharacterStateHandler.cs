// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.GroundDetectKerbalCharacterStateHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Utilities;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

namespace KSP.Sim.impl
{
  public class GroundDetectKerbalCharacterStateHandler : KerbalCharacterStateHandler
  {
    private const int GROUND_SPHERECAST_COMMAND_COUNT = 2;
    private const int GROUND_SPHERECAST_COMMAND_PRESENT_INDEX = 0;
    private const int GROUND_SPHERECAST_COMMAND_FUTURE_INDEX = 1;
    private const int GROUND_CONTACT_NORMAL_AVERAGE_MAX_SAMPLES = 20;
    [HideInInspector]
    public CollisionResult GroundPresentCollisionResult;
    [HideInInspector]
    public CollisionResult GroundFutureCollisionResult;
    private NativeArray<SpherecastCommand> _groundSpherecastCommands;
    private NativeArray<RaycastHit> _groundSpherecastHits;
    private SimpleMovingAverage _groundPresentContactNormalSmoother;
    private JobHandle _groundSpherecastJobHandle;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GroundDetectKerbalCharacterStateHandler(KerbalBehavior kerbalBehavior) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Deinitialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool Update(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool LateUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeGroundSpherecast() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DeinitializeGroundSpherecast() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CalculateGroundContactNormalSmoothed() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ScheduleGroundSpherecast() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessGroundSpherecast() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessGroundContactVessel(Rigidbody oldContactRigidbody) => throw null;
  }
}
