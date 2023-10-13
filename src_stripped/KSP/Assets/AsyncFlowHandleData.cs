// Decompiled with JetBrains decompiler
// Type: KSP.Assets.AsyncFlowHandleData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Game;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.Assets
{
  public class AsyncFlowHandleData : KerbalMonoBehaviour
  {
    [SerializeField]
    [FormerlySerializedAs("_gameObjectsWithAsyncTasksToWaitFor")]
    private List<GameObject> _gameObjectsWithAsyncHandlesToWaitFor;
    public List<IAsyncHandleAccess> AsyncHandleAccessList;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AsyncFlowHandleData() => throw null;
  }
}
