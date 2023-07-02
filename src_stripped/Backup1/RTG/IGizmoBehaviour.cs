// Decompiled with JetBrains decompiler
// Type: RTG.IGizmoBehaviour
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using UnityEngine;

namespace RTG
{
  public interface IGizmoBehaviour
  {
    Gizmo Gizmo { get; }

    bool IsEnabled { get; }

    void Init_SystemCall(GizmoBehaviorInitParams initParams);

    void SetEnabled(bool enabled);

    void OnAttached();

    void OnDetached();

    void OnEnabled();

    void OnDisabled();

    void OnGizmoEnabled();

    void OnGizmoDisabled();

    void OnGizmoHandlePicked(int handleId);

    bool OnGizmoCanBeginDrag(int handleId);

    void OnGizmoAttemptHandleDragBegin(int handleId);

    void OnGizmoHoverEnter(int handleId);

    void OnGizmoHoverExit(int handleId);

    void OnGizmoDragBegin(int handleId);

    void OnGizmoDragUpdate(int handleId);

    void OnGizmoDragEnd(int handleId);

    void OnGizmoUpdateBegin();

    void OnGizmoUpdateEnd();

    void OnGUI();

    void OnGizmoRender(Camera camera);
  }
}
