// string path = "C:/Users/User-AK/Pictures/iCloud Photos";
// DirectoryInfo di = new DirectoryInfo(path);
// System.Console.WriteLine(di.CreationTime);
// FileInfo [] fi = di.GetFiles();

// for (int i = 0; i < fi.Length; i++)
// {
//   System.Console.WriteLine(fi[i].Name);
// }

void CatalogInfo (string path, string indent = "") {
    DirectoryInfo catalog = new DirectoryInfo(path);

    DirectoryInfo [] catalogs = catalog.GetDirectories();

    for (int i = 0; i < catalogs.Length; i++)
    {
        System.Console.WriteLine($"{indent} {catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + " ");
    }

    FileInfo [] files = catalog.GetFiles();

    for (int i = 0; i < files.Length; i++)
    {
        System.Console.WriteLine($"{indent} {files[i].Name}");
    }
}

string path = @"C:/Users/User-AK/Pictures/iCloud Photos";
CatalogInfo(path);