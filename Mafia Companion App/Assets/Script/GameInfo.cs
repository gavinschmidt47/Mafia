using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "GameInfo", menuName = "ScriptableObjects/GameInfo", order = 1)]
public class GameInfo : ScriptableObject
{
    //TownName Info
    public string townName;

    //Population Info
    public int population;

    //Controllers For Diff Scenes
    private InfoController infoController;
    private GameController gameController;

    //Town Roles Selections
    public int angels;
    public bool bodyguard;
    public bool bride;
    public bool groom;
    public bool busDriver;
    public bool crier;
    public bool cupid;
    public bool escort;
    public bool gwag;
    public bool investigator;
    public bool jailor;
    public bool lookout;
    public bool marshall;
    public bool martialArtist;
    public bool masonLeader;
    public int mason;
    public bool sheriff;
    public bool undercoverCop;
    public bool veteran;
    public bool vigilante;

    //Mafia Roles Selections
    public bool agent;
    public bool beguiler;
    public bool blackmailer;
    public bool consort;
    public bool framer;
    public bool godfather;
    public bool kidnapper;
    public bool madeMan;
    public int mafioso;
    public bool mobWife;

    //Triad Roles Selections
    public bool administrator;
    public bool deceiver;
    public bool dragonHead;
    public int enforcer;
    public bool forger;
    public bool interrogator;
    public bool initiator;
    public bool liason;
    public bool silencer;
    public bool vanguard;

    //Cult Roles Selections
    public bool acolyte;
    public int cultist;
    public bool witchDoctor;

    //Independent Roles Selections
    public bool amnesiac;
    public bool arsonist;
    public bool elector;
    public bool electromaniac;
    public bool executioner;
    public bool jester;
    public bool massMurderer;
    public bool serialKiller;
    public bool survivor;

    //Called At Start Of Each Scene
    private void OnEnable()
    {
        //If Info
        infoController = FindAnyObjectByType<InfoController>();
        if (infoController == null)
        {
            Debug.Log("InfoController not found in the scene.");

            //If Game
            gameController = FindAnyObjectByType<GameController>();
            if (gameController == null)
            {
                Debug.Log("GameController not found in the scene.");
                return;
            }
        }
    }

    //Called By TownName Input Field
    public void makeTName(string name)
    {
        //Error Check
        if (name == "")
        {
            infoController.townError.SetActive(true);
            return;
        }
        //Move To Population
        else
        {
            //Set TownName
            townName = name;
            infoController.townPanel.SetActive(false);
            infoController.townError.SetActive(false);

            //Activate Population Panel
            infoController.populationText.text = townName + " has a population of ";
            infoController.populationPanel.SetActive(true);
        }
    }

    //Called By Population Input Field
    public void makePop(string pop)
    {
        //Error Check
        if (pop == "" || !int.TryParse(pop, out int n))
        {
            infoController.populationText.text = townName + " has a population of ";
            infoController.populationPanel.SetActive(true);
            infoController.formatError.SetActive(true);
            return;
        }
        else if (int.Parse(pop) < 4)
        {
            infoController.formatError.SetActive(false);
            infoController.moreError.SetActive(true);
            return;
        }
        //Move To Roles
        else
        {
            //Set Population
            population = int.Parse(pop);
            infoController.populationPanel.SetActive(false);

            //Activate Roles Panel
            infoController.rolesPanel.SetActive(true);
        }
    }
}
