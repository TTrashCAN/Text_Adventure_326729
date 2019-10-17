using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAdventure : MonoBehaviour
{
    [SerializeField] AudioSource fail, terminalsound;
    //Dit zijn de states die gebruikt worden in de game. Sommige zijn death's andere weer eindes. Ook zijn er keuzes dat staat bij de state zelf.
    private enum States
    {
        StartIntro,
        KeuzeJaOfNee,
        Ja,
        NeeIsEinde,
        Langzaam,
        LangzaamPraten,
        LangzaamNeerschieten,
        LangzaamDeurHacken,
        LangzaamOpblazen,
        LangzaamRiool,
        LangzaamRijWeg,
        Snel,
        SnelKalmeer,
        SnelSchiet,
        SnelInslaan,
        SnelOpblazen,
        Reset,
    }

    //Ik heb een currentState aangemaakt omdat mijn docent dat verteld heeft.
    private States currentState = States.StartIntro;
    // Start is called before the first frame update
    void Start()
    {
       ShowMainMenu();
    }

    void ShowMainMenu()
    {
    Terminal.ClearScreen();
    Terminal.WriteLine("Welkom Bij RhabDaBank!");
    Terminal.WriteLine("Typ start om te beginnen.");
    terminalsound.Play();
    currentState = States.StartIntro;
    }
    //Update is called once per frame
    void Update()
    {
        
    }

    void OnUserInput(string input)
    {
        switch (currentState)
        {
          case States.StartIntro:
          {
            if (input == "start")
            {
                    StartIntro();
            }
            else if (input == "18022003")
            {
                    Terminal.WriteLine("Hey je hebt me gevonden! Ik ben de maker van de game. Best raar dat je mijn geboorte datum kent.");
            }
            else if (input == "Rhabby_V")
            {
                    Terminal.WriteLine("I'm going to discard my Hawkmoon.");
            }
            else if (input == "TTrashCAN-")
            {
                    Terminal.WriteLine("Daar ben ik weer! HOE WEET JE MIJN GAMERTAG?! Jij ekte top lan lmao.");
            }
            else
            {
                    Terminal.WriteLine("Je moet op start typen of anders je hoofd dan.");
            }
          }
          break;

          case States.KeuzeJaOfNee:
          {
            if (input == "verder")
            {
                    KeuzeJaOfNee();
            }
          }
          break;

          case States.NeeIsEinde:
          {
            if (input == "nee" || input == "Nee")
            {
                    NeeIsEinde();
            }
            else if (input == "ja" || input == "Ja")
            {
                    Ja();
            }
            else
            {
                    Terminal.WriteLine("Typ ja of nee alsjeblieft.");
            }
          }
          break;

          case States.Langzaam:
          {
            if (input == "langzaam" || input == "Langzaam")
            {
                    Langzaam();
            }
            else if (input == "snel" || input == "Snel")
            {
                    Snel();
            }
            else
            {
                    Terminal.WriteLine("Je moet langzaam of snel typen.");
            }
          }
          break;

          case States.SnelKalmeer:
          {
            if (input == "schiet" || input == "Schiet")
            {
                    SnelSchiet();
            }
            else if (input == "kalmeer" || input == "Kalmeer")
            {
                    SnelKalmeer();
            }
            else
            {
                    Terminal.WriteLine("Je moet kalmeer of schiet typen.");
            }
          }
          break;

          case States.LangzaamPraten:
          {
            if (input == "praten" || input == "Praten")
            {
                LangzaamPraten();
            }
            else if (input == "neerschieten" || input == "Neerschieten")
            {
                LangzaamNeerschieten();
            }
            else
            {
                Terminal.WriteLine("Je moet praten of neerschieten typen.");
            }
          }
          break;

          case States.LangzaamDeurHacken:
          {
            if (input == "hacken" || input == "Hacken")
            {
                    LangzaamDeurHacken();
            }
            else if (input == "opblazen" || input == "Opblazen")
            {
                    LangzaamOpblazen();
            }
            else
            {
                    Terminal.WriteLine("Je moet hacken of opblazen typen.");
            }
          }
          break;

          case States.SnelInslaan:
          {
            if (input == "inslaan" || input == "Inslaan")
            {
                    SnelInslaan();
            }
            else if (input == "opblazen" || input == "Opblazen")
            {
                    SnelOpblazen();
            }
            else
            {
                    Terminal.WriteLine("Je moet inslaan of opblazen typen.");
            }
          }
          break;

          case States.LangzaamRiool:
          {
            if (input == "riool" || input == "Riool")
            {
                    LangzaamRiool();
            }
            else if (input == "steel" || input == "Steel")
            {
                    LangzaamRijWeg();
            }
            else
            {
                    Terminal.WriteLine("Typ: terug naar binnen en via het riool. Of typ: Steel zo snel mogelijk een auto en rij weg.");
            }
          }
          break;


          default:
          {
            if (input == "reset" || input == "Reset");
                Reset();
          }
          break;
        }
    }

    //Dit is de intro van de game.
    void StartIntro()
    {
        currentState = States.StartIntro;
        Terminal.ClearScreen();
        Terminal.WriteLine("Je naam is Rob Smith.");
        Terminal.WriteLine("Je hebt in je verleden veel fouten gemaakt. Op die manier ben je je vrouw en zoon verloren. Ook ben je financieel niet meer stabiel.");
        Terminal.WriteLine("Je bent dakloos. Later besloot een vriend van je dat je bij hem mag wonen in Los Angeles.");
        Terminal.WriteLine("Je bent heel erg ongelukkig. Je weet niet wat je moet doen met je leven.");
        Terminal.WriteLine("Je vriend genaamd Price McTavish probeert je te stimuleren en een baan te zoeken.");
        Terminal.WriteLine("Price bevriend met een criminele groep genaamd: The Scorn. Daar kwam je pas geleden achter. Je vraagt je af waarom hij daarmee bevriend is.");
        Terminal.WriteLine("Na een paar maanden vroegen The Scorn jou en Price voor een bankoverval. Je hebt de keuze om ja of nee te zeggen.");
        Terminal.WriteLine("Je maakt die keuze door de woorden en zinnen te typen die aangegeven worden.");
        Terminal.WriteLine("Ja en nee lijden je naar verschillende eindes.");
        Terminal.WriteLine("Typ verder om verder te gaan.");
        currentState = States.KeuzeJaOfNee;
    }

    //Keuze, hier maak je de grote keuze. Of je gaat verder met het verhaal of je wordt naar een einde geleid.
    void KeuzeJaOfNee()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je krijgt de vraag of je met The Scorn een bank wilt overvallen.");
        Terminal.WriteLine("Je hebt nu de keuze om ja of nee te zeggen.");
        currentState = States.NeeIsEinde;
    }

    //Keuze/Einde, je hebt voor nee gekozen. Goed einde je bent geen crimineel en gaat studeren.
    void NeeIsEinde()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Goed gedaan! Je bent geen idioot! Rob weigert om de klus te doen.");
        Terminal.WriteLine("Rob werkt eerst voor 5 jaar bij een supermarkt, vervolgens doet hij een opleiding ICT en na 10 jaar is hij 1 van de grootste programmeurs van Amerika!");
        Terminal.WriteLine("Typ reset om naar het begin te gaan.");
        currentState = States.Reset;
    }

    //Keuze, je hebt voor ja gekozen. Je gaat door met het verhaal.
    void Ja()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Mooi! Je kan nu echt beginnen! De crew met wie je de bank gaat overvallen stellen twee dingen voor:");
        Terminal.WriteLine("Een Rustige en langzame overval of een snelle en geweldadige overval.");
        Terminal.WriteLine("Uiteindelijk moet jij kiezen. Maak je keuze door langzaam of snel te typen.");
        currentState = States.Langzaam;
    }

    //Keuze, je hebt voor langzaam gekozen. Je gaat nu verder met het langzaam verhaal. Je moet hier ook een keuze maken tussen praten of neerschiet.
    void Langzaam()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je gaat een dag later met Price en 4 andere crew members naar binnen via de medewerker ingang en je schakelt een bewaker rustig uit.");
        Terminal.WriteLine("Maar er komt een andere bewaker aan met een geweer wat doe je?");
        Terminal.WriteLine("Typ praten of neerschieten.");
        currentState = States.LangzaamPraten;
    }

    //Hier ga je dood, omdat je niet zo slim bent.
    void LangzaamPraten()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je praat met de bewaker en zegt dat als hij mee helpt met de overval dat hij 10% krijgt van het geld.");
        Terminal.WriteLine("De bewaker twijfelt geen moment en schiet je neer, want praten was een dom idee. Hoe dom ben jij?");
        Terminal.WriteLine("Game Over jij domme speler...");
        Terminal.WriteLine("Typ reset om naar het begin te gaan.");
        terminalsound.Pause();
        fail.Play();
        currentState = States.LangzaamNeerschieten;
    }

    //Keuze, je moet hier kizen tussen hacken en opblazen.
    void LangzaamNeerschieten()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je schiet de bewaker neer met een demper op je wapen. Gelukkig heeft niemand je gehoord.");
        Terminal.WriteLine("In de bank zijn geen klanten en de medewerkers hebben pauze. Ze hebben niks door.");
        Terminal.WriteLine("Nu proberen jullie zo rustig mogelijk de deur te openen om naar de kluis te kunnen. Je moet kiezen tussen hacken of opblazen.");
        Terminal.WriteLine("Typ hacken of opblazen.");
        currentState = States.LangzaamDeurHacken;
    }

    //Hier ga je dood, je hebt gewoon teveel ongeluk.
    void LangzaamDeurHacken()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je probeert de deur te hacken. Het lukt! Alleen... er staan 5 bewakers die je neerschieten.");
        Terminal.WriteLine("Dat was onverwachts! Game Over...");
        Terminal.WriteLine("Typ reset om naar het begin te gaan.");
        terminalsound.Pause();
        fail.Play();
        currentState = States.Reset;
    }

    //Keuze, je moet hier kiezen tussen het riool of een auto stelen. Beide leiden naar goede eindes.
    void LangzaamOpblazen()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je blaast de deur op. Het lukt! Je hebt 5 bewakers erbij opgeblazen! Nu kan je snel naar de kluis lopen met je team.");
        Terminal.WriteLine("Je pakt het geld en rent vervolgens via de hoofdingang naar buiten. De politie was al geïnformeerd. Ze staan buiten. Wat doe je nu?");
        Terminal.WriteLine("Je moet nu kiezen om terug te gaan en via het riool te vluchten of je steelt zo snel mogelijk een auto en vlucht.");
        Terminal.WriteLine("Typ riool of steel");
        currentState = States.LangzaamRiool;
    }

    //Goed einde, je wordt een normale burger. Je zet alles weer recht en bent weer samen met je vrouw en kind.
    void LangzaamRiool()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je vlucht met je team het riool in via een put die blijkbaar in de bank is. De agenten achtervolgen je. Je slaat de hoek om en ziet een alligator.");
        Terminal.WriteLine("Hij probeert je aan te vallen.");
        Terminal.WriteLine("Je rent met je team terug op de politie af. De alligator zit nu achter de politie aan.");
        Terminal.WriteLine("Net wanneer een agent de alligator wou schieten greep het grote reptiel hem al. Jullie konden zo ontsnappen.");
        Terminal.WriteLine("Na een paar uur komen jullie bij een verlaten metro spoor. Daar staan auto's. Jullie laden het geld in en gaan 1 voor 1 naar buiten.");
        Terminal.WriteLine("Het is je gelukt! Je bent nu een echt sluwe meester crimineel, maar Rob besloot na deze klus zijn leven recht te zetten.");
        Terminal.WriteLine("Na een paar jaar is hij weer gelukkig met zijn vrouw en zoon.");
        Terminal.WriteLine("Typ reset om naar het begin te gaan.");
        currentState = States.LangzaamRijWeg;
    }

    //Goed einde, je wordt hier een meester crimineel.
    void LangzaamRijWeg()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Jullie rennen en schieten. Jullie proberen een politiewagen te stelen. Het lukt! Jullie laden in, maar jullie horen een helikopter aankomen!");
        Terminal.WriteLine("Het geluid van de sirenes wordt luider en luider. Jullie rijden zo snel mogelijk weg.");
        Terminal.WriteLine("Na uren en uren wegrijden rennen jullie in Washington de auto uit in een steegje. Daar stond de vluchtauto klaar.");
        Terminal.WriteLine("Jullie rijden terug naar Los Angeles naar een verlaten gebouw. Daar delen jullie het geld.");
        Terminal.WriteLine("Je bent nu een moordlustige meester crimineel!");
        Terminal.WriteLine("Rob doet in de toekomst veel meer klussen en runt nu 1 van de grootste criminele organisaties van Amerika!");
        Terminal.WriteLine("Typ reset om naar het begin te gaan.");
        currentState = States.Reset;
    }

    //Keuze, je hebt voor snel gekozen. Je gaat nu verder met het snel verhaal. Je moet hier ook een keuze maken tussen kalmeer of schiet.
    void Snel()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je gaat nu met Price en 6 andere crew members naar binnen via de hoofdingang en maakt hem op slot met wat tie rips.");
        Terminal.WriteLine("Vervolgens pakken de meesten allemaal een AK47 en zet iedereen behalve jij een masker op.");
        Terminal.WriteLine("Jij loopt naar de toonbank. De man achter de toonbank vraagt: 'Welkom waar kan ik u meehelpen? Mag ik eerst uw naam weten?'");
        Terminal.WriteLine("Jij antwoord met: 'Ik kom hier voor een klusje en mijn naam is Rhab DaBank.'");
        Terminal.WriteLine("De man schreeuwt: 'UW NAAM IS ROB THE BANK?!'");
        Terminal.WriteLine("Toen rende de crew leden naar binnen en schoten de medewerkers dood.");
        Terminal.WriteLine("Je pakt je AK47 en zet je masker op.");
        Terminal.WriteLine("Een vrouw raakt zo gestresst dat ze probeert weg te rennen. Wat doe je?");
        Terminal.WriteLine("Haar neerschieten of kalmeren. Typ kalmeer of schiet.");
        currentState = States.SnelKalmeer;
    }

    //Keuze, je moet hier kiezen tussen inslaan of opblazen.
    void SnelKalmeer()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je kalmeert de vrouw en zegt dat je niet van plan bent haar wat aan te doen en brengt haar rustig terug naar haar man en kind.");
        Terminal.WriteLine("Nu kun je verder met de stalen deur open te breken met 3 anderen mensen.");
        Terminal.WriteLine("Price en de andere 3 houden de gijzelaars bang voordat ze wat proberen.");
        Terminal.WriteLine("Hoe ga je deur openen? Typ Deur inslaan of opblazen.");
        currentState = States.SnelInslaan;
    }

    //Hier ga je dood, omdat de man van de vrouw een wapen trekt.
    void SnelSchiet()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je schiet de vrouw neer. Haar man trekt zelf een wapen en schiet jou vervolgens dood.");
        Terminal.WriteLine("Game Over...");
        Terminal.WriteLine("Typ reset om naar het begin te gaan.");
        terminalsound.Pause();
        fail.Play();
        currentState = States.Reset;
    }

    //Goed einde, je word na de klus een normale burger.
    void SnelInslaan()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je slaat de deur in. Alleen het lukt niet. Je hele team slaat de deur in. Dat lukte wel. Nu rennen jullie allemaal naar de kluis en blazen hem op.");
        Terminal.WriteLine("Jullie pakken het geld en rennen naar buiten. De agenten openen vuur. Jullie schieten ze neer en stelen een politie auto.");
        Terminal.WriteLine("Jullie rijden een verlaten metroweg in. Daar staan verschillende auto's. Jullie laden het geld in en rijden na een uur naar buiten.");
        Terminal.WriteLine("Bij een verlaten gebouw delen jullie het geld.");
        Terminal.WriteLine("Je hebt het gehaald! Je bent nu weer financieel stabiel! Je zoekt een baan om extra bij te verdienen. Je bent weer een normale burger!");
        Terminal.WriteLine("Typ reset om naar het begin te gaan.");
        currentState = States.SnelOpblazen;
    }

    //Hier ga je dood, omdat je je team laat opblazen.
    void SnelOpblazen()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je plaats de bom. Alleen je bent zo dom dat je in plaats van 1 minuut op 1 seconden hebt ingesteld.");
        Terminal.WriteLine("Je blaast jezelf op en hele team op. Je IQ is verlaagd naar 0.");
        Terminal.WriteLine("Game Over...");
        Terminal.WriteLine("Typ reset om naar het begin te gaan.");
        terminalsound.Pause();
        fail.Play();
        currentState = States.Reset;
    }

    //Zo ga je terug naar het hoofdmenu.
    void Reset()
    {
        ShowMainMenu();
    }
}

