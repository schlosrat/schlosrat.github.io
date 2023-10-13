// Decompiled with JetBrains decompiler
// Type: KSP.Sim.GimbalStateUtils
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
