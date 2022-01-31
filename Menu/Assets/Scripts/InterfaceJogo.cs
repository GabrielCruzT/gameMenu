using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
using System.IO;


public class InterfaceJogo : MonoBehaviour {

    public GameObject menino;
	public GameObject menina;

	[SerializeField]
	private GameObject interfaceGUI;
	
	//[SerializeField]
	//private Text tempoInicio;
	[SerializeField]
	private Text nomeJogador;
	[SerializeField]
	private Text jogoAtual;
	public Text precisao;
	public Text repeticao;
	public Text velocidadeDaAnimacao;

	public static string[] opcoesJogo;

	// Use this for initialization
	void Start () {
		
		opcoesJogo = File.ReadAllLines(Diretorios_Salvar.arquivoOpcoes);

		if (MenuPrincipal.jogando == false)
		{
			interfaceGUI.SetActive(true);
			
			menina.SetActive(false);
		}
		else
		{
			interfaceGUI.SetActive(true);
			
			//tempoInicio.enabled = true;
			nomeJogador.text = MenuJogar.nomeJogador.Split(',')[0];

			if (MenuJogar.nomeJogador.Split(',')[2]=="F")
			{
				menina.SetActive(true);
				menino.SetActive (false);
			}
			else
			{
				menina.SetActive(false);
				menino.SetActive(true);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
        if (MenuPrincipal.jogando == true)
        {
			jogoAtual.text = opcoesJogo[3];
			//tempoInicio.text = EtapaDeJogo.tempoParaInicio.ToString();

            

            if (Input.GetKeyDown(KeyCode.Escape))
                SceneManager.LoadScene("Menu");

			repeticao.text = "Repetições: " + opcoesJogo[0];
			precisao.text = "Tolerância: " + opcoesJogo[1] + "°";
			velocidadeDaAnimacao.text = "Velocidade da animação: " + opcoesJogo[2];
		}
	}
}
