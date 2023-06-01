// Decompiled with JetBrains decompiler
// Type: KSP.Sim.IKSPCamera
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
