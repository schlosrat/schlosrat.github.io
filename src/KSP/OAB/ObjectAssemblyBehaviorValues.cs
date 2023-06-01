// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ObjectAssemblyBehaviorValues
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  [Serializable]
  public class ObjectAssemblyBehaviorValues
  {
    [Tooltip("Panning speed when using the middle mouse click")]
    [Header("General")]
    public float DragSpeed;
    [Tooltip("If mirror technique is auto, this is the technique we use instead. Cannot be auto.")]
    public MirrorTechnique DefaultMirrorTechnique;
    [Tooltip("Mesured in seconds. An action opening the PAM must have the input start and end within this time, otherwise that possibility times out and we don't display the PAM. Other restrictions include 'must be the same part you started on'")]
    public float PAMClickTimeout;
    [Header("Camera")]
    [Tooltip("Scalar for how much movement is seen from a single scrollwheel tick")]
    public float CameraSpeedZoom;
    [Tooltip("Scalar for how much movement is seen from a single scrollwheel tick with the modifier key pressed")]
    public float CameraSpeedZoomPrecise;
    [Tooltip("Scalar How responsive the camera is when looking about with right-click drag in free mode")]
    public float CameraSpeedRotate;
    [Tooltip("Scalar How responsive the camera is when looking about with right stick.")]
    public float GamepadCameraSpeedRotate;
    [Tooltip("Scalar How responsive the camera is when looking about with right-click drag and the modifier key is pressed in free mode")]
    public float CameraSpeedRotatePrecise;
    [Tooltip("Scalar How responsive the camera is when looking about with right-click drag in orbit mode")]
    public float OrbitalCameraSpeedRotate;
    [Tooltip("Scalar How responsive the camera is when looking about with right-click drag and the modifier key is pressed in orbit mode")]
    public float OrbitalCameraSpeedRotatePrecise;
    [Tooltip("A scalar for the speed of the camera when moving with the arrow keys")]
    public float CameraSpeedMove;
    [Tooltip("The value which camera changes get multiplied by when the fast movement multiplier (turbo button, usually shift) is on.")]
    public float CameraSpeedTurboScalar;
    [Tooltip("The Action that will cause a part to become the camera orbit center")]
    public AutoFocusActionBind PartAutoFocusAction;
    [Tooltip("Interval of Grid Divisions for the Heavy grid lines.")]
    [Range(2f, 64f)]
    [Header("Blueprint")]
    public int gridDivisions;
    [Tooltip("Interval of Grid Subdivisions for the Light grid lines.")]
    [Range(2f, 10f)]
    public int gridSubdivisions;
    [Tooltip("Distance from Environment Center to place the Blueprint Grid.")]
    public float blueprintDistance;
    [Header("Attachment Behaviors")]
    public float NodeDistToConsiderConnection;
    [Tooltip("A value that impacts all attach node snapping distances. The higher the multiplier, the more likely it is to snap to a node from a further distance.")]
    public float NodeSnapScalar;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectAssemblyBehaviorValues() => throw null;
  }
}
