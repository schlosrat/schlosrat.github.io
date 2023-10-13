// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ObjectAssemblyPartAnchorIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
    public Image anchorIconSmall;
    public ToggleExtendedVisualizer toggleVisualizer;
    public float distanceFrontAssembly;
    private Property<bool> _isAnchorIconActive;
    private Property<bool> _isAnchorIconInteractive;
    private Property<bool> _isAnchor;
    private Property<bool> _isTempAnchor;
    private IObjectAssemblyPart _part;
    private AssemblyIconMode _currentMode;
    private bool _isOverPart;
    private bool _isContextInitialized;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InitAnchorAssemblyIcon(IObjectAssemblyPart part) => throw null;

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
    public ObjectAssemblyPartAnchorIcon() => throw null;
  }
}
