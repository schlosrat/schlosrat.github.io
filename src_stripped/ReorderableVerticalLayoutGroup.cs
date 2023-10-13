// Decompiled with JetBrains decompiler
// Type: ReorderableVerticalLayoutGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
