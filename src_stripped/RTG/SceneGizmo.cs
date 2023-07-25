// Decompiled with JetBrains decompiler
// Type: RTG.SceneGizmo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  [Serializable]
  public class SceneGizmo : GizmoBehaviour, ISceneGizmo
  {
    private SceneGizmoCamPrjSwitchLabel _camPrjSwitchLabel;
    private SceneGizmoMidCap _midAxisHandle;
    private SceneGizmoAxisCap[] _axesHandles;
    private List<SceneGizmoCap> _renderSortedHandles;
    private RTSceneGizmoCamera _sceneGizmoCamera;
    [SerializeField]
    private SceneGizmoLookAndFeel _lookAndFeel;
    [SerializeField]
    private SceneGizmoLookAndFeel _sharedLookAndFeel;

    public RTSceneGizmoCamera SceneGizmoCamera
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Gizmo OwnerGizmo
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Camera SceneCamera
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public SceneGizmoLookAndFeel LookAndFeel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public SceneGizmoLookAndFeel SharedLookAndFeel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnAttached() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnGUI() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnGizmoRender(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SceneGizmo() => throw null;
  }
}
