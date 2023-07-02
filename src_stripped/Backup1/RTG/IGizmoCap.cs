// Decompiled with JetBrains decompiler
// Type: RTG.IGizmoCap
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using UnityEngine;

namespace RTG
{
  public interface IGizmoCap
  {
    Gizmo Gizmo { get; }

    int HandleId { get; }

    Priority HoverPriority3D { get; }

    Priority HoverPriority2D { get; }

    Priority GenericHoverPriority { get; }

    void SetHoverable(bool isHoverable);

    void SetVisible(bool isVisible);

    void Render(Camera camera);
  }
}
