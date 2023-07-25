// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.ICameraRenderView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;

namespace KSP.Rendering
{
  public interface ICameraRenderView
  {
    ICameraRenderStack GetCameraRenderStack(RenderSpaceType type);

    void MatchShot(ICameraShot shot);

    void EnableRendering();

    void DisableRendering();

    void RegisterCameraRenderStack(RenderSpaceType type, ICameraRenderStack stack, int order);

    bool ClearCameraRenderStack(RenderSpaceType type);

    void Destroy();
  }
}
