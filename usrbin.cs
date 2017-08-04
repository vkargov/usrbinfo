using System;

class Usrbin
{
    static void Main (string[] args) {
	string[] dirs;
	
	if (args.Length == 0)
	    dirs = new [] {"/bin", "/usr/bin", "/usr/local/bin"};
	else
	    dirs = args;

	var aproposProcess = new System.Diagnostics.Process();
	aproposProcess.StartInfo.FileName = "apropos";
	aproposProcess.StartInfo.Arguments = ".";
	aproposProcess.StartInfo.RedirectStandardOutput = true;
	aproposProcess.StartInfo.UseShellExecute = false;
	aproposProcess.Start();
	var apropos = p.StandardOutput.ReadToEnd();
	p.WaitForExit();    
	
	foreach (var dir in dirs) {
	    Console.WriteLine ($"# {dir}");
	    Console.WriteLine ("<table><tr><th>Command</th><th>-h</th><th>man</th><th>notes</th></tr>");
	    
	    foreach (var path in System.IO.Directory.GetFiles (dir)) {
		var command = System.IO.Path.GetFileName (path);

		    
		Console.WriteLine ($"<tr><td>{command}</td><td></td><td></td><td></td>");
	    }

	    Console.WriteLine ("</table>");
	}
    }
}
