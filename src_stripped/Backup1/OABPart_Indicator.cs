// Decompiled with JetBrains decompiler
// Type: OABPart_Indicator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.OAB;
using KSP.UI;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class OABPart_Indicator : Indicator
{
  private AssemblyPartsPicker OABpartsPicker;
  private AssemblyPartsButton focusedPartButton;
  private ObjectAssemblyCategoryButton focusedCategoryButton;
  private RectTransform targetRectTransform;
  private IObjectAssemblyAvailablePart partToFocus;

  private bool isOABValid
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override void Show(IndicatorData indicatorData, Action<Indicator> onHide) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override void Hide() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected void LookForPartIcontoHighlight() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected void OnVisiblePartsRepopulated() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateTargetGameObject() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override void OnUpdate() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public OABPart_Indicator() => throw null;
}
