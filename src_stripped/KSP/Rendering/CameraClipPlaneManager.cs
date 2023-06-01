// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.CameraClipPlaneManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;

namespace KSP.Rendering
{
  public class CameraClipPlaneManager : KerbalMonoBehaviour
  {
    private const float CAM_FAR_CLIP_PLANE_DEFAULT = 200000f;
    private const float FAR_CLIP_PLANE_ORBIT = 100000f;
    private GraphicsManager _graphicsManger;
    private bool _initialized;
    private bool _enabled;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(GraphicsManager gm) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Enable(bool enabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateClipPlane() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraClipPlaneManager() => throw null;
  }
}
