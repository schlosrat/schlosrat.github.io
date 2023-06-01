// Decompiled with JetBrains decompiler
// Type: RTG.IGizmoDragSession
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using UnityEngine;

namespace RTG
{
  public interface IGizmoDragSession
  {
    bool IsActive { get; }

    GizmoDragChannel DragChannel { get; }

    Vector3 TotalDragOffset { get; }

    Quaternion TotalDragRotation { get; }

    Vector3 TotalDragScale { get; }

    Vector3 RelativeDragOffset { get; }

    Quaternion RelativeDragRotation { get; }

    Vector3 RelativeDragScale { get; }

    bool ContainsTargetTransform(GizmoTransform transform);

    void AddTargetTransform(GizmoTransform transform);

    void RemoveTargetTransform(GizmoTransform transform);

    bool Begin();

    bool Update();

    void End();
  }
}
