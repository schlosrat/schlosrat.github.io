// Decompiled with JetBrains decompiler
// Type: EdyCommonTools.AttachToTarget
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
