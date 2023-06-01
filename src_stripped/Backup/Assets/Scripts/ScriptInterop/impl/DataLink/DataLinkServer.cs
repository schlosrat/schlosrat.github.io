// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.ScriptInterop.impl.DataLink.DataLinkServer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using DataLink.Shared.Net;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;

namespace Assets.Scripts.ScriptInterop.impl.DataLink
{
  public class DataLinkServer
  {
    private static Socket serverSocket;
    private static byte[] resultBuffer;
    private static List<ClientData> MsgQueue;
    private static Socket clientConnectedSocket;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DataLinkServer() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ClientData GetScriptInfo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void StartListening(IPEndPoint remoteEP) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ClientConnectListenAndRecevie() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SendBackToClient(string data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static DataLinkServer() => throw null;
  }
}
