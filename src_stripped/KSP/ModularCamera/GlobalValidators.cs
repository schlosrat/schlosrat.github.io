// Decompiled with JetBrains decompiler
// Type: KSP.ModularCamera.GlobalValidators
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.PhysicsUtils;
using System.Runtime.CompilerServices;

namespace KSP.ModularCamera
{
  public static class GlobalValidators
  {
    private static float EPSILON_SQR;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool SetActualDistToTargetDist(ICameraDriver driver, ValidatorType type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool SetTargetDistToActualDist(ICameraDriver driver, ValidatorType type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Validator DoAllUntilFirstValid(params Validator[] toRun) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Validator DoAll(params Validator[] toRun) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Validator MinTargetDistance(float minTargetDist) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Validator MinCameraDistance(float minCameraDist) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Validator MinCameraDistanceForceCamera(float minCameraDist) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Validator MoveBasedOnCollisions(TriggerIntersectionWatcher watcher, bool debug = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static GlobalValidators() => throw null;
  }
}
