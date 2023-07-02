// Decompiled with JetBrains decompiler
// Type: KSP.Sim.IKSPCamera
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using UnityEngine;

namespace KSP.Sim
{
  public interface IKSPCamera
  {
    bool enabled { get; }

    Transform transform { get; }

    float StartDistance { get; }

    float MaxDistance { get; }

    float MinDistance { get; }

    float Distance { get; }

    float camPitch { get; set; }

    float camHdg { get; set; }

    Quaternion pivotRotation { get; }

    Matrix4x4 cullingMatrix { get; set; }

    int cullingMask { get; set; }

    Transform GetPivot();

    Camera GetCamera();

    Transform GetCameraTransform();

    Vector3 WorldToViewportPoint(Vector3 position);

    Vector3 WorldToScreenPoint(Vector3 position);

    Ray ScreenPointToRay(Vector3 pos);
  }
}
