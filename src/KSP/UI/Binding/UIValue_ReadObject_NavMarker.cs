// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_ReadObject_NavMarker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI.Binding
{
  public class UIValue_ReadObject_NavMarker : UIValueBinder<Vector3>
  {
    [SerializeField]
    private Transform markerPivot;
    [SerializeField]
    private Transform markerIcon;
    [SerializeField]
    private Transform arrowIcon;
    [SerializeField]
    private float arrowThreshold;
    [SerializeField]
    private float backTransparency;
    [SerializeField]
    private Sprite backSprite;
    [SerializeField]
    private float frontTransparency;
    [SerializeField]
    private Sprite frontSprite;
    [SerializeField]
    private float minScale;
    [SerializeField]
    private float maxScale;
    [SerializeField]
    private float transparencyThreshold;
    [SerializeField]
    private float markerOffsetDistance;
    [SerializeField]
    private float arrowOffset;
    private Image _imageArrowIcon;
    private Image _imageMarkerIcon;
    private Vector3 _markerPosition;
    private bool _isInitialized;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateMarker(Vector3 markerVector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeComponents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Color GetMarkerAlpha(Vector3 markerVector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Sprite GetMarkerSprite(Vector3 markerVector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3 GetMarkerScale(Vector3 markerVector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3 GetArrowPosition(Vector3 markerVector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3 GetZFlattenedMarkerPosition(Vector3 markerVector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3 GetMarkerPosition(Vector3 markerVector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateArrow(Vector3 markerVector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_ReadObject_NavMarker() => throw null;
  }
}
