using UnityEngine;
using UnityEngine.UI;

public class InfoController : MonoBehaviour
{
    //All Info
    public GameInfo gameInfo;

    //TownName Info
    public GameObject townError;
    public TMPro.TMP_InputField townNameInput;
    public GameObject townPanel;

    //Population Info
    public GameObject populationPanel;
    public TMPro.TMP_Text populationText;
    public GameObject moreError;
    public GameObject formatError;

    //Roles Info
    public GameObject rolesPanel;
    public GameObject rolesLess;
    public GameObject rolesMore;
    public GameObject continueButton;
    public GameObject townRoles;
    public GameObject mafiaRoles;
    public GameObject triadRoles;
    public GameObject cultRoles;
    public GameObject independentRoles;

    //Town Roles Selections
    public TMPro.TMP_InputField AngelsInput;
    public Toggle bodyguardToggle;
    public Toggle brideToggle;
    public Toggle groomToggle;
    public Toggle busDriverToggle;
    public Toggle crierToggle;
    public Toggle cupidToggle;
    public Toggle escortToggle;
    public Toggle gwagToggle;
    public Toggle investigatorToggle;
    public Toggle jailorToggle;
    public Toggle lookoutToggle;
    public Toggle marshallToggle;
    public Toggle martialArtistToggle;
    public Toggle masonLeaderToggle;
    public TMPro.TMP_InputField masonInput;
    public Toggle sheriffToggle;
    public Toggle undercoverCopToggle;
    public Toggle veteranToggle;
    public Toggle vigilanteToggle;

    //Mafia Roles Selections
    public Toggle agentToggle;
    public Toggle beguilerToggle;
    public Toggle blackmailerToggle;
    public Toggle consortToggle;
    public Toggle framerToggle;
    public Toggle godfatherToggle;
    public Toggle kidnapperToggle;
    public Toggle madeManToggle;
    public TMPro.TMP_InputField mafiosoInput;
    public Toggle mobWifeToggle;

    //Triad Roles Selections
    public Toggle administratorToggle;
    public Toggle deceiverToggle;
    public Toggle dragonHeadToggle;
    public TMPro.TMP_InputField enforcerInput;
    public Toggle forgerToggle;
    public Toggle interrogatorToggle;
    public Toggle initiatorToggle;
    public Toggle liasonToggle;
    public Toggle silencerToggle;
    public Toggle vanguardToggle;

    //Cult Roles Selections
    public Toggle acolyteToggle;
    public TMPro.TMP_InputField cultistInput;
    public Toggle witchDoctorToggle;

    //Independent Roles Selections
    public Toggle amnesiacToggle;
    public Toggle arsonistToggle;
    public Toggle electorToggle;
    public Toggle electromaniacToggle;
    public Toggle executionerToggle;
    public Toggle jesterToggle;
    public Toggle massMurdererToggle;
    public Toggle serialKillerToggle;
    public Toggle survivorToggle;

    //Players Info
    public GameObject playersPanel;
    public GameObject firstPanel;
    public GameObject currPlayer;
    public TMPro.TMP_Text currPlayerText;
    public TMPro.TMP_InputField playerNameInput;
    public GameObject submitButton;
    private int currPlayerNum = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //reset the gameInfo
        gameInfo.townName = "";
        gameInfo.population = 0;

        //Set Panels
        townPanel.SetActive(true);
        townError.SetActive(false);

        populationPanel.SetActive(false);
        moreError.SetActive(false);
        formatError.SetActive(false);
    }

    public void SetTownName()
    {
        gameInfo.makeTName(townNameInput.text);
    }

    public void SetPopulation()
    {
        gameInfo.makePop(populationText.text);
    }

    public void ShowTownRoles()
    {
        townRoles.SetActive(!townRoles.activeSelf);

        mafiaRoles.SetActive(false);
        triadRoles.SetActive(false);
        cultRoles.SetActive(false);
        independentRoles.SetActive(false);
    }

    public void ShowMafiaRoles()
    {
        mafiaRoles.SetActive(!mafiaRoles.activeSelf);

        townRoles.SetActive(false);
        triadRoles.SetActive(false);
        cultRoles.SetActive(false);
        independentRoles.SetActive(false);
    }

    public void ShowTriadRoles()
    {
        triadRoles.SetActive(!triadRoles.activeSelf);

        townRoles.SetActive(false);
        mafiaRoles.SetActive(false);
        cultRoles.SetActive(false);
        independentRoles.SetActive(false);
    }

    public void ShowCultRoles()
    {
        cultRoles.SetActive(!cultRoles.activeSelf);

        townRoles.SetActive(false);
        mafiaRoles.SetActive(false);
        triadRoles.SetActive(false);
        independentRoles.SetActive(false);
    }

    public void ShowIndependentRoles()
    {
        independentRoles.SetActive(!independentRoles.activeSelf);

        townRoles.SetActive(false);
        mafiaRoles.SetActive(false);
        triadRoles.SetActive(false);
        cultRoles.SetActive(false);
    }

    public void SetRoles()
    {
        //Town Roles
        gameInfo.angels = int.Parse(AngelsInput.text);
        gameInfo.bodyguard = bodyguardToggle.isOn;
        gameInfo.bride = brideToggle.isOn;
        gameInfo.groom = groomToggle.isOn;
        gameInfo.busDriver = busDriverToggle.isOn;
        gameInfo.crier = crierToggle.isOn;
        gameInfo.cupid = cupidToggle.isOn;
        gameInfo.escort = escortToggle.isOn;
        gameInfo.gwag = gwagToggle.isOn;
        gameInfo.investigator = investigatorToggle.isOn;
        gameInfo.jailor = jailorToggle.isOn;
        gameInfo.lookout = lookoutToggle.isOn;
        gameInfo.marshall = marshallToggle.isOn;
        gameInfo.martialArtist = martialArtistToggle.isOn;
        gameInfo.masonLeader = masonLeaderToggle.isOn;
        gameInfo.mason = int.Parse(masonInput.text);
        gameInfo.sheriff = sheriffToggle.isOn;
        gameInfo.undercoverCop = undercoverCopToggle.isOn;
        gameInfo.veteran = veteranToggle.isOn;
        gameInfo.vigilante = vigilanteToggle.isOn;

        //Mafia Roles
        gameInfo.agent = agentToggle.isOn;
        gameInfo.beguiler = beguilerToggle.isOn;
        gameInfo.blackmailer = blackmailerToggle.isOn;
        gameInfo.consort = consortToggle.isOn;
        gameInfo.framer = framerToggle.isOn;
        gameInfo.godfather = godfatherToggle.isOn;
        gameInfo.kidnapper = kidnapperToggle.isOn;
        gameInfo.madeMan = madeManToggle.isOn;
        gameInfo.mafioso = int.Parse(mafiosoInput.text);
        gameInfo.mobWife = mobWifeToggle.isOn;

        //Triad Roles
        gameInfo.administrator = administratorToggle.isOn;
        gameInfo.deceiver = deceiverToggle.isOn;
        gameInfo.dragonHead = dragonHeadToggle.isOn;
        gameInfo.enforcer = int.Parse(enforcerInput.text);
        gameInfo.forger = forgerToggle.isOn;
        gameInfo.interrogator = interrogatorToggle.isOn;
        gameInfo.initiator = initiatorToggle.isOn;
        gameInfo.liason = liasonToggle.isOn;
        gameInfo.silencer = silencerToggle.isOn;
        gameInfo.vanguard = vanguardToggle.isOn;

        //Cult Roles
        gameInfo.acolyte = acolyteToggle.isOn;
        gameInfo.cultist = int.Parse(cultistInput.text);
        gameInfo.witchDoctor = witchDoctorToggle.isOn;

        //Independent Roles
        gameInfo.amnesiac = amnesiacToggle.isOn;
        gameInfo.arsonist = arsonistToggle.isOn;
        gameInfo.elector = electorToggle.isOn;
        gameInfo.electromaniac = electromaniacToggle.isOn;
        gameInfo.executioner = executionerToggle.isOn;
        gameInfo.jester = jesterToggle.isOn;
        gameInfo.massMurderer = massMurdererToggle.isOn;
        gameInfo.serialKiller = serialKillerToggle.isOn;
        gameInfo.survivor = survivorToggle.isOn;

        //Count The Selected Roles
        int totalRoles = 0;
        totalRoles += gameInfo.angels;
        totalRoles += gameInfo.bodyguard ? 1 : 0;
        totalRoles += gameInfo.bride ? 1 : 0;
        totalRoles += gameInfo.groom ? 1 : 0;
        totalRoles += gameInfo.busDriver ? 1 : 0;
        totalRoles += gameInfo.crier ? 1 : 0;
        totalRoles += gameInfo.cupid ? 1 : 0;
        totalRoles += gameInfo.escort ? 1 : 0;
        totalRoles += gameInfo.gwag ? 1 : 0;
        totalRoles += gameInfo.investigator ? 1 : 0;
        totalRoles += gameInfo.jailor ? 1 : 0;
        totalRoles += gameInfo.lookout ? 1 : 0;
        totalRoles += gameInfo.marshall ? 1 : 0;
        totalRoles += gameInfo.martialArtist ? 1 : 0;
        totalRoles += gameInfo.masonLeader ? 1 : 0;
        totalRoles += gameInfo.mason;
        totalRoles += gameInfo.sheriff ? 1 : 0;
        totalRoles += gameInfo.undercoverCop ? 1 : 0;
        totalRoles += gameInfo.veteran ? 1 : 0;
        totalRoles += gameInfo.vigilante ? 1 : 0;
        totalRoles += gameInfo.agent ? 1 : 0;
        totalRoles += gameInfo.beguiler ? 1 : 0;
        totalRoles += gameInfo.blackmailer ? 1 : 0;
        totalRoles += gameInfo.consort ? 1 : 0;
        totalRoles += gameInfo.framer ? 1 : 0;
        totalRoles += gameInfo.godfather ? 1 : 0;
        totalRoles += gameInfo.kidnapper ? 1 : 0;
        totalRoles += gameInfo.madeMan ? 1 : 0;
        totalRoles += gameInfo.mafioso;
        totalRoles += gameInfo.mobWife ? 1 : 0;
        totalRoles += gameInfo.administrator ? 1 : 0;
        totalRoles += gameInfo.deceiver ? 1 : 0;
        totalRoles += gameInfo.dragonHead ? 1 : 0;
        totalRoles += gameInfo.enforcer;
        totalRoles += gameInfo.forger ? 1 : 0;
        totalRoles += gameInfo.interrogator ? 1 : 0;
        totalRoles += gameInfo.initiator ? 1 : 0;
        totalRoles += gameInfo.liason ? 1 : 0;
        totalRoles += gameInfo.silencer ? 1 : 0;
        totalRoles += gameInfo.vanguard ? 1 : 0;
        totalRoles += gameInfo.acolyte ? 1 : 0;
        totalRoles += gameInfo.cultist;
        totalRoles += gameInfo.witchDoctor ? 1 : 0;
        totalRoles += gameInfo.amnesiac ? 1 : 0;
        totalRoles += gameInfo.arsonist ? 1 : 0;
        totalRoles += gameInfo.elector ? 1 : 0;
        totalRoles += gameInfo.electromaniac ? 1 : 0;
        totalRoles += gameInfo.executioner ? 1 : 0;
        totalRoles += gameInfo.jester ? 1 : 0;
        totalRoles += gameInfo.massMurderer ? 1 : 0;
        totalRoles += gameInfo.serialKiller ? 1 : 0;
        totalRoles += gameInfo.survivor ? 1 : 0;

        //Check if the total roles is equal to the population
        if (totalRoles == gameInfo.population)
        {
            rolesPanel.SetActive(false);
            rolesLess.SetActive(false);
            rolesMore.SetActive(false);
            playersPanel.SetActive(true);

            gameInfo.makeList();
        }
        else if (totalRoles < gameInfo.population)
        {
            rolesLess.SetActive(true);
            rolesMore.SetActive(false);
            continueButton.SetActive(false);
        }
        else
        {
            rolesLess.SetActive(false);
            rolesMore.SetActive(true);
            continueButton.SetActive(true);
        }
    }

    public void ContinueAnyways()
    {
        rolesPanel.SetActive(false);
        rolesLess.SetActive(false);
        rolesMore.SetActive(false);
        playersPanel.SetActive(true);

        gameInfo.makeList();
    }

    public void NextPlayer()
    {
        gameInfo.AddPlayer(playerNameInput.text, currPlayerNum);
        playerNameInput.text = "";
        if (currPlayerNum < gameInfo.population)
        {
            firstPanel.SetActive(false);
            currPlayerNum++;
            currPlayerText.text = "Player " + currPlayerNum + " of " + gameInfo.population;
            currPlayer.SetActive(true);
        }
        else
        {
            currPlayer.SetActive(false);
            submitButton.SetActive(true);
        }
    }
}
