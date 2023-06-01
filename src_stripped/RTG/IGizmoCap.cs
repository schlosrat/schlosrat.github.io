// Decompiled with JetBrains decompiler
// Type: RTG.IGizmoCap
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
