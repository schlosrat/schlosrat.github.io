// Decompiled with JetBrains decompiler
// Type: RTG.IGizmoCap2DController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using UnityEngine;

namespace RTG
{
  public interface IGizmoCap2DController
  {
    void UpdateHandles();

    void UpdateTransforms();

    void CapSlider2D(Vector2 sliderDirection, Vector2 sliderEndPt);

    void CapSlider2DInvert(Vector2 sliderDirection, Vector2 sliderEndPt);

    float GetSliderAlignedRealLength();
  }
}
