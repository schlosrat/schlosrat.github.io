// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ObjectAssemblyPartAnchorIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.UI.Binding;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.OAB
{
  public class ObjectAssemblyPartAnchorIcon : MonoBehaviour
  {
    public ContextBindRoot bindRoot;
    public Toggle anchorToggle;
    public Image anchorIcon;
    public ToggleExtendedVisualizer toggleVisualizer;
    public float distanceFrontAssembly;
    private Property<bool> isAnchorIconActive;
    private Property<bool> isAnchorIconInteractive;
    private Property<bool> isAnchor;
    private ObjectAssemblyPartTracker partTracker;
    private IObjectAssembly objectAssembly;
    private IObjectAssembly mainAssembly;
    private IObjectAssemblyPart part;
    private Bounds totalBounds;
    private AssemblyIconMode currentMode;
    private bool isOverPart;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectAssemblyPartAnchorIcon() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InitAnchorAssemblyIcon(
      IObjectAssembly assembly,
      IObjectAssembly mainAssembly,
      IObjectAssemblyPart part)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateAnchorIcon(
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
    public void SetAnchorIconTransform(Bounds bounds, Camera currentCamera, Canvas uiCanvas) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetIsHovered(bool isHover) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetIsAnchor(bool setAnchor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void IsAnchorIconActive_OnChanged() => throw null;
  }
}
