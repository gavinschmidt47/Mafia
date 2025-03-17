using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;


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

    //Players
    public Dictionary<string, Player> players = new Dictionary<string, Player>();
    public List<string> roleslist = new List<string>();

    public struct Player
    {
        public string name;
        public int number;
        public string role;

        public Player(string name, int number, string role)
        {
            this.name = name;
            this.number = number;
            this.role = role;
        }
    }

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
            infoController.moreError.SetActive(false);
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

    public void makeList()
    {
        roleslist.Clear();

        // Town Roles
        if (angels > 0) 
        {
            for (int i = 0; i < angels; i++)
                roleslist.Add("Angels");
        }
        if (bodyguard) roleslist.Add("Bodyguard");
        if (bride) roleslist.Add("Bride");
        if (groom) roleslist.Add("Groom");
        if (busDriver) roleslist.Add("Bus Driver");
        if (crier) roleslist.Add("Crier");
        if (cupid) roleslist.Add("Cupid");
        if (escort) roleslist.Add("Escort");
        if (gwag) roleslist.Add("Gwag");
        if (investigator) roleslist.Add("Investigator");
        if (jailor) roleslist.Add("Jailor");
        if (lookout) roleslist.Add("Lookout");
        if (marshall) roleslist.Add("Marshall");
        if (martialArtist) roleslist.Add("Martial Artist");
        if (masonLeader) roleslist.Add("Mason Leader");
        if (mason > 0) 
        {
            for (int i = 0; i < mason; i++)
                roleslist.Add("Mason");
        }
        if (sheriff) roleslist.Add("Sheriff");
        if (undercoverCop) roleslist.Add("Undercover Cop");
        if (veteran) roleslist.Add("Veteran");
        if (vigilante) roleslist.Add("Vigilante");

        // Mafia Roles
        if (agent) roleslist.Add("Agent");
        if (beguiler) roleslist.Add("Beguiler");
        if (blackmailer) roleslist.Add("Blackmailer");
        if (consort) roleslist.Add("Consort");
        if (framer) roleslist.Add("Framer");
        if (godfather) roleslist.Add("Godfather");
        if (kidnapper) roleslist.Add("Kidnapper");
        if (madeMan) roleslist.Add("Made Man");
        if (mafioso > 0) 
        {
            for (int i = 0; i < mafioso; i++)
                roleslist.Add("Mafioso");
        }
        if (mobWife) roleslist.Add("Mob Wife");

        // Triad Roles
        if (administrator) roleslist.Add("Administrator");
        if (deceiver) roleslist.Add("Deceiver");
        if (dragonHead) roleslist.Add("Dragon Head");
        if (enforcer > 0) 
        {
            for (int i = 0; i < enforcer; i++)
                roleslist.Add("Enforcer");
        }
        if (forger) roleslist.Add("Forger");
        if (interrogator) roleslist.Add("Interrogator");
        if (initiator) roleslist.Add("Initiator");
        if (liason) roleslist.Add("Liason");
        if (silencer) roleslist.Add("Silencer");
        if (vanguard) roleslist.Add("Vanguard");

        // Cult Roles
        if (acolyte) roleslist.Add("Acolyte");
        if (cultist > 0) 
        {
            for (int i = 0; i < cultist; i++)
                roleslist.Add("Cultist");
        }
        if (witchDoctor) roleslist.Add("Witch Doctor");

        // Independent Roles
        if (amnesiac) roleslist.Add("Amnesiac");
        if (arsonist) roleslist.Add("Arsonist");
        if (elector) roleslist.Add("Elector");
        if (electromaniac) roleslist.Add("Electromaniac");
        if (executioner) roleslist.Add("Executioner");
        if (jester) roleslist.Add("Jester");
        if (massMurderer) roleslist.Add("Mass Murderer");
        if (serialKiller) roleslist.Add("Serial Killer");
        if (survivor) roleslist.Add("Survivor");

        int j = population - roleslist.Count;
        for (int i = 0; i < j; ++i)
            roleslist.Add("Townsman");
    }

    public void AddPlayer(string name, int num)
    {
        string role = "";
        if (roleslist.Count == 0)
        {
            role = "Townsman";
        }

        int index = UnityEngine.Random.Range(0, roleslist.Count);
        role = roleslist[index];
        roleslist.RemoveAt(index);

        Player player = new Player(name, num, role);
        players.Add(name, player);
    }
}
