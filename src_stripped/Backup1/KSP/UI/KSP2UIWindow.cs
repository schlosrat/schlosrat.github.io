// Decompiled with JetBrains decompiler
// Type: KSP.UI.KSP2UIWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using DG.Tweening;
using KSP.Api.CoreTypes;
using KSP.UI.Binding;
using KSP.UserInterface;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  [PrefabName("KSP2UIWindow.prefab")]
  public class KSP2UIWindow : UIModule
  {
    [Header("BindRoots")]
    [SerializeField]
    protected ContextBindRoot bindRoot;
    [SerializeField]
    protected DataContext dataContext;
    [Header("Window Components")]
    [SerializeField]
    protected RectTransform _headerPanel;
    [SerializeField]
    protected RectTransform _bodyPanel;
    [SerializeField]
    protected RectTransform _footerPanel;
    [Tooltip("If left empty - this gameObject's transform will be set as window parent")]
    [SerializeField]
    protected RectTransform _windowParent;
    [Header("Window Size")]
    public Vector2 MinSize;
    public Vector2 MaxSize;
    public bool MaxSizeIsScreen;
    [Header("Window Borders")]
    public float TopBorder;
    public float BottomBorder;
    public float LeftBorder;
    public float RightBorder;
    public bool InvertTopBorder;
    public bool InvertBottomBorder;
    public bool InvertLeftBorder;
    public bool InvertRightBorder;
    [NonReorderable]
    [Header("AudioEvents")]
    [SerializeField]
    private AK.Wwise.Event[] OnUIWindowOpen;
    [NonReorderable]
    [SerializeField]
    private AK.Wwise.Event[] OnUIWindowClose;
    [SerializeField]
    [Header("Animation")]
    protected DOTweenAnimation OnUIWindowOpenAnim;
    [SerializeField]
    protected DOTweenAnimation OnUIWindowIdleLoopAnim;
    [SerializeField]
    protected DOTweenAnimation OnUIWindowCloseAnim;
    private Canvas _windowCanvas;
    private RectTransform _windowCanvasRect;
    public Callback<RectTransform> OnWindowResize;
    public Callback<RectTransform> OnWindowMove;

    public RectTransform WindowRectTransform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Canvas WindowCanvas
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    protected bool IsInitialized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    protected bool IsOnOpenQueuedForInit
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    protected bool IsOnFocusQueuedForInit
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnOpenUIAnimationComplete() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnCloseUIAnimationComplete() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnOpen() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnClose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnFocus() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PlayUIOpenSounds() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PlayUICloseSounds() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void FireEvent(System.Type eventType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CheckIfLocKey(ref string messageKey) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PauseAnimations(bool paused) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetFocus() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResyncWindowCanvas() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetWindowCanvasReference() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateLocalPosition(Vector2 localPosition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClampToScreen() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResizeWindowByDelta(
      Vector2 delta,
      KSP2UIWindow.ResizeHeightOptions resizeHeight,
      KSP2UIWindow.ResizeWidthOptions resizeWidth)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResizeWindowByOffset(
      Vector2 offsetMin,
      Vector2 offsetMax,
      Vector2 delta,
      KSP2UIWindow.ResizeHeightOptions resizeHeight,
      KSP2UIWindow.ResizeWidthOptions resizeWidth)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CutToScreen(
      KSP2UIWindow.ResizeHeightOptions resizeHeight,
      KSP2UIWindow.ResizeWidthOptions resizeWidth)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void CutToParentRect(
      RectTransform parentRectTransform,
      RectTransform panelRectTransform,
      bool cutTop,
      bool cutBottom,
      bool cutLeft,
      bool cutRight,
      float topEdgeOffset,
      float bottomEdgeOffset,
      float leftEdgeOffset,
      float rightEdgeOffset)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ClampToParentRect(
      RectTransform parentRectTransform,
      RectTransform panelRectTransform,
      float topEdgeOffset,
      float bottomEdgeOffset,
      float leftEdgeOffset,
      float rightEdgeOffset)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KSP2UIWindow() => throw null;

    public enum ResizeWidthOptions
    {
      None,
      Left,
      Right,
    }

    public enum ResizeHeightOptions
    {
      None,
      Top,
      Bottom,
    }
  }
}
