// Decompiled with JetBrains decompiler
// Type: KSP.Sim.GimbalStateUtils
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
