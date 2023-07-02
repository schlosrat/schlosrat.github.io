// Decompiled with JetBrains decompiler
// Type: IConsoleStorage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
