using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
using System.IO;
using System.Collections.Generic;

public class MovimentacaoDoUsuario : MonoBehaviour
{
    public Animator myAnim;
    
    float x;
    public static float frame;
    int ultimoFrame = 205;
    int repeticoesDosTestes;
    int velocidadeDaAnimacao;
    bool parar = false;

    List<float> listaFrames = new List<float>();

    List<Vector3> coordenadaOmbroDireitoUsuario = new List<Vector3>();
    List<Vector3> coordenadaOmbroEsquerdoUsuario = new List<Vector3>();
    List<Vector3> coordenadaCotoveloDireitoUsuario = new List<Vector3>();
    List<Vector3> coordenadaCotoveloEsquerdoUsuario = new List<Vector3>();
    List<Vector3> coordenadaPulsoDireitoUsuario = new List<Vector3>();
    List<Vector3> coordenadaPulsoEsquerdoUsuario = new List<Vector3>();
    List<Vector3> coordenadaJoelhoDireitoUsuario = new List<Vector3>();
    List<Vector3> coordenadaJoelhoEsquerdoUsuario = new List<Vector3>();
    List<Vector3> coordenadaTornozeloDireitoUsuario = new List<Vector3>();
    List<Vector3> coordenadaTornozeloEsquerdoUsuario = new List<Vector3>();

    float diferencaOmbroDireitoX;
    float diferencaOmbroDireitoY;
    float diferencaOmbroDireitoZ;

    float diferencaOmbroEsquerdoX;
    float diferencaOmbroEsquerdoY;
    float diferencaOmbroEsquerdoZ;

    float diferencaCotoveloDireitoX;
    float diferencaCotoveloDireitoY;
    float diferencaCotoveloDireitoZ;

    float diferencaCotoveloEsquerdoX;
    float diferencaCotoveloEsquerdoY;
    float diferencaCotoveloEsquerdoZ;

    float diferencaPulsoDireitoX;
    float diferencaPulsoDireitoY;
    float diferencaPulsoDireitoZ;

    float diferencaPulsoEsquerdoX;
    float diferencaPulsoEsquerdoY;
    float diferencaPulsoEsquerdoZ;

    float diferencaJoelhoDireitoX;
    float diferencaJoelhoDireitoY;
    float diferencaJoelhoDireitoZ;

    float diferencaJoelhoEsquerdoX;
    float diferencaJoelhoEsquerdoY;
    float diferencaJoelhoEsquerdoZ;

    float diferencaTornozeloDireitoX;
    float diferencaTornozeloDireitoY;
    float diferencaTornozeloDireitoZ;

    float diferencaTornozeloEsquerdoX;
    float diferencaTornozeloEsquerdoY;
    float diferencaTornozeloEsquerdoZ;

    public float diferencaMaxima;

    public GameObject bolaOmbroDireito;
    public GameObject bolaOmbroEsquerdo;
    public GameObject bolaCotoveloDireito;
    public GameObject bolaCotoveloEsquerdo;
    public GameObject bolaPulsoDireito;
    public GameObject bolaPulsoEsquerdo;
    public GameObject bolaJoelhoDireito;
    public GameObject bolaJoelhoEsquerdo;
    public GameObject bolaTornozeloDireito;
    public GameObject bolaTornozeloEsquerdo;

    public GameObject posicaoOmbroDireito;
    public GameObject posicaoOmbroEsquerdo;
    public GameObject posicaoCotoveloDireito;
    public GameObject posicaoCotoveloEsquerdo;
    public GameObject posicaoPulsoDireito;
    public GameObject posicaoPulsoEsquerdo;
    public GameObject posicaoJoelhoDireito;
    public GameObject posicaoJoelhoEsquerdo;
    public GameObject posicaoTornozeloDireito;
    public GameObject posicaoTornozeloEsquerdo;

    public GameObject ombroDireitoUsuario;
    public GameObject ombroEsquerdoUsuario;
    public GameObject cotoveloDireitoUsuario;
    public GameObject cotoveloEsquerdoUsuario;
    public GameObject pulsoDireitoUsuario;
    public GameObject pulsoEsquerdoUsuario;
    public GameObject joelhoDireitoUsuario;
    public GameObject joelhoEsquerdoUsuario;
    public GameObject tornozeloDireitoUsuario;
    public GameObject tornozeloEsquerdoUsuario;

    public static int estagio = 0;
    public static int repeticao = 1;
    public static bool rodandoAnimacao = false;
    public static int valor = 0;
    public static bool gravar = false;

    Vector3 posicaoOmbroDireitoUsuario;
    Vector3 posicaoOmbroEsquerdoUsuario;
    Vector3 posicaoCotoveloDireitoUsuario;
    Vector3 posicaoCotoveloEsquerdoUsuario;
    Vector3 posicaoPulsoDireitoUsuario;
    Vector3 posicaoPulsoEsquerdoUsuario;
    Vector3 posicaoJoelhoDireitoUsuario;
    Vector3 posicaoJoelhoEsquerdoUsuario;
    Vector3 posicaoTornozeloDireitoUsuario;
    Vector3 posicaoTornozeloEsquerdoUsuario;

    Vector3 posicaoOmbroDireitoAvatar;
    Vector3 posicaoOmbroEsquerdoAvatar;
    Vector3 posicaoCotoveloDireitoAvatar;
    Vector3 posicaoCotoveloEsquerdoAvatar;
    Vector3 posicaoPulsoDireitoAvatar;
    Vector3 posicaoPulsoEsquerdoAvatar;
    Vector3 posicaoJoelhoDireitoAvatar;
    Vector3 posicaoJoelhoEsquerdoAvatar;
    Vector3 posicaoTornozeloDireitoAvatar;
    Vector3 posicaoTornozeloEsquerdoAvatar;

   

    // Start is called before the first frame update
    void Start()
    {
        repeticoesDosTestes = MenuCriarJogo.numRep;
        velocidadeDaAnimacao = MenuCriarJogo.numAnim;
        diferencaMaxima = MenuCriarJogo.numTol;
    }

    // Update is called once per frame
    void Update()
    {
        bolaOmbroDireito.SetActive(false);
        bolaOmbroEsquerdo.SetActive(false);
        bolaCotoveloDireito.SetActive(false);
        bolaCotoveloEsquerdo.SetActive(false);
        bolaPulsoDireito.SetActive(false);
        bolaPulsoEsquerdo.SetActive(false);
        bolaJoelhoDireito.SetActive(false);
        bolaJoelhoEsquerdo.SetActive(false);
        bolaTornozeloDireito.SetActive(false);
        bolaTornozeloEsquerdo.SetActive(false);

        if (estagio == 3)
        {
            parar = true;
        }
        else
        {
            parar = false;
        }


        if (rodandoAnimacao)
        {
            x = myAnim.GetCurrentAnimatorStateInfo(0).normalizedTime; //Percentual (varia de 0 a 1)
            frame = Mathf.Round(x * ultimoFrame);
           
            posicaoOmbroDireitoAvatar = posicaoOmbroDireito.transform.eulerAngles;
            posicaoOmbroDireitoUsuario = ombroDireitoUsuario.transform.eulerAngles;

            posicaoOmbroEsquerdoAvatar = posicaoOmbroEsquerdo.transform.eulerAngles;
            posicaoOmbroEsquerdoUsuario = ombroEsquerdoUsuario.transform.eulerAngles;

            posicaoCotoveloDireitoAvatar = posicaoCotoveloDireito.transform.eulerAngles;
            posicaoCotoveloDireitoUsuario = cotoveloDireitoUsuario.transform.eulerAngles;

            posicaoCotoveloEsquerdoAvatar = posicaoCotoveloEsquerdo.transform.eulerAngles;
            posicaoCotoveloEsquerdoUsuario = cotoveloEsquerdoUsuario.transform.eulerAngles;

            posicaoPulsoDireitoAvatar = posicaoPulsoDireito.transform.eulerAngles;
            posicaoPulsoDireitoUsuario = pulsoDireitoUsuario.transform.eulerAngles;

            posicaoPulsoEsquerdoAvatar = posicaoPulsoEsquerdo.transform.eulerAngles;
            posicaoPulsoEsquerdoUsuario = pulsoEsquerdoUsuario.transform.eulerAngles;

            posicaoJoelhoDireitoAvatar = posicaoJoelhoDireito.transform.eulerAngles;
            posicaoJoelhoDireitoUsuario = joelhoDireitoUsuario.transform.eulerAngles;

            posicaoJoelhoEsquerdoAvatar = posicaoJoelhoEsquerdo.transform.eulerAngles;
            posicaoJoelhoEsquerdoUsuario = joelhoEsquerdoUsuario.transform.eulerAngles;

            posicaoTornozeloDireitoAvatar = posicaoTornozeloDireito.transform.eulerAngles;
            posicaoTornozeloDireitoUsuario = tornozeloDireitoUsuario.transform.eulerAngles;

            posicaoTornozeloEsquerdoAvatar = posicaoOmbroDireito.transform.eulerAngles;
            posicaoTornozeloEsquerdoUsuario = tornozeloEsquerdoUsuario.transform.eulerAngles;

            if (frame <= ultimoFrame)
            {
                if (estagio == 2) //Armazenar Posiçõess
                {
                    if (!listaFrames.Contains(frame))
                    {
                        listaFrames.Add(frame);
                        coordenadaOmbroDireitoUsuario.Add(posicaoOmbroDireitoAvatar);
                        coordenadaOmbroEsquerdoUsuario.Add(posicaoOmbroDireitoAvatar);
                        coordenadaCotoveloDireitoUsuario.Add(posicaoOmbroDireitoAvatar);
                        coordenadaCotoveloEsquerdoUsuario.Add(posicaoOmbroDireitoAvatar);
                        coordenadaPulsoDireitoUsuario.Add(posicaoOmbroDireitoAvatar);
                        coordenadaPulsoEsquerdoUsuario.Add(posicaoOmbroDireitoAvatar);
                        coordenadaJoelhoDireitoUsuario.Add(posicaoOmbroDireitoAvatar);
                        coordenadaJoelhoEsquerdoUsuario.Add(posicaoOmbroDireitoAvatar);
                        coordenadaTornozeloDireitoUsuario.Add(posicaoOmbroDireitoAvatar);
                        coordenadaTornozeloEsquerdoUsuario.Add(posicaoOmbroDireitoAvatar);
                    }
                }
                else if (estagio == 3)//Verificar posições (bola aparece)
                {
                    if (listaFrames.Contains(frame))
                    {
                        int index = listaFrames.IndexOf(frame);

                        //Diferença do ombro direito
                        diferencaOmbroDireitoX = Mathf.Abs(coordenadaOmbroDireitoUsuario[index].x - posicaoOmbroDireitoAvatar.x);
                        diferencaOmbroDireitoY = Mathf.Abs(coordenadaOmbroDireitoUsuario[index].y - posicaoOmbroDireitoAvatar.y);
                        diferencaOmbroDireitoZ = Mathf.Abs(coordenadaOmbroDireitoUsuario[index].z - posicaoOmbroDireitoAvatar.z);
                        //Diferença do ombro esquerdo
                        diferencaOmbroEsquerdoX = Mathf.Abs(coordenadaOmbroEsquerdoUsuario[index].x - posicaoOmbroEsquerdoAvatar.x);
                        diferencaOmbroEsquerdoY = Mathf.Abs(coordenadaOmbroEsquerdoUsuario[index].y - posicaoOmbroEsquerdoAvatar.y);
                        diferencaOmbroEsquerdoZ = Mathf.Abs(coordenadaOmbroEsquerdoUsuario[index].z - posicaoOmbroEsquerdoAvatar.z);
                        //Diferença do cotovelo direito
                        diferencaCotoveloDireitoX = Mathf.Abs(coordenadaCotoveloDireitoUsuario[index].x - posicaoCotoveloDireitoAvatar.x);
                        diferencaCotoveloDireitoY = Mathf.Abs(coordenadaCotoveloDireitoUsuario[index].y - posicaoCotoveloDireitoAvatar.y);
                        diferencaCotoveloDireitoZ = Mathf.Abs(coordenadaCotoveloDireitoUsuario[index].z - posicaoCotoveloDireitoAvatar.z);
                        //Diferença do cotovelo esquerdo
                        diferencaCotoveloEsquerdoX = Mathf.Abs(coordenadaCotoveloEsquerdoUsuario[index].x - posicaoCotoveloEsquerdoAvatar.x);
                        diferencaCotoveloEsquerdoY = Mathf.Abs(coordenadaCotoveloEsquerdoUsuario[index].y - posicaoCotoveloEsquerdoAvatar.y);
                        diferencaCotoveloEsquerdoZ = Mathf.Abs(coordenadaCotoveloEsquerdoUsuario[index].z - posicaoCotoveloEsquerdoAvatar.z);
                        //Diferença do pulso direito
                        diferencaPulsoDireitoX = Mathf.Abs(coordenadaPulsoDireitoUsuario[index].x - posicaoPulsoDireitoAvatar.x);
                        diferencaPulsoDireitoY = Mathf.Abs(coordenadaPulsoDireitoUsuario[index].y - posicaoPulsoDireitoAvatar.y);
                        diferencaPulsoDireitoZ = Mathf.Abs(coordenadaPulsoDireitoUsuario[index].z - posicaoPulsoDireitoAvatar.z);
                        //Diferença do pulso esquerdo
                        diferencaPulsoEsquerdoX = Mathf.Abs(coordenadaPulsoEsquerdoUsuario[index].x - posicaoPulsoEsquerdoAvatar.x);
                        diferencaPulsoEsquerdoY = Mathf.Abs(coordenadaPulsoEsquerdoUsuario[index].y - posicaoPulsoEsquerdoAvatar.y);
                        diferencaPulsoEsquerdoZ = Mathf.Abs(coordenadaPulsoEsquerdoUsuario[index].z - posicaoPulsoEsquerdoAvatar.z);
                        //Diferença do joelho direito
                        diferencaJoelhoDireitoX = Mathf.Abs(coordenadaJoelhoDireitoUsuario[index].x - posicaoJoelhoDireitoAvatar.x);
                        diferencaJoelhoDireitoY = Mathf.Abs(coordenadaJoelhoDireitoUsuario[index].y - posicaoJoelhoDireitoAvatar.y);
                        diferencaJoelhoDireitoZ = Mathf.Abs(coordenadaJoelhoDireitoUsuario[index].z - posicaoJoelhoDireitoAvatar.z);
                        //Diferença do joelho esquerdo
                        diferencaJoelhoEsquerdoX = Mathf.Abs(coordenadaJoelhoEsquerdoUsuario[index].x - posicaoJoelhoEsquerdoAvatar.x);
                        diferencaJoelhoEsquerdoY = Mathf.Abs(coordenadaJoelhoEsquerdoUsuario[index].y - posicaoJoelhoEsquerdoAvatar.y);
                        diferencaJoelhoEsquerdoZ = Mathf.Abs(coordenadaJoelhoEsquerdoUsuario[index].z - posicaoJoelhoEsquerdoAvatar.z);
                        //Diferença do tornozelo direito
                        diferencaTornozeloDireitoX = Mathf.Abs(coordenadaTornozeloDireitoUsuario[index].x - posicaoTornozeloDireitoAvatar.x);
                        diferencaTornozeloDireitoY = Mathf.Abs(coordenadaTornozeloDireitoUsuario[index].y - posicaoTornozeloDireitoAvatar.y);
                        diferencaTornozeloDireitoZ = Mathf.Abs(coordenadaTornozeloDireitoUsuario[index].z - posicaoTornozeloDireitoAvatar.z);
                        //Diferença do tornozelo esquerdo
                        diferencaTornozeloEsquerdoX = Mathf.Abs(coordenadaTornozeloEsquerdoUsuario[index].x - posicaoTornozeloEsquerdoAvatar.x);
                        diferencaTornozeloEsquerdoY = Mathf.Abs(coordenadaTornozeloEsquerdoUsuario[index].y - posicaoTornozeloEsquerdoAvatar.y);
                        diferencaTornozeloEsquerdoZ = Mathf.Abs(coordenadaTornozeloEsquerdoUsuario[index].z - posicaoTornozeloEsquerdoAvatar.z);

                        if (diferencaOmbroDireitoX > diferencaMaxima || diferencaOmbroDireitoY > diferencaMaxima || diferencaOmbroDireitoZ > diferencaMaxima)
                        {
                            bolaOmbroDireito.SetActive(true);
                            bolaOmbroDireito.transform.position = posicaoOmbroDireito.transform.position;
                        }
                        
                        if (diferencaOmbroEsquerdoX > diferencaMaxima || diferencaOmbroEsquerdoY > diferencaMaxima || diferencaOmbroEsquerdoZ > diferencaMaxima)
                        {
                            bolaOmbroEsquerdo.SetActive(true);
                            bolaOmbroEsquerdo.transform.position = posicaoOmbroEsquerdo.transform.position;
                        }
                        
                        if (diferencaCotoveloDireitoX > diferencaMaxima || diferencaCotoveloDireitoY > diferencaMaxima || diferencaCotoveloDireitoZ > diferencaMaxima)
                        {
                            bolaCotoveloDireito.SetActive(true);
                            bolaCotoveloDireito.transform.position = posicaoCotoveloDireito.transform.position;
                        }
                        
                        if (diferencaCotoveloEsquerdoX > diferencaMaxima || diferencaCotoveloEsquerdoY > diferencaMaxima || diferencaCotoveloEsquerdoZ > diferencaMaxima)
                        {
                            bolaCotoveloEsquerdo.SetActive(true);
                            bolaCotoveloEsquerdo.transform.position = posicaoCotoveloEsquerdo.transform.position;
                        }
                        
                        if (diferencaPulsoDireitoX > diferencaMaxima || diferencaPulsoDireitoY > diferencaMaxima || diferencaPulsoDireitoZ > diferencaMaxima)
                        {
                            bolaPulsoDireito.SetActive(true);
                            bolaPulsoDireito.transform.position = posicaoPulsoDireito.transform.position;
                        }
                        
                        if (diferencaPulsoEsquerdoX > diferencaMaxima || diferencaPulsoEsquerdoY > diferencaMaxima || diferencaPulsoEsquerdoZ > diferencaMaxima)
                        {
                            bolaPulsoEsquerdo.SetActive(true);
                            bolaPulsoEsquerdo.transform.position = posicaoPulsoEsquerdo.transform.position;
                        }
                        
                        if (diferencaJoelhoDireitoX > diferencaMaxima || diferencaJoelhoDireitoY > diferencaMaxima || diferencaJoelhoDireitoZ > diferencaMaxima)
                        {
                            bolaJoelhoDireito.SetActive(true);
                            bolaJoelhoDireito.transform.position = posicaoJoelhoDireito.transform.position;
                        }
                        
                        if (diferencaJoelhoEsquerdoX > diferencaMaxima || diferencaJoelhoEsquerdoY > diferencaMaxima || diferencaJoelhoEsquerdoZ > diferencaMaxima)
                        {
                            bolaJoelhoEsquerdo.SetActive(true);
                            bolaJoelhoEsquerdo.transform.position = posicaoJoelhoEsquerdo.transform.position;
                        }
                        
                        if (diferencaTornozeloDireitoX > diferencaMaxima || diferencaTornozeloDireitoY > diferencaMaxima || diferencaTornozeloDireitoZ > diferencaMaxima)
                        {
                            bolaTornozeloDireito.SetActive(true);
                            bolaTornozeloDireito.transform.position = posicaoTornozeloDireito.transform.position;
                        }
                        
                        if (diferencaTornozeloEsquerdoX > diferencaMaxima || diferencaTornozeloEsquerdoY > diferencaMaxima || diferencaTornozeloEsquerdoZ > diferencaMaxima)
                        {
                            bolaTornozeloEsquerdo.SetActive(true);
                            bolaTornozeloEsquerdo.transform.position = posicaoTornozeloEsquerdo.transform.position;
                        }
                    }                   
                }
            }
            else
            {
                estagio++;
                rodandoAnimacao = false;
                if (estagio == 4)
                {
                    estagio = 2;
                    valor = 2;
                    repeticao++;
                    EtapaDeJogo.gravarDados = true;
                }
            }
        }
        if (Input.GetButtonDown("Jump"))//Input.GetButtonDown("Jump") (Input.GetKey(KeyCode.Backspace)
        {
            valor++;
            myAnim.Play("Capoeira", -1, 0f);
            rodandoAnimacao = true;

            if (velocidadeDaAnimacao == 5)
                myAnim.GetComponent<Animator>().speed = 1f;
            if (velocidadeDaAnimacao == 4)
                myAnim.GetComponent<Animator>().speed = 0.8f;
            if (velocidadeDaAnimacao == 3)
                myAnim.GetComponent<Animator>().speed = 0.6f;
            if (velocidadeDaAnimacao == 2)
                myAnim.GetComponent<Animator>().speed = 0.4f;
            if (velocidadeDaAnimacao == 1)
                myAnim.GetComponent<Animator>().speed = 0.3f; 
        }
        if (valor == 3)
        {
            if (parar == true)
            {
                gravar = false;
                EtapaDeJogo.escrevertxt = false;
                
            }
            else
            {
                gravar = true;
                EtapaDeJogo.escrevertxt = true;
                
            }
        }

        if (repeticao == repeticoesDosTestes+1)
        {
            MenuPrincipal.jogando = false;
            EtapaDeJogo.escrevertxt = false;
            SceneManager.LoadScene("Menu");
            repeticao = 1;
            estagio = 0;
            valor = 0;
        }
        
    }


}
