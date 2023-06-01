// Decompiled with JetBrains decompiler
// Type: KSP.Navigation.SelectableElementInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.Navigation
{
  public struct SelectableElementInfo
  {
    public static SelectableElementInfo Null;
    public NavElementGroup Group;
    private Selectable _selectable;
    private RectTransform _rectTransform;
    private Vector3[] _worldCorners;
    private Vector3 _centerOnScreen;

    public Camera Camera
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Selectable Selectable
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool IsUI
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3[] WorldCorners
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 CenterOnScreen
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float WidthOnScreen
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float HeightOnScreen
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    static SelectableElementInfo() => throw null;
  }
}
