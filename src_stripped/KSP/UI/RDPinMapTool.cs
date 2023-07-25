// Decompiled with JetBrains decompiler
// Type: KSP.UI.RDPinMapTool
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using DG.Tweening;
using KSP.Game;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace KSP.UI
{
  public class RDPinMapTool : KerbalMonoBehaviour, IPointerClickHandler, IEventSystemHandler
  {
    [SerializeField]
    private Image _cameraBox;
    private Camera _rdCamera;
    private RDCameraManager _rdCameraManager;
    private List<DOTweenAnimation> _tweenAnimations;
    private bool _isVisible;
    private float _cameraBoxScale;
    private RectTransform _rectTransform;
    private RectTransform _cameraBoxRect;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HandlePinMapVisibility() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerClick(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleAnimation(string triggerType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RDPinMapTool() => throw null;
  }
}
