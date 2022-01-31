using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class Iniciar : MonoBehaviour
{

	string jogador;
	string nomeJogador;
	string nomeSalvar;
	string idadeSalvar;
	string generosalvar;
	Diretorios_Salvar diretorioSalvar = new Diretorios_Salvar();
	ScrollMenu scrollMenu;

	[SerializeField]
	Toggle masculino;
	[SerializeField]
	Toggle feminino;
	[SerializeField]
	InputField campoNome;
	[SerializeField]
	InputField campoIdade;
	[SerializeField]
	Button criarUsuarioButton;
	[SerializeField]
	GameObject aviso;

	public void Update()
	{
		if (campoNome.text != "" && campoIdade.text != "" && (masculino.isOn || feminino.isOn))
		{
			criarUsuarioButton.interactable = true;
			aviso.SetActive(false);
		}
		else
		{
			criarUsuarioButton.interactable = false;
			aviso.SetActive(true);
		}
	}

	public void Criarjogador()
	{
		if (masculino.isOn)
			generosalvar = "Masculino";
		else if (feminino.isOn)
			generosalvar = "Feminino";

		nomeSalvar = campoNome.text;
		idadeSalvar = campoIdade.text;

		jogador = nomeSalvar + "," + idadeSalvar + " Anos" + "," + generosalvar;
		nomeJogador = nomeSalvar;

		campoNome.text = "";
		campoIdade.text = "";

		masculino.isOn = false;
		feminino.isOn = false;

		Diretorios_Salvar.AdicionarDados(Diretorios_Salvar.arquivoUsuarios, jogador);
		//Diretorios_Salvar.AdicionarDados(Diretorios_Salvar.arquivoNomeUsuario, nomeJogador);
	}
	public void BotaoVoltar()       //apaga conteudos dos inputfields 
	{
		campoNome.text = "";
		campoIdade.text = "";
		masculino.isOn = false;
		feminino.isOn = false;
	}
}
