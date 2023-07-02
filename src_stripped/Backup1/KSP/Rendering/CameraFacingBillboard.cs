// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.CameraFacingBillboard
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Messages;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering
{
  [DisallowMultipleComponent]
  public class CameraFacingBillboard : KerbalMonoBehaviour
  {
    [SerializeField]
    private Camera _targetCamera;
    private ActiveCameraGroup _targetCameraGroup;
    private SubscriptionHandle _handleCameraChanged;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCameraChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetActiveCameraGroup(ActiveCameraGroup activeCameraGroup) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraFacingBillboard() => throw null;
  }
}
