// Decompiled with JetBrains decompiler
// Type: KSP.Utilities.PixelPerfectUIElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Utilities
{
  [RequireComponent(typeof (RectTransform))]
  [ExecuteInEditMode]
  public class PixelPerfectUIElement : KerbalMonoBehaviour
  {
    [SerializeField]
    private int _pixelsPerUnit;
    [SerializeField]
    [Min(1f)]
    private int _scaleFactor;
    private Vector3 _cachedPosition;
    private Vector2 _cachedPivot;
    private RectTransform _rectTransform;

    private int _trueScaleFactor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PixelPerfectUIElement() => throw null;
  }
}
