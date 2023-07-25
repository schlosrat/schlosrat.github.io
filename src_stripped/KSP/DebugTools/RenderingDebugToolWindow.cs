// Decompiled with JetBrains decompiler
// Type: KSP.DebugTools.RenderingDebugToolWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.DebugTools
{
  public class RenderingDebugToolWindow : KerbalMonoBehaviour
  {
    [SerializeField]
    private Toggle _physicsCameraToggle;
    [SerializeField]
    private Toggle _scaledCameraToggle;
    [SerializeField]
    private Toggle _flareCameraToggle;
    private static readonly string PREFAB_KEY;
    private static RenderingDebugToolWindow s_instance;

    private Camera PhysicsCamera
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private bool PhysicsCameraEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private Camera ScaledCamera
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private bool ScaledCameraEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private Camera FlareCamera
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private bool FlareCameraEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RenderPhysicsCamera(bool isRendering) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RenderScaledCamera(bool isRendering) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RenderFlareCamera(bool isRendering) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HideWindow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ToggleWindow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void CreateWindow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void DestroyWindow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RenderingDebugToolWindow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static RenderingDebugToolWindow() => throw null;
  }
}
