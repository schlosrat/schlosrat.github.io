// Decompiled with JetBrains decompiler
// Type: KSP.Networking.OnlineServices.Social.FriendsManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
    public void SetFriendListDirty() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetFriendsList() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddFriend(string friendID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveFriend(string friendID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetFriendsList(string body, string error) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddFriendCallback(string body, string error) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemoveFriendCallback(string body, string error) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Dictionary<string, string> GetTitleSocialHeaders() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FriendsManager() => throw null;
  }
}
