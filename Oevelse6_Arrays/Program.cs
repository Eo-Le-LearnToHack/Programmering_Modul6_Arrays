// See https://aka.ms/new-console-template for more information

/*Opgave 6.1
Lav et program med et array, som indeholder navnene på tre typer smørrebrød. 
Programmet skal derefter udskrive liste over smørrebrød.
Se vejledende løsning til 6.1 her.
https://cphbusiness.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=c4f1e4e4-51d0-47bd-a5c9-ade200cd1d11
*/

//using System;
//start:
//Console.Clear();
//Console.WriteLine("Løsning til Opgave 6.1: 'Array_Smørrebrød ForeachLoop'");
//Console.WriteLine("");
//string[] smørrebrød = new string[3] { "Smørrebrød med flæskesteg", "Smørrebrød med roastbeef", "Smørrebrød med rejer" };
//foreach (string vare in smørrebrød)
//{
//    Console.WriteLine($"{vare}");
//}
//Console.WriteLine("");
//Console.WriteLine("Tryk på ENTER for at prøve igen.");
//Console.ReadLine();
//goto start;

//using System;
//start:
//Console.Clear();
//Console.WriteLine("Løsning til Opgave 6.1: 'Array_Smørrebrød ForLoop'");
//Console.WriteLine("");
//string[] smørrebrød = new string[3] { "Smørrebrød med flæskesteg", "Smørrebrød med roastbeef", "Smørrebrød med rejer" };
//for (int tal = 1; tal < 4; tal++)
//{
//    //smørrebrød[tal -1] fordi det indexnummer = 0
//    Console.WriteLine($"Varenr. {tal}: {smørrebrød[ tal -1 ]}");
//}
//Console.WriteLine("");
//Console.WriteLine("Tryk på ENTER for at prøve igen.");
//Console.ReadLine();
//goto start;


/*Opgave 6.2
Lav et program som indeholder tallene fra den seneste lottotrækning. 
https://danskespil.dk/lotto/vindertal
Programmet skal derefter udskrive dem. Bemærk, at der er forskel på vindertal og tillægstal.
💡 Det ville være mere værdifuldt med et program, som kunne udskrive tallene fra næste uges lottotrækning.
Se vejledende løsning til 6.2 her.
https://cphbusiness.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=7b4b27a5-b3d7-41ee-88d2-ade200cd1b9c
*/

//using System;
//start:
//Console.Clear();
//Console.WriteLine("Løsning til Opgave 6.2: 'Array_Lottotal ForeachLoop'");
//Console.WriteLine("");
//int[] lottoTalUge16 = new int[] {1, 3, 6, 16, 24, 25, 26};
//const int lottoTalUge16Tillægstal = 30;
//Console.WriteLine("Lotto vindertal uge 16");
//foreach (int lottotal in lottoTalUge16)
//{
//    Console.Write(lottotal + " ");
//}
//Console.WriteLine("");
//Console.WriteLine("");
//Console.WriteLine("Lotto tillægstal uge 16");
//Console.Write(lottoTalUge16Tillægstal);
//Console.WriteLine("");
//Console.WriteLine("");
//Console.WriteLine("Tryk på ENTER for at prøve igen.");
//Console.ReadLine();
//goto start;


/*Opgave 6.3
Lav et program, hvor brugeren kan indtaste de tre ting, han synes bedst om. 
Programmet skal derefter udskrive dem på en liste med tallene 1 2 og 3 for an.
Se vejledende løsning til 6.3 her.
https://cphbusiness.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=4f6e5f42-6760-4d0c-88b3-ade200cd19a0
*/


/*Opgave 6.4
Lav et program, hvor brugeren kan indtaste tre ting, han gerne vil have i en salat. 
Programmet skal derefter udskrive dem i modsat rækkefølge, så den ting, brugeren skrev sidst, bliver udskrevet først.
Se vejledende løsning til 6.4 her.
https://cphbusiness.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=1a45ecb7-a910-4406-903e-ade200cd159b
*/

/*Opgave 6.5
Lav et program, hvor brugeren kan indtaste navnene på tre venner. 
Når brugeren har indtastet det, skal programmet tjekke om dit navn er i listen. 
Hvis det er det, skal det skrive Godt du huskede mig.

🤔 Det er overraskende meget sværere at få programmet til at skrive en besked, 
hvis dit navn ikke er blandt de indtastede. Kan du forestille dig, hvordan det skal gøres?
Se vejledende løsning til 6.5 her.
https://cphbusiness.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=a3c6bb44-4571-4476-bf32-ade200cd15bd
*/

/*Opgave 6.6
Lav et program, hvor brugeren kan indtaste tre varer og deres pris. 
Programmet skal derefter udskrive en prisliste.

💡 Du skal bruge to arrays til at løse denne opgave

🤔 Det er svært at holde styr på mange oplysninger i mange forskellige arrays, 
og heldigvis findes der bedre måder at gøre det på - dem støder du på senere i faget.

Se vejledende løsning til 6.6 her.
https://cphbusiness.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=4a9303f4-8de4-4206-bcc1-ade200cd15e6
*/

/*Opgave 6.7
Lav et program, hvor brugeren kan indtaste 5 tal. 
Programmet skal derefter udskrive de tal, der er større end 10.

🤔 Virker dit program også, hvis brugeren indtaster decimaltal?

Se vejledende løsning til 6.7 her.
https://cphbusiness.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=3457c036-f905-4b13-b59b-ade200cd162e
*/

/*Opgave 6.8
Lav et program, hvor brugeren kan indtaste en huskeliste. 
Først skal programmet spørge brugeren hvor mange ting, han vil have på listen. 
Derefter skal brugeren bedes indtaste lige så mange ting, og til sidst skal programmet udskrive huskelisten.

Se vejledende løsning til 6.8 her.
https://cphbusiness.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=716ae9e8-bd0e-4504-8cec-ade200cd23ee
*/

/*Opgave 6.9
Lav et program, hvor brugeren kan indtaste 5 tal. 
Programmet skal derefter udskrive, hvor mange tal der er mindre end 5. 
Programmet skal altså ikke udskrive tallene, men kun hvor mange tal der er mindre end 5.

🤔 Har du tænkt over, at brugeren også kan indtaste decimaltal?

Se vejledende løsning til 6.9 her.
https://cphbusiness.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=36050200-9622-41ef-b110-ade200cd1e30
*/

/*Opgave 6.10
Lav et program, hvor brugeren kan indtaste 5 ord. 
Programmet skal derefter udskrive de ord, der har præcis 4 tegn i sig.

💡 Du kan bruge Length til at finde ud af, hvor lang en tekst er.
Se vejledende løsning til 6.10 her.
https://cphbusiness.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=9e944d05-39ae-4703-8ff2-ade200cd21a4
*/

/*Find 5 fejl om arrays
En undersøgelse viser, at softwareudviklere bruger mere tid på at teste og rette fejl end på at skrive ny kode.

Derfor skal du naturligvis også træne den kompetence, mens du er i gang med at lære at programmere.

Jeg håber, du laver en masse fejl i dine programmer, så du bliver trænet i at finde og løse dem.

Derudover har jeg lavet et stykke kode til dig, som både indeholder nogle syntaktiske fejl og nogle semantiske fejl.

Jeg har lavet 5 fejl i alt - men én fejl kan godt føre til, at flere andre ting også fejler, så det kan godt føles som om, du retter flere fejl end 5.

Opgaven er løst, når programmet opfører sig som beskrevet.

Start med at kopiere koden herunder over i et nyt projekt i Visual Studio. Ret så de syntaktiske fejl, så du kan køre programmet, og om der er mere galt.

// Programmet skal bede brugeren indtaste hvor mange tal, han vil have
// i sit array. Derefter fyldes arrayet med tal fra 0 og op, indtil det
// ønskede antal er opnået.

// Herefter skal programmet udskrive tallene i arrayet i baglæns rækkefølge

Console.WriteLine("Hvor mange tal vil du have?");
int antal = Convert.ToInt32(Console.ReadLine());

int[] tal = new int[antal];
for (int i = 0; i <= tal.Length(); i++)
{
    antal[i] = i;
}

for (int i = tal.Length; i > 0; i--)
{
    Console.WriteLine(tal[i]);
}
*/

