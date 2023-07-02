// Decompiled with JetBrains decompiler
// Type: ReorderableVerticalLayoutGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof (VerticalLayoutGroup))]
public class ReorderableVerticalLayoutGroup : MonoBehaviour
{
  [SerializeField]
  private LayoutElement _dummyTransform;
  [SerializeField]
  private RectTransform _reorderingParent;

  public RectTransform ReorderingParent
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetDummyRectDimensions(RectTransform source, float padding) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetDummySiblingIndex(int index) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetDummyVisibility(bool isVisible) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void ResetDummy() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public RectTransform GetDummyTransform() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public RectTransform GetChildFromScreenPos(Vector2 screenPos, Camera cam, out int index) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public ReorderableVerticalLayoutGroup() => throw null;
}
