// Decompiled with JetBrains decompiler
// Type: RTG.IGizmoCap3DController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using UnityEngine;

namespace RTG
{
  public interface IGizmoCap3DController
  {
    void UpdateHandles();

    void UpdateTransforms(float zoomFactor);

    void CapSlider3D(Vector3 sliderDirection, Vector3 sliderEndPt, float zoomFactor);

    void CapSlider3DInvert(Vector3 sliderDirection, Vector3 sliderEndPt, float zoomFactor);

    float GetSliderAlignedRealLength(float zoomFactor);
  }
}
