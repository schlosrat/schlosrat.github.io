// Decompiled with JetBrains decompiler
// Type: RTG.GizmoOffsetDragAxisModifyHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using UnityEngine;

namespace RTG
{
  public delegate Vector3 GizmoOffsetDragAxisModifyHandler(
    Gizmo gizmo,
    Vector3 relativeDragAxis,
    int handleId);
}
