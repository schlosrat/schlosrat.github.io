// Decompiled with JetBrains decompiler
// Type: KSP.Sim.GimbalStateUtils
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim
{
  public static class GimbalStateUtils
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool TryComputeCameraGimbalStateFromUnityTransforms(
      Transform gimbalRootTransform,
      Transform cameraTransform,
      out GimbalState cameraGimbalState)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool TryComputeCameraGimbalStateFromUnityTransforms(
      Transform gimbalPositionRootTransform,
      Transform gimbalRotationRootTransform,
      Transform cameraTransform,
      out GimbalState cameraGimbalState)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool TryComputeTargetCameraGimbalStateFromUnityRotations(
      QuaternionD originalRotation,
      QuaternionD targetRotation,
      out GimbalState targetGimbalState,
      Transform cameraTransform)
    {
      throw null;
    }
  }
}
