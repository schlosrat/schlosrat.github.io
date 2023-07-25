// Decompiled with JetBrains decompiler
// Type: KSP.Animation.CutsceneManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Animation
{
  public class CutsceneManager : MonoBehaviour
  {
    [HideInInspector]
    public bool ReadyToPlay;
    public string CutsceneLocationName;
    public Transform CutsceneCameraLocation;
    [SerializeField]
    private float startDelayInSeconds;
    protected Animator[] animators;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void PlayCutscene() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual IEnumerator PlayCutsceneWhenReady() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void PauseCutScene() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CutsceneManager() => throw null;
  }
}
