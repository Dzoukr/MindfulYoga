module MindfulYoga.Client.SriLanka2020.View

open Fulma
open Fable.React
open Fable.React.Props
open MindfulYoga.Client
open SharedViews

let withBr txt =
    [
        str txt
        br []
    ] |> span []
    
let inP txt = p [] [ str txt ]

let view =
    div [ Class "srilanka2020"] [
        emptySection
        textSection [
            h1 [] [ str "MINDFUL YOGA RETREAT SRÍ LANKA 2020"]
            h2 [] [ str "12. – 22.3. 2020" ]
            inP "Srdečně Vás zvu na Srí Lanku, do míst, kde jsem strávila tento rok na jaře krásný čas."
            inP "Srí Lanka se pyšní označením Zelená perla Indického oceánu. Pro české cestovatele Zikmunda a Hanzelku se stala jedním z nejatraktivnější míst naší planety, a i já jsem si ji zamilovala."
            inP "Na Srí Lance naleznete nádhernou flóru i faunu tropického pásma, úchvatné pobřeží, čajové plantáže, prastaré chrámy chráněné UNESCO a národní přírodní parky, které se hemží zvířaty, včetně slonů, opic a jedné z největších populací leopardů na světě."
            inP "Srílančané jsou stále usměvaví, otevření a dobrosrdeční lidé."
            inP "Těšit se můžeme na pobyt na jihozápadním pobřeží Srí Lanky, v živém městečku Hikkaduwa."
            inP "V Hikkaduwě je řada výborných restaurací s místní i světovou kuchyní, spousta příjemných kavárniček a obchůdků s pouličním uměním, tropickým ovocem a místními výrobky. V každé restauraci se za málo peněz skvěle najíte a pochutnáte si na úžasném smoothie z čerstvého ovoce. Na břehu oceánu naleznete chovnou stanici mořských želv."
            
            h2 [] [ str "Ubytování:" ]
            
            inP "Čeká nás příjemné ubytování v malém rodinném penzionu s krásnou zahradou, čistými, pěkně zařízenými pokoji s vlastním sociálním zařízením."
            inP "Ubytování 9 nocí se snídaní (poslední noc se odjíždí na letiště), odlétáme ve čtvrtek a do Prahy přilétáme zpět další neděli."
            inP "Dvoulůžkové pokoje s terasou v přízemí nebo v patře s balkónem."
            
            p [] [
                [
                    "Pravidelný úklid s výměnou lůžkovin a ručníků"
                    "Wifi připojení"
                    "Bazén, u kterého můžete celý den relaxovat."
                    "Penzion má vlastní restauraci, která slouží pro hosty a vaří jak srílanskou kuchyni, tak i švýcarské speciality. Majitelka penzionu je Švýcarka, která se přestěhovala na Srí Lanku před mnoha lety a Srí Lanka ji natolik učarovala, že se rozhodla zůstat."
                    "V ceně doprava z a na letiště"
                    "Součástí areálu je shala na praxi jógy"
                ] |> inList |> List.singleton |> div []
            ]
        ]
        section [ Class "display-grid"; Style [ MarginBottom -10 ]] [
            img [ Src "../img/sl_strip_1.png" ]
        ]
        textSection [
            h2 [] [ str "Jógový program"]
            [
                "Cca 16 lekcí mindful yogy®, meditací, dechových technik a relaxace (ráno před snídaní a v podvečer)"
                "Přesný rozvrh doladíme na místě podle naplánovaných výletů"
                "Dynamika lekcí se bude odvíjet podle aktuálního naladění a rozpoložení skupiny (hatha flow, jemná jóga, zdravá záda, jin jóga)"   
            ] |> inList |> List.singleton |> div []
            
            h2 [] [ str "Pláže" ]
            [
                "Popíjet čerstvé kokosy budeme nejčastěji na pláži Narigama, jedné z krásných pláží ostrova vzdálené asi 300 m od penzionu. Podél pláže jsou restaurace a bary, kde si můžete vychutnat svůj oblíbený drink s výhledem na oceán."
                "V okolí je řada dalších úžasných pláží s tyrkysovým mořem s krystalicky čistou vodou, další v docházkové vzdálenosti máme Hikkaduwa beach, ale jet prozkoumat tuk-tukem můžeme i další pláže, okouzlující a mou srdcovou Bentotu beach, na které můžeme být úplně sami nebo na jihu Mirissu beach, kolem které proplouvají velryby. Výlet na utajenou Jungle Beach můžeme spojit s návštěvou nedalekého skalního budhistického chrámu a zameditovat si v místech s neuvěřitelnou atmosférou."
                "Celý jih Srí Lanky je jedna dlouhá nádherná pláž, kde můžete odpočívat, koupat se, šnorchlovat nebo se naučit surfovat, záleží jen na Vás. 🙂"
            ] |> inList |> List.singleton |> div []
        ]    
        section [ Class "display-grid"; Style [ MarginBottom -10 ]] [
            img [ Src "../img/sl_strip_2.png"; Style [ Width "100%" ] ]
        ]    
        textSection [    
            h2 [] [ str "Výlety" ]
            [
                """Jednodenní výlet do města Galle, které je právem považováno za nejkrásnější město Srí Lanky. Nejznámější je zhruba 300 let stará pevnost zařazená na seznam
                světového kulturního a přírodního dědictví UNESCO, která je opravdu krásnou ukázkou
                koloniální architektury. V uličkách starého města naleznete řadu zajímavých
                obchůdku a restaurací."""
                
                "Safari v národním parku Uda Walawe nebo v národním parku Yala. Srí Lanka byla vyhlášená destinací číslo 1 (kromě Afriky), kam jet na safari."
                """Pozorování velryb. Jižní Srí Lanka nabízí pravděpodobně nejlepší místo na světě, kde je možné spatřit plout velryby společně s delfíny.
                Plejtváka obrovského nebo jeho příbuzného vorvaně obrovského je možné pozorovat kolem měst Mirrisa a Galle."""
                
                """Na dvoudenní výlet můžete vyrazit do vnitrozemí mezi čajové plantáže do městečka
                Ella nacházející se tisíc metrů nad mořem a vylézt na horu Little Adam’s Peak, odkud
                jsou tak úžasné výhledy, že se Vám tají dech. Nebo se můžete vypravit do královského
                města Kandy a navštívit posvátný Chrám Budhova zubu."""

                """Nebo můžeme vyrazit na nákupy do vedlejšího města. Srílanské ženy nosí pouze
                sukně, a tak nakupování s místními v obchodním domě, který praská ve švech
                nepřeberným množstvím pěkných sukní, kdy jedna stojí cca 100 Kč, může také
                leckterou ženu zaujmout. 🙂"""
                
                "Všechny výlety Vám ráda pomůžu na místě zařídit. Na Srí Lance je toho opravdu hodně, co stojí za to vidět a zažít."
            ] |> inList |> List.singleton |> div []
        ]
        section [ Class "display-grid"; Style [ MarginBottom -10 ]] [
            img [ Src "../img/sl_strip_3.png" ]
        ]
        textSection [
            inP "Cena 14 900 Kč za ubytování se snídaní, jógovou a meditační praxi, organizaci."
            inP "Omezená kapacita 12 lidí!"
            inP """Cena nezahrnuje letenku, pojištění a poplatek za vízum. Se vším Vám v případě zájmu pomůže Iva Jonášová z CK Nabosotours.
                U ní si můžete svůj zájezd od pondělí 30. 9. zarezervovat."""
            inP "Neváhejte se na cokoliv ptát. Své dotazy směřujte prosím buď na mě (777 835 160, jana@mindfulyoga.cz) nebo na Ivu Jonášovou (774 128 513, ivaj@nabosotours.cz)."
        ]
    ]