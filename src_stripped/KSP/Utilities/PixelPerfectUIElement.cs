// Decompiled with JetBrains decompiler
// Type: KSP.Utilities.PixelPerfectUIElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
    [Min(1f)]
    [SerializeField]
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
