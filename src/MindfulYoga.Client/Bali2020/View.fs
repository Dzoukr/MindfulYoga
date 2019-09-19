module MindfulYoga.Client.Bali2020.View

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
    div [ Class "bali2020"] [
        emptySection
        textSection [
            h1 [] [ str "MINDFUL YOGA RETREAT BALI 2020"]
            inP "Srdečně Vás zvu na společnou cestu na Bali."
            inP "Bali se pyšní nádhernou flórou i faunou tropického pásma. Hory, rýžová pole a bujná vegetace činí z Bali zelenou perlu Indonésie, kterou si na první pohled zamilujete." 
            inP "Duchovní atmosféra celého ostrova vytváří přímo ráj na zemi pro zklidnění, relaxaci a odpočinek!"
            inP "Balijci jsou stále usměvaví, milí, pokorní, dobrosrdeční a spirituálně založení lidé."
            
            h2 [] [ str "Na co se můžeme těšit" ]
            p [] [
                [
                    "Krásné ubytování v Bali Mynah Villas Resortu ve čtvrti Balangan, oblast Jimbaran, poloostrov Bukit"
                    "Ubytování 11 nocí se snídaní, pravidelný úklid s výměnou lůžkovin a ručníků, pitná voda zdarma v gazebu"
                    "Dvoulůžkové a třílůžkové bungalovy s obytnou terasou s výhledem na bazén, kuchyňským koutem a jídelním stolem"
                    "Na terase i v ložnici jsou větráky, v ložnici i klimatizace"
                    "Celý areál je pokryt vysokorychlostním internetem" 
                    "Další vybavení bungalovu: sprcha, toaletní potřeby, šatna, bezpečnostní schránka, lednice, varná konvice, fén (na vyžádání), sušák na prádlo, venkovní sprcha, sluneční terasa s lehátky a slunečníkem"
                    "V ceně doprava z a na letiště"
                ] |> inList |> List.singleton |> div []
            ]
        ]
        section [ Class "display-grid"; Style [ MarginBottom -10 ]] [
            img [ Src "../img/bali-strip1.png" ]
        ]
        textSection [
            h2 [] [ str "Jógový program"]
            [
                "Cca 16 lekcí mindful yogy®, meditací, dechových technik a relaxace"
                "Přesný rozvrh doladíme na místě podle naplánovaných výletů"
                "Dynamika lekcí se bude odvíjet podle aktuálního naladění a rozpoložení skupiny (hatha flow, jemná jóga, zdravá záda, jin jóga)"
                "Ranní lekce budou probíhat v nádherné shalle v pěší vzdálenosti cca 300 m od ubytování (viz. video níže) a podvečerní lekce v zahradě resortu" 
                "Dne 25.3. proběhne na ostrově svátek Nyepi neboli Den ticha (Silence Day), který je zároveň i oslavou hinduistického Nového roku. My využijeme tuto příležitost a k tichu se přidáme. Čeká nás relaxování u bazénu, čtení knížek, meditace … a večer pozorování hvězd na obloze 😊"   
            ] |> inList |> List.singleton |> div []
            div [ DangerouslySetInnerHTML { __html = """<video controls><source src="http://mandalavillagebali.com/wp-content/uploads/2017/08/Yoga.mov" type="video/mp4"></video>""" }] [ ]
            
            h2 [] [ str "Pláže" ]
            [
                "Popíjet čerstvé kokosy budeme nejčastěji na pláži Balangan, jedné z nejkrásnějších pláží ostrova (vzdálená 3,4 km od resortu)" 
                "Bali je vyhlášené úžasnými plážemi, tyrkysovým mořem s krystalicky čistou vodou. Budu ráda, když se se mnou vydáte prozkoumat i další pláže poloostrova v rámci celodenního výletu." 
            ] |> inList |> List.singleton |> div []
        ]    
        section [ Class "display-grid"; Style [ MarginBottom -10 ]] [
            img [ Src "../img/bali-strip2.png"; Style [ Width "100%" ] ]
        ]    
        textSection [    
            h2 [] [ str "Výlety" ]
            [
                "Výlet do vnitrozemí ostrova: chrám Tirta Empul - nejposvátnější místo s léčivými prameny, majestátné hrobky Gunung Kawi - údolí královen, návštěva ikonických terasovitých rýžových polí Tegalalang"
                "Návštěva Ubudu (města z filmu Jíst, meditovat, milovat) – město mezi rýžovými políčky, které je centrem kulturního a duchovního života, Monkey Forest – opičí prales, Goa Gajah - posvátná jeskyně Ganéši, Ubud Market - návštěva obchůdků"
                "Canggu. Strávení dne v Canggu, které je oblíbené díky nejúžasnějšímu pouličnímu umění, spoustě příjemných kavárniček a rozmanité kuchyně. Navštívíme Tanah Lot Temple, který se nachází 300 metrů od pobřeží na skále v oceánu a je jedním z nejslavnějších chrámů na Bali. Je to posvátné místo a mnozí věří, že chrám chrání ostrov před zlými mořskými duchy." 
                "Uluwatu. Výlet na jednu z nejkrásnějších pláží ostrova Uluwatu, návštěva chrámu Pura Luhur Uluwatu a jako vrchol dne shlédnutí Kecak Fire Dance u chrámu při západu slunce. Kecak Dance neboli Opičí tanec je velkolepá show, která vypráví starý tradiční balijský příběh o princezně Sitě a princovi Rámovi." 
                "Jimbaran. Jimbaran je malá rybářská vesnička, prohlídneme si městečko, obchůdky, podíváme se na pláž s jemným pískem a den zakončíme večeří přímo na pláži při západu slunce." 
            ] |> inList |> List.singleton |> div []
            
            withBr "V ceně 5x za pobyt pronájem auta s řidičem na celodenní výlet. Na nás bude zaplatit si jen případné vstupy a občerstvení."
            withBr ""
            withBr "To je jen takový možný nástin strávení dní na Bali, na přesném programu se domluvíme na místě, nebo si uděláte program vlastní, můžete se také potápět, šnorchlovat, naučit se surfovat, záleží jen na Vás 😊"
        ]
        section [ Class "display-grid"; Style [ MarginBottom -10 ]] [
            img [ Src "../img/bali-strip3.png" ]
        ]
        textSection [
            h2 [] [ str "Cena nezahrnuje" ]
            [
                "Obědy a večeře. Přímo božskou indonéskou kuchyni si budeme užívat na pláži nebo v jedné z malebných restaurací poblíž resortu." 
                "Vstupy do památek" 
                "Pronájem skútru (resort se nachází 10 min od pláže, možno si zapůjčit skútr (cca 150 Kč/den) nebo využít shuttle bus resortu"
                "Balijské masáže, jacuzzi, prádelna, donáška obědů, večeří (lze objednat a zaplatit na místě), kurz vaření balijské kuchyně …"
                "Leteckou dopravu a pojištění - lze sjednat přes CK FIT"
            ] |> inList |> List.singleton |> div []
            
            h2 [] [ str "Další informace" ]
            p [] [
                withBr "Mnou doporučovaný let s Emirates:"
                [
                    "Odlet 16.3. v 15:30 s přestupem v Dubaji (1h 35min na přestup), na Bali dorazíme ve 14:50 místního času. Ubytujeme se, dojdeme si na večeři a půjdeme si lehnout, tím vyrovnáme časový posun." 
                    "Zpět 29.3. v 00:05 s přestupem v Dubaji (3h 35min na přestup), do Prahy dorazíme ve 13:00 místního času."
                ] |> inList
                withBr "Sejdeme se dvě hodiny před odletem na letišti." 
                withBr "Případně si zvolte jakýkoliv jiný let, který Vám bude vyhovovat 😊"
            ]
            
            h2 [] [ str "Cena" ]
            p [] [
                withBr "Cena 20 990 Kč."
                str "Svůj pobyt si můžete objednat zde: "
                a [ Href "https://www.ckfit.cz/bali/mindful-jogovy-retreat-v-indonesii-s-janou-provaznikovou/?ProductTypeID=1126" ] [ str "www.ckfit.cz/bali/mindful-jogovy-retreat-v-indonesii-s-janou-provaznikovou" ]
                withBr ""
                withBr "Jakékoliv dotazy směřujte prosím buď mně na tel. čísle 777 835 160 nebo přes email jana@mindfulyoga.cz, případně na Ing. Andreu Podlipskou (CK Fit) na tel. čísle 603 118 624 nebo přes email na info@ckfit.cz"
            ]

        ]
        section [ Class "display-grid"; Style [ MarginBottom -10 ]] [
            img [ Src "../img/bali-strip4.png" ]
        ]
    ]