// Decompiled with JetBrains decompiler
// Type: KSP.Assets.AsyncFlowHandleData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.Assets
{
  public class AsyncFlowHandleData : KerbalMonoBehaviour
  {
    [FormerlySerializedAs("_gameObjectsWithAsyncTasksToWaitFor")]
    [SerializeField]
    private List<GameObject> _gameObjectsWithAsyncHandlesToWaitFor;
    public List<IAsyncHandleAccess> AsyncHandleAccessList;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AsyncFlowHandleData() => throw null;
  }
}
