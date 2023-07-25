// Decompiled with JetBrains decompiler
// Type: KSP.Sim.SerializedActiveCameraInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  [Serializable]
  public class SerializedActiveCameraInfo
  {
    public const CameraID DEFAULT_ACTIVE_CAMERA_ID = CameraID.None;
    public const CameraMode DEFAULT_ACTIVE_CAMERA_MODE = CameraMode.None;
    public const double DEFAULT_DISTANCE = 0.0;
    public const double DEFAULT_YAW = 0.0;
    public const double DEFAULT_PITCH = 0.0;
    public static readonly SerializedActiveCameraInfo Default;
    public CameraID ActiveCameraId;
    public CameraMode ActiveCameraMode;
    public double Distance;
    public double Yaw;
    public double Pitch;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedActiveCameraInfo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedActiveCameraInfo(SerializedActiveCameraInfo src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedActiveCameraInfo(
      CameraID activeCameraId,
      CameraMode activeCameraMode,
      double distance,
      double yaw,
      double pitch)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(SerializedActiveCameraInfo src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(
      CameraID activeCameraId,
      CameraMode activeCameraMode,
      double distance,
      double yaw,
      double pitch)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetAllValues() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set(SerializedActiveCameraInfo src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set(
      CameraID activeCameraId,
      CameraMode activeCameraMode,
      double distance,
      double yaw,
      double pitch)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetDebugString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Matches(SerializedActiveCameraInfo other) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static SerializedActiveCameraInfo() => throw null;
  }
}
