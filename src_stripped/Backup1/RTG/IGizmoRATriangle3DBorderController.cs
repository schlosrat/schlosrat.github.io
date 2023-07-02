// Decompiled with JetBrains decompiler
// Type: RTG.IGizmoRATriangle3DBorderController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

namespace RTG
{
  public interface IGizmoRATriangle3DBorderController
  {
    void UpdateHandles();

    void UpdateEpsilons(float zoomFactor);

    void UpdateTransforms(float zoomFactor);
  }
}
