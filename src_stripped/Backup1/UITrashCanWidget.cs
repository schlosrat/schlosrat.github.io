// Decompiled with JetBrains decompiler
// Type: UITrashCanWidget
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using DG.Tweening;
using KSP.OAB;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class UITrashCanWidget : MonoBehaviour
{
  public Image bgImage;
  public Image[] trashIcons;
  public Image[] borderImages;
  public List<Image> pickupIcons;
  public Color iconActiveColor;
  public Color iconUseColor;
  public Color bgActiveColor;
  public Color bgUseColor;
  public string trashBinDOTweenID;
  private Color bgDefaultColor;
  private Color defaultIconColor;
  private IObjectAssemblyPart partGrabbed;
  private List<DOTweenAnimation> doTweenAnimatorList;
  private Color softFlash;
  private ObjectAssemblyBuilderEvents buildEvents;
  private ObjectAssemblyUIEvents uiEvents;
  private float colorLerpT;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private Color ColorLerp(Color c1, Color c2, float value) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetEvents(ObjectAssemblyUIEvents ui, ObjectAssemblyBuilderEvents builder) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDestroy() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnUpdate() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateTrashcanWidgetColor() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void PlayTrashcanAnimation(bool playForward) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetBorderColor() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetBorderColor(Color color) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetIconsColor(Color color) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetIconsColor() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnPartGrabbed(IObjectAssemblyPart part) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnPartDropped(IObjectAssemblyPart part) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnEnter() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnExit() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnPartDeleted(IObjectAssemblyPart part) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public UITrashCanWidget() => throw null;
}
