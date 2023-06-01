// Decompiled with JetBrains decompiler
// Type: IConsoleStorage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.IO;

public interface IConsoleStorage
{
  void InitUserID();

  IAsyncWriter WriteAsync(string absFullPath, string data);

  IAsyncReader ReadAsync(string absFullPath);

  bool WriteSync(string absFullPath, string data);

  object ReadSync(string absFullPath);

  bool DirectoryExists(string path);

  void DirectoryDelete(string path);

  void CreateDirectory(string path);

  string[] DirectoryGetFiles(string path, string searchPattern, SearchOption searchOption);

  string[] DirectoryGetFilesName(string path, string searchPattern, SearchOption searchOption);

  bool FileExists(string path);

  void FileDelete(string path);

  void WriteAllText(string path, string contents);

  void WriteAllBytes(string path, byte[] contents);

  string ReadAllText(string filePath);

  byte[] ReadAllBytes(string filePath);

  string[] ReadAllLines(string path);

  string GetFileName(string filePath);

  string GetDirectoryName(string filePath);
}
