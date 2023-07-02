// Decompiled with JetBrains decompiler
// Type: KSP.Assets.DestructionNotification
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Assets
{
  public class DestructionNotification : MonoBehaviour
  {
    private Action<GameObject> _destructionCallback;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDestructionCallback(Action<GameObject> callback) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DestructionNotification() => throw null;
  }
}
