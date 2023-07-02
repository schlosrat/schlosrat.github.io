// Decompiled with JetBrains decompiler
// Type: KSP.Networking.OnlineServices.Social.FriendsManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Networking.OnlineServices.Social.Models;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Networking.OnlineServices.Social
{
  public class FriendsManager : MonoBehaviour
  {
    private static FriendsManager instance;
    public List<Friend> FriendList;
    public bool FriendsListLoaded;
    public string FriendAddId;

    public GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static FriendsManager Instance
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Uninit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Dictionary<string, string> GetTitleSocialHeaders() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FriendsManager() => throw null;
  }
}
