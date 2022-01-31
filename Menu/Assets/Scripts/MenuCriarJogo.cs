using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class MenuCriarJogo : MonoBehaviour {

	ScrollMenu scrollMenu;
	public static int velocidadeAnimacoes = 5;

	[SerializeField]
	GameObject infoPainel;
	[SerializeField]
	Button criarJogoButton;
	[SerializeField]
	GameObject prefabBotaoExcluirJogo;
	[SerializeField]
	Text prefabBotaoExcluirJogoText;
	[SerializeField]
	GameObject scrollMenuExcluirJogo;
	[SerializeField]
	Button excluirJogoButton;
	[SerializeField]
	InputField campoTolerancia;
	[SerializeField]
	InputField campoVelocidadeAnimacoes;
	[SerializeField]
	InputField campoNomeJogo;
	[SerializeField]
	InputField campoRepeticoes;

	public static int numAnim;
	public static int numRep;
	public static int numTol;
	public static string nome;

	void Start () {
	
	}

	void Update () {
		
		if (campoVelocidadeAnimacoes.text != ""  && campoTolerancia.text != "" && campoNomeJogo.text != "" && campoRepeticoes.text != "" && scrollMenuExcluirJogo.activeInHierarchy == false)
		{
			nome = campoNomeJogo.text;
			numAnim = int.Parse(campoVelocidadeAnimacoes.text);
			numRep = int.Parse(campoRepeticoes.text);
			numTol = int.Parse(campoTolerancia.text);

			if (numAnim > 5 || numAnim == 0 || numRep == 0 || numRep > 4 ) 
			{
				criarJogoButton.interactable = false;
				infoPainel.SetActive(true);
			}
            else
            {
				criarJogoButton.interactable = true;
				infoPainel.SetActive(false);
			}
				

		}
		else
		{
			criarJogoButton.interactable = false;
			infoPainel.SetActive (true);
		}

		if (Directory.GetFiles(Diretorios_Salvar.PastadeModosdeJogo).Length>1 && scrollMenuExcluirJogo.activeInHierarchy == false) 
			excluirJogoButton.interactable = true;
		else
			excluirJogoButton.interactable = false;
	}
	public void CriarJogo()
	{
		
		SceneManager.LoadScene ("Principal");
	}

	public void ExcluirJogo()
	{
		scrollMenu = gameObject.AddComponent<ScrollMenu> ();
		scrollMenu.ScrollSelecao (File.ReadAllLines (Diretorios_Salvar.arquivoMododeJogo), prefabBotaoExcluirJogo, prefabBotaoExcluirJogoText);
	}

	public void ExcluirModoDeJogo()
	{
		Diretorios_Salvar.ExcluirDados (File.ReadAllLines (Diretorios_Salvar.arquivoMododeJogo), Diretorios_Salvar.arquivoMododeJogo, NomeBotao.nomeEnviar);
		File.Delete(Diretorios_Salvar.PastadeModosdeJogo + "\\" + NomeBotao.nomeEnviar + ".txt");
        MenuOpcoes.ReescreveOpcoes("");
    }
}
