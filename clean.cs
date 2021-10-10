using System;
using System.IO;
using System.Collections.Generic;

List<string> folders = new List<string> { "bin", "obj", ".vscode" };

void Recursive(string path)
{
	string[] directories = Directory.GetDirectories(path);
	foreach (string d in directories)
	{
		FileAttributes attributes = File.GetAttributes(d);
		string name = Path.GetFileName(d);

		if ((attributes & FileAttributes.Directory) == FileAttributes.Directory && folders.Contains(name))
		{
			Directory.Delete(d, true);
			continue;
		}

		string[] files = Directory.GetFiles(d);
		foreach (string file in files)
		{
			if (file.Contains(".csproj"))
			{
				File.Delete(file);
			}
			break;
		}
		Recursive(d);
	}
}

Recursive(Directory.GetCurrentDirectory());
