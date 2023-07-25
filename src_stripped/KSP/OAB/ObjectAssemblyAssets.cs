// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ObjectAssemblyAssets
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  [Serializable]
  public class ObjectAssemblyAssets
  {
    [SerializeField]
    private GameObject StackNodePrefab;
    [SerializeField]
    private GameObject SurfaceNodePrefab;
    [SerializeField]
    private GameObject BlueprintSmallPrefab;
    [SerializeField]
    private GameObject BlueprintLargePrefab;
    [SerializeField]
    private GameObject strutPrefab;
    [SerializeField]
    private GameObject dottedLinePrefab;
    [HideInInspector]
    public Collider cameraPositionLimitCollider;
    [SerializeField]
    private GameObject hudCanvas;
    [SerializeField]
    private Sprite anchorActiveSprite;
    [SerializeField]
    private Sprite anchorInactiveSprite;
    [SerializeField]
    private Sprite launchActiveSprite;
    [SerializeField]
    private Sprite launchInactiveSprite;
    [SerializeField]
    private Sprite selectLaunchCursor;
    [SerializeField]
    private Sprite selectAnchorCursor;
    [SerializeField]
    private Sprite defaultCursor;
    [SerializeField]
    private Sprite grabCursor;
    [SerializeField]
    private Sprite handCursor;
    [SerializeField]
    private Sprite pointHandCursor;
    [SerializeField]
    private Sprite selectRotateCursor;
    [SerializeField]
    private Sprite selectTranslateCursor;
    [SerializeField]
    private Sprite selectColorCursor;
    [SerializeField]
    private ManipulationWidget manipulationWidget;
    [SerializeField]
    private ObjectAssemblyLaunchIcon oabAssemblyLaunchIcon;
    [SerializeField]
    private ObjectAssemblyPartAnchorIcon oabAssemblyAnchorIcon;
    [SerializeField]
    private GameObject oabAssemblyThumbnailCamera;
    [SerializeField]
    [Header("Debug")]
    private TextAsset debugPlaneSave;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ManipulationWidget GetManipulationWidgetReference() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectAssemblyLaunchIcon GetObjectAssemblyLaunchIconPrefab() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectAssemblyPartAnchorIcon GetObjectAssemblyPartAnchorPrefab() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameObject CreateStackNodePrefab() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameObject CreateSurfaceNodePrefab() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameObject CreateBlueprintSmallPrefab() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameObject CreateBlueprintLargePrefab() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameObject CreateStrutPrefab() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameObject CreateDottedLinePrefab() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Collider GetCameraBoundsCollider() => throw null;

    public GameObject HudCanvas
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Sprite SelectLaunchCursor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Sprite SelectAnchorCursor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Sprite DefaultCursor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Sprite GrabCursor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Sprite HandCursor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Sprite PointHandCursor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Sprite SelectRotateCursor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Sprite SelectTranslateCursor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Sprite SelectColorCursor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public TextAsset DebugPlaneSave
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GameObject OABAssemblyThumbnailCamera
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectAssemblyAssets() => throw null;
  }
}
