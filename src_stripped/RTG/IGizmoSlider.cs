// Decompiled with JetBrains decompiler
// Type: RTG.IGizmoSlider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using UnityEngine;

namespace RTG
{
  public interface IGizmoSlider
  {
    Gizmo Gizmo { get; }

    int HandleId { get; }

    Priority HoverPriority3D { get; }

    Priority HoverPriority2D { get; }

    Priority GenericHoverPriority { get; }

    void SetHoverable(bool isHoverable);

    void SetVisible(bool isVisible);

    void SetSnapEnabled(bool isEnabled);

    void Render(Camera camera);
  }
}
