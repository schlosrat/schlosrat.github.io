// Decompiled with JetBrains decompiler
// Type: KSP.Sim.IInternalCamera_TOREPLACE
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using UnityEngine;

namespace KSP.Sim
{
  public interface IInternalCamera_TOREPLACE : IKSPCamera
  {
    void SetTransform(Transform cameraTransform, bool resetCamera);

    void EnableCamera();

    void DisableCamera();

    void ResetCamera();

    void Destroy();
  }
}
