using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class EtapaDeJogo : MonoBehaviour
{
    public static bool gravarDados = true;
    public static float tempodeJogo;
    public static bool jogoRodando = false;
    public static bool escrevertxt = false;
    public static string nomeJogo;
    public static string nomeModoJogo;

    private string ArquivoJogo;
    private string NomeArquivoJogo;

    [SerializeField]
    private GameObject interfaceGUI;

    void Start()
    {
        jogoRodando = false;
        if (MenuPrincipal.jogando == false)
        {
            interfaceGUI.SetActive(false);    
        }
        else
        {
            interfaceGUI.SetActive(true);                               
        }  
    }

    void Update()
    {
        if (MovimentacaoDoUsuario.gravar==true)
        {
            escrevertxt = true;
            GravarArquivos();
        }
    }
    void GravarArquivos()
    {
        if(gravarDados)
        {
            gravarDados = false;
            Diretorios_Salvar.CriarArquivoDadosUsuario();
        }
       
    }
} 
