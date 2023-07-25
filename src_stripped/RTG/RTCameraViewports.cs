// Decompiled with JetBrains decompiler
// Type: RTG.RTCameraViewports
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class RTCameraViewports : Singleton<RTCameraViewports>
  {
    private List<Camera> _cameras;

    public event RTCameraViewports.CameraAddedHandler CameraAdded
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event RTCameraViewports.CameraRemovedHandler CameraRemoved
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event RTCameraViewports.FocusCameraChangedHandler FocusCameraChanged
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public Camera FocusCamera
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int NumCameras
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ContainsCamera(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddCamera(Camera camera, Rect normViewRect) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddCamera(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveCamera(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetFocusCamera(int cameraIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetFocusCamera(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RTCameraViewports() => throw null;

    public delegate void CameraAddedHandler(Camera camera);

    public delegate void CameraRemovedHandler(Camera camera);

    public delegate void FocusCameraChangedHandler(Camera oldFocusCam, Camera newFocusCam);
  }
}
