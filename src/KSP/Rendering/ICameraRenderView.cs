// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.ICameraRenderView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
