using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeControl : MonoBehaviour {
    public GameObject panel01;
    public GameObject panel02;
    public GameObject panel03;
    public GameObject panel04;
    public GameObject panel05;
    public GameObject img01;
    public GameObject img02;
    public GameObject img03;
    public GameObject img04;
    public GameObject img05;

    public int panel;
    // Use this for initialization
    void Start () {
        panel01.SetActive(false);
        panel02.SetActive(false);
        panel03.SetActive(false);
        panel04.SetActive(false);
        panel05.SetActive(false);
        img01.GetComponent<Collider2D>().enabled = true;
        img02.GetComponent<Collider2D>().enabled = true;
        img03.GetComponent<Collider2D>().enabled = true;
        img04.GetComponent<Collider2D>().enabled = true;
        img05.GetComponent<Collider2D>().enabled = true;

    }
    public void OnMouseDown()
    {
        img01.GetComponent<Collider2D>().enabled = false;
        img02.GetComponent<Collider2D>().enabled = false;
        img03.GetComponent<Collider2D>().enabled = false;
        img04.GetComponent<Collider2D>().enabled = false;
        img05.GetComponent<Collider2D>().enabled = false;
        if (panel==1)
            panel01.SetActive(true);
        if (panel == 2)
            panel02.SetActive(true);
        if (panel == 3)
            panel03.SetActive(true);
        if (panel == 4)
            panel04.SetActive(true);
        if (panel == 5)
            panel05.SetActive(true);

    }

    public void Exit()
    {
        panel01.SetActive(false);
        panel02.SetActive(false);
        panel03.SetActive(false);
        panel04.SetActive(false);
        panel05.SetActive(false);
        img01.GetComponent<Collider2D>().enabled = true;
        img02.GetComponent<Collider2D>().enabled = true;
        img03.GetComponent<Collider2D>().enabled = true;
        img04.GetComponent<Collider2D>().enabled = true;
        img05.GetComponent<Collider2D>().enabled = true;
    }
    public void Back()
    {
        SceneManager.LoadSceneAsync(0);
    }
    public void urlLinkOrWeb01()
    {
        Application.OpenURL("http://www.cas.org.tw/cas%E5%84%AA%E8%89%AF%E8%BE%B2%E7%94%A2%E5%93%81%E6%A8%99%E7%AB%A0%E4%BB%8B%E7%B4%B9");
    }
    public void urlLinkOrWeb02()
    {
        Application.OpenURL("http://taft.coa.gov.tw/ct.asp?xItem=4&CtNode=296&role=C");
    }
    public void urlLinkOrWeb03()
    {
        Application.OpenURL("http://gap.afa.gov.tw/faq");
    }
    public void urlLinkOrWeb05()
    {
        Application.OpenURL("https://qrc.afa.gov.tw/Page");
    }
}
