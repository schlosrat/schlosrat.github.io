// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPCameraTarget
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace VehiclePhysics
{
  [AddComponentMenu("Vehicle Physics/Camera/Camera Target")]
  public class VPCameraTarget : VehicleBehaviour
  {
    public Transform lookAtPoint;
    public Transform attachToPoint;
    public bool driverCameraIsInterior;
    [Space(5f)]
    public float viewDistance;
    public float viewHeight;
    public float viewDamping;
    public float viewMinDistance;
    [FormerlySerializedAs("viewMinHeight")]
    public float viewMinAngle;
    public float targetRadius;
    [Space(5f)]
    public bool useCustomCameras;
    public int currentCustomCamera;
    public VPCameraTarget.CustomCamera[] customCameras;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VPCameraTarget.CustomCamera GetCustomCamera(ref int targetCamIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int FindEnabledCamera(int cameraIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KeyCode MonitorCustomCameraKeys() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int[] GetCamerasByKey(KeyCode key) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VPCameraTarget() => throw null;

    [Serializable]
    public class CustomCamera
    {
      public VPCameraController.Mode mode;
      public Transform reference;
      public bool enabled;
      public bool isInteriorCamera;
      public bool isDriverCamera;
      public string onEnableMessage;
      public KeyCode key;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public CustomCamera() => throw null;
    }
  }
}
