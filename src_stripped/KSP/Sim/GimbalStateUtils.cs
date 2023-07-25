// Decompiled with JetBrains decompiler
// Type: KSP.Sim.GimbalStateUtils
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
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
