// Decompiled with JetBrains decompiler
// Type: RTG.IGizmoDragSession
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
