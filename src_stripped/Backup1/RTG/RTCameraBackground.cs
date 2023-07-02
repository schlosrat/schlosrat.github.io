// Decompiled with JetBrains decompiler
// Type: RTG.RTCameraBackground
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class RTCameraBackground : MonoSingleton<RTCameraBackground>
  {
    [SerializeField]
    private CameraBackgroundSettings _bkSettings;
    [SerializeField]
    private List<Camera> _renderIgnoreCameras;
    private Dictionary<Camera, CameraBackgroundSettings> _cameraToBkSettings;

    public CameraBackgroundSettings Settings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCameraBkSettings(Camera camera, CameraBackgroundSettings bkSettings) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<Camera> GetAllRenderIgnoreCameras() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsRenderIgnoreCamera(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddRenderIgnoreCamera(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveRenderIgnoreCamera(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Render_SystemCall(Camera renderCamera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RTCameraBackground() => throw null;
  }
}
