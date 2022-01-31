using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class MenuOpcoes : MonoBehaviour{

	
	public Toggle checkboxProjetor;
	public InputField campoRepeticoes;
	public InputField campoVelAnimacao;
	public InputField campoTolerancia;
	private Diretorios_Salvar diretorioSalvar = new Diretorios_Salvar();
	public static bool projetor;
	public static string[] opcoesSelecionadas = new string[5];
	public static string[] opcoesIniciais = new string[5];
	private string[] verificaOp;

	public static float valorScrollbarTOA=2;
	public static float valorScrollbarTEO=2;
    private int maxPontos;
	private float maxTempo;
    [SerializeField]
	private GameObject PainelSalvar;

	public void Start()
	{
		opcoesSelecionadas = File.ReadAllLines (Diretorios_Salvar.arquivoOpcoes);
		verificaOp = File.ReadAllLines (Diretorios_Salvar.arquivoOpcoes);

		//Objeto.nomeJogo = opcoesSelecionadas[3];                               
		checkboxProjetor.isOn = bool.Parse(opcoesSelecionadas[4]);  
		
        Debug.Log(projetor);
	}

	public void Update()
	{
		
	}
	public static string[] OpcoesIniciais()
	{
		opcoesIniciais[0] = "3";
		opcoesIniciais[1] = "30";
		opcoesIniciais[2] = "1";
		opcoesIniciais[3] = "";
		opcoesIniciais[4] = "false";
		return opcoesIniciais;
	}

	public void AplicarOpcoes()
	{

		opcoesSelecionadas[0] = MenuCriarJogo.numRep.ToString();
		opcoesSelecionadas[1] = MenuCriarJogo.numTol.ToString();
		opcoesSelecionadas[2] = MenuCriarJogo.numAnim.ToString();
		opcoesSelecionadas[3] = MenuCriarJogo.nome.ToString();

		if (checkboxProjetor.isOn)
			projetor = true;
		else
			projetor = false;

		opcoesSelecionadas[4] = projetor.ToString();

		Diretorios_Salvar.SalvarDadosTeste(opcoesSelecionadas, Diretorios_Salvar.arquivoOpcoes);
		Resolucao.MudaResolucao();
		Start();

		//VerificaOpcoes ();
	}

    public static void ReescreveOpcoes(string novoJogo)
    {
        string[] novasOpcoes = File.ReadAllLines(Diretorios_Salvar.arquivoOpcoes);
        File.Delete(Diretorios_Salvar.arquivoOpcoes);
        novasOpcoes[3] = novoJogo;
        using (StreamWriter sw = File.AppendText(Diretorios_Salvar.arquivoOpcoes))       //altera arquivo  opcoes
        {
            foreach (string line in novasOpcoes)
                sw.WriteLine(line);
        }
    }

}
