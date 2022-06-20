using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mensagem : MonoBehaviour
{
    public GameObject panelBox;
    public TextAsset arquivo;
    public string[] texto;
    public Text textoMensagem;

    private int fimDaLinha;
    private int linhaAtual;
    private bool estaAtivo;


    // Start is called before the first frame update
    void Start()
    {
        if (arquivo != null)
        {
            texto = (arquivo.text.Split("\n"));
        }  

        if (fimDaLinha == 0)
        {
            fimDaLinha = texto.Length;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (linhaAtual < fimDaLinha)
            {
                textoMensagem.text = texto[linhaAtual];
            }
            
            if(panelBox.activeSelf)
            {
                linhaAtual += 1;
            }
        }
        
        if (linhaAtual > fimDaLinha)
        {
            linhaAtual = 0;
            Desabilitar();
        }
    }

    void Habilitar()
    {
        panelBox.SetActive(true);
    }

    void Desabilitar()
    {
        panelBox.SetActive(false);
    }
}
