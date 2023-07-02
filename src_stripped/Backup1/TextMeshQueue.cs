// Decompiled with JetBrains decompiler
// Type: TextMeshQueue
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class TextMeshQueue : MonoBehaviour
{
  [SerializeField]
  protected TextMeshProUGUI prefab;
  [SerializeField]
  protected RectTransform parent;
  [SerializeField]
  protected int characterLimit;
  private List<TextMeshQueue.TextMeshQueueItem> items;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void AddLine(string line) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void RemoveLine() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void RemoveAllLines() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public TextMeshQueue() => throw null;

  private class TextMeshQueueItem
  {
    private TextMeshQueue textMeshQueue;
    private TextMeshProUGUI textObject;
    private List<string> lines;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TextMeshQueueItem(TextMeshQueue textMeshQueue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool AddLine(string line) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool RemoveLine() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool DestroyIfEmpty() => throw null;
  }
}
