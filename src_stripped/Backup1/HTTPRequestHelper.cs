// Decompiled with JetBrains decompiler
// Type: HTTPRequestHelper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;

public class HTTPRequestHelper : KerbalMonoBehaviour
{
  private static HTTPRequestHelper instance;

  public static HTTPRequestHelper Instance
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void SetupInstance(GameObject gameObject) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public HTTPRequestHelper() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  ~HTTPRequestHelper() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Coroutine StartCoroutineWithTryCatch(IEnumerator routine) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void GetJSONPostRequest(
    string uri,
    HTTPRequestHelper.RequestCallback callback,
    Dictionary<string, string> headers = null,
    string jsonPayload = null)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void GetJSONPutRequest(
    string uri,
    HTTPRequestHelper.RequestCallback callback,
    Dictionary<string, string> headers = null,
    byte[] fileData = null)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void StartGetRequest(
    string uri,
    HTTPRequestHelper.RequestCallback callback,
    Dictionary<string, string> headers = null)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void StartWWWFormPostRequest(
    string uri,
    HTTPRequestHelper.RequestCallback callback,
    Dictionary<string, string> headers = null,
    Dictionary<string, string> form = null)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void DownloadFileRequest(string uri, string fileName, Action<bool> callback) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void WaitUntilRequestResolved(UnityWebRequest WWW) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public IEnumerator JSONPostRequest(
    string url,
    HTTPRequestHelper.RequestCallback callback,
    Dictionary<string, string> headers = null,
    string jsonPayload = null)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private IEnumerator JSONPutRequest(
    string url,
    HTTPRequestHelper.RequestCallback callback,
    Dictionary<string, string> headers = null,
    byte[] data = null)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private IEnumerator GetRequest(
    string uri,
    HTTPRequestHelper.RequestCallback callback,
    Dictionary<string, string> headers)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public IEnumerator WWWFormPostRequest(
    string url,
    HTTPRequestHelper.RequestCallback callback,
    Dictionary<string, string> headers = null,
    Dictionary<string, string> payload = null)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private IEnumerator DownloadFile(string url, string fileName, Action<bool> resultCallback) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static IEnumerator WaitUntilResolved(UnityWebRequest request) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static HTTPRequestHelper() => throw null;

  public delegate void RequestCallback(string error, string body);
}
