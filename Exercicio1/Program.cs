using System;
using System.IO;

FileInfo arquivo = null;

try
{
    System.Console.WriteLine("Digite o nopme de um arquivo: ");
    string nomeArquivo = Console.ReadLine();
    arquivo = new FileInfo(nomeArquivo);
    using (StreamWriter gravadorFluxo = File.AppendText(nomeArquivo))
    {
        gravadorFluxo.WriteLine("Hello Againnn");
    }
}
catch (Exception ex)
{
    System.Console.WriteLine(ex.Message);
}
finally
{
    arquivo = null;
}
