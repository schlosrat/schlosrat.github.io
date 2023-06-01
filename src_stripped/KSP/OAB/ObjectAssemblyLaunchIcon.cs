// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ObjectAssemblyLaunchIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Game;
using KSP.UI.Binding;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  public class ObjectAssemblyLaunchIcon : KerbalMonoBehaviour
  {
    public ContextBindRoot bindRoot;
    public GameObject mainAssemblyVisual;
    public GameObject mainAssemblyLine;
    public GameObject mainAssemblyLineOnHover;
    public float heightAboveAssembly;
    public float lineLengthHeight;
    private Property<bool> isMainAssemblyIconActive;
    private Property<bool> isMainAssembly;
    private ObjectAssemblyPartTracker partTracker;
    private IObjectAssembly objectAssembly;
    private Bounds totalBounds;
    private AssemblyIconMode currentMode;
    private bool isOverAssembly;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InitMainAssemblyIcon(
      ObjectAssemblyPartTracker partTracker,
      IObjectAssembly objectAssembly)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateMainAssemblyIcon(
      IObjectAssemblyPart partGrabbed,
      bool isLaunchAssembly,
      AssemblyIconMode mode)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CheckMouseOverLaunchAssemblyBounds(
      Camera curCamera,
      Vector2 mousePos,
      Bounds totalBounds)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetBounds(Bounds assemblyBounds) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMainAssemblyIconTransform(Bounds bounds, Camera currentCamera, Canvas uiCanvas) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void VisuallySetAsMainAssembly(bool setAsMain) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnSetToMainAssembly() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectAssemblyLaunchIcon() => throw null;
  }
}
