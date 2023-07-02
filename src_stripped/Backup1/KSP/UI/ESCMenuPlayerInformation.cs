// Decompiled with JetBrains decompiler
// Type: KSP.UI.ESCMenuPlayerInformation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Game;
using KSP.UI.Binding;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  public class ESCMenuPlayerInformation : KerbalMonoBehaviour
  {
    [SerializeField]
    private ContextBindRoot _playerInformationBindRoot;
    [SerializeField]
    private ContextBindRoot _universalTimeBindRoot;
    private DataContext _globalContextData;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RefreshPlayerInformation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ESCMenuPlayerInformation() => throw null;
  }
}
