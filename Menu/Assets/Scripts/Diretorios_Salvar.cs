using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class Diretorios_Salvar {

	public static string arquivoUsuarios;
	public static string arquivoOpcoes;
	public static string arquivoMododeJogo;
    public static string arquivoDados;
    public static string arquivoCalibracao;
    public static string PastadeDados;
	public static string PastadeConfiguracoes;
	public static string PastadeModosdeJogo;
    public static string PastadeCalibragemUsuarios;

	public static string arquivoNomeUsuario;

	public static void CriarDiretorios()
	{
		PastadeDados = Application.persistentDataPath + "\\Dados";
		PastadeConfiguracoes = Application.persistentDataPath + "\\Configuracoes";
		PastadeModosdeJogo = Application.persistentDataPath + "\\ModosdeJogo";

		arquivoUsuarios = PastadeConfiguracoes + "\\Usuarios.txt";
		arquivoOpcoes = PastadeConfiguracoes + "\\Opcoes.txt";
		arquivoMododeJogo = PastadeModosdeJogo + "\\NomedosJogos.txt";
		arquivoNomeUsuario = PastadeConfiguracoes +"\\NomeUsuario.txt";
		// Criando pastas iniciais
		if (!Directory.Exists(PastadeDados))
			Directory.CreateDirectory(PastadeDados);

		if (!Directory.Exists(PastadeConfiguracoes))
			Directory.CreateDirectory(PastadeConfiguracoes);

		if(!Directory.Exists(PastadeModosdeJogo))
			Directory.CreateDirectory(PastadeModosdeJogo);

    }

	public static void SalvarDadosTeste(string[] dados, string local)
	{
		if(File.Exists(local))
			File.Delete (local);
		
		using (StreamWriter sw = File.AppendText(local))
		{
			foreach (string line in dados)
			{
				sw.WriteLine(line);
			}
		}
	}

	public static void AdicionarDados(string local, string dadoAdicionado)
	{
		using (StreamWriter sw = File.AppendText (local)) {
			sw.WriteLine (dadoAdicionado);

		}
	}
	public static void ExcluirDados(string[] dados, string local, string dadoExcluido)
	{
		File.Delete (local);
		using (StreamWriter sw = File.AppendText (local)) {
			foreach (string linha in dados) {
				if (linha == dadoExcluido)
					continue;
				else
					sw.WriteLine (linha);
			}
		}
	}

    public static void CriarArquivoDadosUsuario()
    {
        arquivoDados = Diretorios_Salvar.PastadeDados + "\\" + MenuJogar.nomeJogador.Split(',')[0] +  "_" + System.DateTime.Now.ToString("dd-MM-yyyy_HH.mm.ss") + "_" + MovimentacaoDoUsuario.repeticao + ".txt";
        if (!File.Exists(arquivoDados))
        {
            File.WriteAllText(arquivoDados, "");
            using (StreamWriter sw = File.CreateText(arquivoDados))
                sw.WriteLine("Numero da repeticao;"+
					"Velocidade;"+
					"Frame;"+
					"Tolerancia;"+

					"PosicaodaCabecaUsuarioX;" +
					"PosicaodaCabecaUsuarioY;" +
					"PosicaodaCabecaUsuarioZ;" +
					"PosicaoNucaUsuarioX;" +
					"PosicaoNucaUsuarioY;" +
					"PosicaoNucaUsuarioZ;" +
					"PosicaoBasePescocoUsuarioX;" +
					"PosicaoBasePescocoUsuarioY;" +
					"PosicaoBasePescocoUsuarioZ;" +
					"PosicaoTroncoUsuarioX;" +
					"PosicaoTroncoUsuarioY;" +
					"PosicaoTroncoUsuarioZ;" +
					"PosicaoCotoveloDir.UsuarioX;" +
					"PosicaoCotoveloDir.UsuarioY;" +
					"PosicaoCotoveloDir.UsuarioZ;" +
					"PosicaoCotoveloEsq.UsuarioX;" +
					"PosicaoCotoveloEsq.UsuarioY;" +
					"PosicaoCotoveloEsq.UsuarioZ;" +
					"PosicaoOmbroDirUsuarioX;" +
					"PosicaoOmbroDirUsuarioY;" +
					"PosicaoOmbroDirUsuarioZ;" +
					"PosicaoOmbroEsq.UsuarioX;" +
					"PosicaoOmbroEsq.UsuarioY;" +
					"PosicaoOmbroEsq.UsuarioZ;" +
					"PosicaoPulsoDir.UsuarioX;" +
					"PosicaoPulsoDir.UsuarioY;" +
					"PosicaoPulsoDir.UsuarioZ;" +
					"PosicaoPulsoEsq.UsuarioX;" +
					"PosicaoPulsoEsq.UsuarioY;" +
					"PosicaoPulsoEsq.UsuarioZ;" +
					"PosicaoMaoDireitaUsuarioX;" +
					"PosicaoMaoDireitaUsuarioY;" +
					"PosicaoMaoDireitaUsuarioZ;" +
					"PosicaoMaoEsquerdaUsuarioX;" +
					"PosicaoMaoEsquerdaUsuarioY;" +
					"PosicaoMaoEsquerdaUsuarioZ;" +
					"PosicaoQuadrilUsuarioX;" +
					"PosicaoQuadrilUsuarioY;" +
					"PosicaoQuadrilUsuarioZ;" +
					"PosicaoQuadrilDireitoUsuarioX;" +
					"PosicaoQuadrilDireitoUsuarioY;" +
					"PosicaoQuadrilDireitoUsuarioZ;" +
					"PosicaoQuadrilEsquerdoUsuarioX;" +
					"PosicaoQuadrilEsquerdoUsuarioY;" +
					"PosicaoQuadrilEsquerdoUsuarioZ;" +
					"PosicaoJoelhoDireitoUsuarioX;" +
					"PosicaoJoelhoDireitoUsuarioY;" +
					"PosicaoJoelhoDireitoUsuarioZ;" +
					"PosicaoJoelhoEsquerdoUsuarioX;" +
					"PosicaoJoelhoEsquerdoUsuarioY;" +
					"PosicaoJoelhoEsquerdoUsuarioZ;" +
					"PosicaoPeDireitoUsuarioX;" +
					"PosicaoPeDireitoUsuarioY;" +
					"PosicaoPeDireitoUsuarioZ;" +
					"PosicaoPeEsquerdoUsuarioX;" +
					"PosicaoPeEsquerdoUsuarioY;" +
					"PosicaoPeEsquerdoUsuarioZ;" +

					"AnguloDaCinturaUsuarioX;" +
					"AnguloDaCinturaUsuarioY;" +
					"AnguloDaCinturaUsuarioZ;" +
					"AnguloDoQuadrilDireitoUsuarioX;" +
					"AnguloDoQuadrilDireitoUsuarioY;" +
					"AnguloDoQuadrilDireitoUsuarioZ;" +
					"AnguloDaPernaDireitaUsuarioX;" +
					"AnguloDaPernaDireitaUsuarioY;" +
					"AnguloDaPernaDireitaUsuarioZ;" +
					"AnguloDoCalcanharDireitoUsuarioX;" +
					"AnguloDoCalcanharDireitoUsuarioY;" +
					"AnguloDoCalcanharDireitoUsuarioZ;" +
					"AnguloDoPeDireitoUsuarioX;" +
					"AnguloDoPeDireitoUsuarioY;" +
					"AnguloDoPeDireitoUsuarioZ;" +
					"AnguloDoQuadrilEsquerdoUsuarioX;" +
					"AnguloDoQuadrilEsquerdoUsuarioY;" +
					"AnguloDoQuadrilEsquerdoUsuarioZ;" +
					"AnguloDaPernaEsquerdaUsuarioX;" +
					"AnguloDaPernaEsquerdaUsuarioY;" +
					"AnguloDaPernaEsquerdaUsuarioZ;" +
					"AnguloDoCalcanharEsquerdoUsuarioX;" +
					"AnguloDoCalcanharEsquerdoUsuarioY;" +
					"AnguloDoCalcanharEsquerdoUsuarioZ;" +
					"AnguloDoPeEsquerdoUsuarioX;" +
					"AnguloDoPeEsquerdoUsuarioY;" +
					"AnguloDoPeEsquerdoUsuarioZ;" +
					"AnguloDoTroncoUsuarioX;" +
					"AnguloDoTroncoUsuarioY;" +
					"AnguloDoTroncoUsuarioZ;" +
					"AnguloDaBasePescocoUsuarioX;" +
					"AnguloDaBasePescocoUsuarioY;" +
					"AnguloDaBasePescocoUsuarioZ;" +
					"AnguloDaNucaUsuarioX;" +
					"AnguloDaNucaUsuarioY;" +
					"AnguloDaNucaUsuarioZ;" +
					"AnguloDaBaseOmbroEsquerdoUsuarioX;" +
					"AnguloDaBaseOmbroEsquerdoUsuarioY;" +
					"AnguloDaBaseOmbroEsquerdoUsuarioZ;" +
					"AnguloDoOmbroEsquerdoUsuarioX;" +
					"AnguloDoOmbroEsquerdoUsuarioY;" +
					"AnguloDoOmbroEsquerdoUsuarioZ;" +
					"AnguloDoCotoveloEsquerdoUsuarioX;" +
					"AnguloDoCotoveloEsquerdoUsuarioY;" +
					"AnguloDoCotoveloEsquerdoUsuarioZ;" +
					"AnguloDaMaoEsquerdaUsuarioX;" +
					"AnguloDaMaoEsquerdaUsuarioY;" +
					"AnguloDaMaoEsquerdaUsuarioZ;" +
					"AnguloDaBaseOmbroDireitoUsuarioX;" +
					"AnguloDaBaseOmbroDireitoUsuarioY;" +
					"AnguloDaBaseOmbroDireitoUsuarioZ;" +
					"AnguloDoOmbroDireitoUsuarioX;" +
					"AnguloDoOmbroDireitoUsuarioY;" +
					"AnguloDoOmbroDireitoUsuarioZ;" +
					"AnguloDoCotoveloDireitoUsuarioX;" +
					"AnguloDoCotoveloDireitoUsuarioY;" +
					"AnguloDoCotoveloDireitoUsuarioZ;" +
					"AnguloDaMaoDireitaUsuarioX;" +
					"AnguloDaMaoDireitaUsuarioY;" +
					"AnguloDaMaoDireitaUsuarioZ;" +

					"PosicaoDaCinturaAvatarX;" +
					"PosicaoDaCinturaAvatarY;" +
					"PosicaoDaCinturaAvatarZ;" +
					"PosicaoDoQuadrilDireitoAvatarX;" +
					"PosicaoDoQuadrilDireitoAvatarY;" +
					"PosicaoDoQuadrilDireitoAvatarZ;" +
					"PosicaoDaPernaDireitaAvatarX;" +
					"PosicaoDaPernaDireitaAvatarY;" +
					"PosicaoDaPernaDireitaAvatarZ;" +
					"PosicaoDoCalcanharDireitoAvatarX;" +
					"PosicaoDoCalcanharDireitoAvatarY;" +
					"PosicaoDoCalcanharDireitoAvatarZ;" +
					"PosicaoDoPeDireitoAvatarX;" +
					"PosicaoDoPeDireitoAvatarY;" +
					"PosicaoDoPeDireitoAvatarZ;" +
					"PosicaoDoQuadrilEsquerdoAvatarX;" +
					"PosicaoDoQuadrilEsquerdoAvatarY;" +
					"PosicaoDoQuadrilEsquerdoAvatarZ;" +
					"PosicaoDaPernaEsquerdaAvatarX;" +
					"PosicaoDaPernaEsquerdaAvatarY;" +
					"PosicaoDaPernaEsquerdaAvatarZ;" +
					"PosicaoDoCalcanharEsquerdoAvatarX;" +
					"PosicaoDoCalcanharEsquerdoAvatarY;" +
					"PosicaoDoCalcanharEsquerdoAvatarZ;" +
					"PosicaoDoPeEsquerdoAvatarX;" +
					"PosicaoDoPeEsquerdoAvatarY;" +
					"PosicaoDoPeEsquerdoAvatarZ;" +
					"PosicaoDoTroncoAvatarX;" +
					"PosicaoDoTroncoAvatarY;" +
					"PosicaoDoTroncoAvatarZ;" +
					"PosicaoDaBasePescocoAvatarX;" +
					"PosicaoDaBasePescocoAvatarY;" +
					"PosicaoDaBasePescocoAvatarZ;" +
					"PosicaoDaNucaAvatarX;" +
					"PosicaoDaNucaAvatarY;" +
					"PosicaoDaNucaAvatarZ;" +
					"PosicaoDaBaseOmbroEsquerdoAvatarX;" +
					"PosicaoDaBaseOmbroEsquerdoAvatarY;" +
					"PosicaoDaBaseOmbroEsquerdoAvatarZ;" +
					"PosicaoDoOmbroEsquerdoAvatarX;" +
					"PosicaoDoOmbroEsquerdoAvatarY;" +
					"PosicaoDoOmbroEsquerdoAvatarZ;" +
					"PosicaoDoCotoveloEsquerdoAvatarX;" +
					"PosicaoDoCotoveloEsquerdoAvatarY;" +
					"PosicaoDoCotoveloEsquerdoAvatarZ;" +
					"PosicaoDaMaoEsquerdaAvatarX;" +
					"PosicaoDaMaoEsquerdaAvatarY;" +
					"PosicaoDaMaoEsquerdaAvatarZ;" +
					"PosicaoDaBaseOmbroDireitoAvatarX;" +
					"PosicaoDaBaseOmbroDireitoAvatarY;" +
					"PosicaoDaBaseOmbroDireitoAvatarZ;" +
					"PosicaoDoOmbroDireitoAvatarX;" +
					"PosicaoDoOmbroDireitoAvatarY;" +
					"PosicaoDoOmbroDireitoAvatarZ;" +
					"PosicaoDoCotoveloDireitoAvatarX;" +
					"PosicaoDoCotoveloDireitoAvatarY;" +
					"PosicaoDoCotoveloDireitoAvatarZ;" +
					"PosicaoDaMaoDireitaAvatarX;" +
					"PosicaoDaMaoDireitaAvatarY;" +
					"PosicaoDaMaoDireitaAvatarZ;" +

					"AnguloDaCinturaAvatarX;" +
					"AnguloDaCinturaAvatarY;" +
					"AnguloDaCinturaAvatarZ;" +
					"AnguloDoQuadrilDireitoAvatarX;" +
					"AnguloDoQuadrilDireitoAvatarY;" +
					"AnguloDoQuadrilDireitoAvatarZ;" +
					"AnguloDaPernaDireitaAvatarX;" +
					"AnguloDaPernaDireitaAvatarY;" +
					"AnguloDaPernaDireitaAvatarZ;" +
					"AnguloDoCalcanharDireitoAvatarX;" +
					"AnguloDoCalcanharDireitoAvatarY;" +
					"AnguloDoCalcanharDireitoAvatarZ;" +
					"AnguloDoPeDireitoAvatarX;" +
					"AnguloDoPeDireitoAvatarY;" +
					"AnguloDoPeDireitoAvatarZ;" +
					"AnguloDoQuadrilEsquerdoAvatarX;" +
					"AnguloDoQuadrilEsquerdoAvatarY;" +
					"AnguloDoQuadrilEsquerdoAvatarZ;" +
					"AnguloDaPernaEsquerdaAvatarX;" +
					"AnguloDaPernaEsquerdaAvatarY;" +
					"AnguloDaPernaEsquerdaAvatarZ;" +
					"AnguloDoCalcanharEsquerdoAvatarX;" +
					"AnguloDoCalcanharEsquerdoAvatarY;" +
					"AnguloDoCalcanharEsquerdoAvatarZ;" +
					"AnguloDoPeEsquerdoAvatarX;" +
					"AnguloDoPeEsquerdoAvatarY;" +
					"AnguloDoPeEsquerdoAvatarZ;" +
					"AnguloDoTroncoAvatarX;" +
					"AnguloDoTroncoAvatarY;" +
					"AnguloDoTroncoAvatarZ;" +
					"AnguloDaBasePescocoAvatarX;" +
					"AnguloDaBasePescocoAvatarY;" +
					"AnguloDaBasePescocoAvatarZ;" +
					"AnguloDaNucaAvatarX;" +
					"AnguloDaNucaAvatarY;" +
					"AnguloDaNucaAvatarZ;" +
					"AnguloDaBaseOmbroEsquerdoAvatarX;" +
					"AnguloDaBaseOmbroEsquerdoAvatarY;" +
					"AnguloDaBaseOmbroEsquerdoAvatarZ;" +
					"AnguloDoOmbroEsquerdoAvatarX;" +
					"AnguloDoOmbroEsquerdoAvatarY;" +
					"AnguloDoOmbroEsquerdoAvatarZ;" +
					"AnguloDoCotoveloEsquerdoAvatarX;" +
					"AnguloDoCotoveloEsquerdoAvatarY;" +
					"AnguloDoCotoveloEsquerdoAvatarZ;" +
					"AnguloDaMaoEsquerdaAvatarX;" +
					"AnguloDaMaoEsquerdaAvatarY;" +
					"AnguloDaMaoEsquerdaAvatarZ;" +
					"AnguloDaBaseOmbroDireitoAvatarX;" +
					"AnguloDaBaseOmbroDireitoAvatarY;" +
					"AnguloDaBaseOmbroDireitoAvatarZ;" +
					"AnguloDoOmbroDireitoAvatarX;" +
					"AnguloDoOmbroDireitoAvatarY;" +
					"AnguloDoOmbroDireitoAvatarZ;" +
					"AnguloDoCotoveloDireitoAvatarX;" +
					"AnguloDoCotoveloDireitoAvatarY;" +
					"AnguloDoCotoveloDireitoAvatarZ;" +
					"AnguloDaMaoDireitaAvatarX;" +
					"AnguloDaMaoDireitaAvatarY;" +
					"AnguloDaMaoDireitaAvatarZ;");     
        }
    }

    public static void SalvarDistanciaUsuario(float mDisEsq, float mDisDir)
    {
        string[] lerTexto = File.ReadAllLines(arquivoUsuarios);
        File.Delete(arquivoUsuarios);

        using (StreamWriter sw = File.AppendText(arquivoUsuarios))
        {
            foreach(string line in lerTexto)
            {
                string linhaTexto = line;
                if (linhaTexto.Split(',')[0] + "," + linhaTexto.Split(',')[1] + "," + linhaTexto.Split(',')[2] == MenuJogar.nomeJogador)
                    linhaTexto = MenuJogar.nomeJogador + "," + mDisEsq + "," + mDisDir;

                sw.WriteLine(linhaTexto);

            }
        }
    }

}
