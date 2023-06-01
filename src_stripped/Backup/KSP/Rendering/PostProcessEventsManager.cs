// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.PostProcessEventsManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.Messages;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace KSP.Rendering
{
  public class PostProcessEventsManager : KerbalMonoBehaviour
  {
    private Camera sourceCamera;
    private PostProcessVolume postProcessVolume;
    private TutorialOverlay tutorialOverlay;
    private SubscriptionHandle _handleTutorialStarted;
    private SubscriptionHandle _handleTutorialEnded;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RegisterEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemoveEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTutorialStartedLoaded(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTutorialEndedLoaded(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupTutorialOverlay() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemoveTutorialOverlay() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PostProcessEventsManager() => throw null;
  }
}
