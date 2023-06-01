// Decompiled with JetBrains decompiler
// Type: EdyCommonTools.AttachToTarget
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace EdyCommonTools
{
  public class AttachToTarget : MonoBehaviour
  {
    [FormerlySerializedAs("target")]
    public Transform source;
    public AttachToTarget.CopyMode copyPosition;
    public AttachToTarget.CopyMode copyRotation;
    public AttachToTarget.UpdateMode updateMode;
    private Transform m_transform;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FixedUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyPose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AttachToTarget() => throw null;

    public enum CopyMode
    {
      Disabled,
      Local,
      World,
    }

    public enum UpdateMode
    {
      Update,
      LateUpdate,
      FixedUpdate,
    }
  }
}
