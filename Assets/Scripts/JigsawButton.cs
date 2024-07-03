using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class JigsawButton : MonoBehaviour
{
    int i = 0;
    [SerializeField] GameObject aboutMe;
    [SerializeField] bool move = false;
    [SerializeField] float rate;
    [SerializeField] Transform point;
    [SerializeField] float titleHeight;
    [SerializeField] Transform nameGO;
    [SerializeField] GameObject moveTxt;
    [SerializeField] GameObject[] letterGameobjects;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (move && nameGO.localPosition.y < titleHeight)
        {
           nameGO.position = new Vector3(nameGO.position.x, nameGO.position.y + Time.deltaTime * rate, nameGO.position.z); 
        }else if(nameGO.localPosition.y >= titleHeight)
        {
            if(nameGO.localScale.x > .7f)
            {
                nameGO.localScale = new Vector3(nameGO.localScale.x - Time.deltaTime*rate/100, nameGO.localScale.y - Time.deltaTime*rate/100, 1);
            }
            else if(i==0)
            {
                aboutMe.SetActive(true);
                i = 1;
            }
        }
    }

    public void SwitchPosition()
    {
        this.transform.position = new Vector3(transform.position.x, point.transform.position.y, transform.position.z);
        foreach(var obj in letterGameobjects)
        {
            obj.GetComponent<Button>().interactable = false;
            obj.GetComponent<Image>().color = new Color(100, 255, 100, 255);
            
            
        }
        moveTxt.GetComponent<TextMeshProUGUI>().text = "very well done!";
        StartCoroutine(Move());
    }

    IEnumerator Move()
    {
        yield return new WaitForSeconds(1f);
        move = true;
    }

}
