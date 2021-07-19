module MindfulYoga.Client.AboutMe.View

open Fulma
open Feliz
open Fable.React
open Fable.React.Props
open MindfulYoga.Client
open SharedViews

let view =
    div [ Class "aboutme"] [
        emptySection
        figure [ Class "image mobile-only"] [
            img [ Src "img/aboutme_bg.jpg"]
        ]
        textSection [
            h1 [] [ str "Ing. Jana Provazníková"]
            Html.p "Ve svém dospívání jsem se viděla jako úspěšná manažerka v kostýmku. Vystudovala jsem ekonomii a vrhla se do zaměstnání. Říká se, dej si pozor, co si přeješ, mohlo by se ti to vyplnit."
            Html.p "Místo té usměvavé a spokojené manažerky, kterou jsem si vysnila, jsem se cítila vyčerpaná a naštvaná. Samotná práce mě příliš nenaplňovala a vystresovaní nadřízení pro mě byli spíše odstrašujícím příkladem." 
            Html.p "Po mateřské jsem se znovu rozhodovala, co chci v životě dělat, hledala jsem svoji vášeň, své poslání. Jóga byla už od dvaceti let, kdy jsem ji v Praze při studiu na vysoké škole objevila, mým velkým koníčkem a já vždy chtěla pomáhat lidem, tak se v té době zrodil úplně bláznivý nápad, stát se lektorkou jógy." 
            Html.p "Vše začalo v roce 2016, kdy jsem se prošla 200HR učitelským kurzem registrovaným pod Yoga Allliance a stala certifikovanou lektorkou jógy.  Od té doby provádím klienty na jejich jógové cestě, pravidelně praktikuji a dál se vzdělávám." 
            Html.p "Skrze jógovou praxi jsem si vyřešila bolesti zad a zbavila se migrén. Zajímala jsem se o principy zdravého pohybu, ale i o přesah fyzické jógové praxe. Když jsem tehdy hovořila o meditacích s mou tehdejší lektorkou, jen se usmála a řekla, že na nějakou meditaci s dvěma malýma dětma můžu zapomenout. Teď už vím, že se mýlila, že meditovat může opravdu každý, i když má pocit, že nemá ani vteřinu volného času." 
            Html.p "V roce 2017 jsem se připojila do meditující skupiny v budhistickém centru Lotos, kde jsem se poprvé dozvěděla o mindfulness (česky „všímavosti“), jejímž hlavním cílem je rozvíjení schopnosti vnímat a uvědomovat si události v přítomném okamžiku." 
            Html.p "Postupně jsem si daleko více začala uvědomovat, kdo jsem, co cítím a co potřebuji." 
            Html.p "„Všímavost“ začala vstupovat do mé jógové praxe a já se stále častěji přistihovala ve chvílích, kdy nevnímám – kdy jedu na autopilota, kdy jsem odpojená od svého těla, kdy překračuji svoje hranice. Všímala jsem si chvil, kdy jsem byla vtažena do kolotoče svých myšlenek a jako naprogramovaný stroj prováděla pozice. Častokrát moje pozornost směřovala spíše ven než dovnitř. Objevovaly se pocity méněcennosti, které vznikaly po porovnávání se s ostatními. A co víc toho, čeho jsem si všímala na jógové podložce, jsem viděla objevovat se i v mém každodenním životě. A nebyla to vůbec příjemná uvědomění, ale díky nim jsem mohla začít svou jógovou praxi a i život opravdu měnit." 
            Html.p "Zároveň jsem si uvědomovala obrovskou hodnotu praxe, při které se mi dařilo se propojovat se svým tělem a vnímat přítomný okamžik, bylo to jako bych objevila poklad, který jsem si přála sdílet."
            Html.p "Jistou úroveň „všímavosti“ má každý z nás, důležité je, že všímavost se dá pomocí jednoduchých technik rozvíjet a prohlubovat." 
            Html.p "Abych si tuto dovednost a znalosti ještě více prohloubila absolvovala jsem roční výcvik a stala se certifikovanou lektorkou Relation Mindfulness, které se zabývá rozvíjením všímavosti nejenom ve vztahu k sobě, ale i ve vztahu k ostatním. Dále jsem čerpala informace a zkušenosti skrze další výcviky, kurzy a především vlastní jógovo-meditační praxi.  Velmi významnou událostí pro mě bylo meditační ústraní, kde jsem měla svůj první vhled a zážitek plného vnímání přítomného okamžiku." 
            Html.p "Tak jak se u mě „všímavost“ rozvíjela, má jógová praxe přecházela do meditace v pohybu, poznatky z jógové podložky začaly víc a víc prostupovat do mého každodenního života a všechno se začalo najednou propojovat."
            Html.p "V roce 2018 jsem založila Mindful yogu® – Vědomou jógu přítomného okamžiku se záměrem pomáhat lidem vědomě prožívat jógovou praxi, přibližovat se přítomnému okamžiku a dostávat se z bytí v hlavě zpátky do těla." 
            Html.p "Během praxe vám pomohu naučit se důvěřovat svému tělu, číst a naslouchat jeho signálům, tak abyste bezpečně poznávali svoje hranice. Povedu vás ven z kolotoče vašich myšlenek zpět do těla, k dechu a pohybu. Naučíte se regulovat své emoce a vytvářet si pauzy pro svobodné rozhodnutí, jak zareagovat." 
            Html.p "Vytvářím prostředí, ve kterém snadno zpomalíte a skrze rozvíjení všímavosti a vracení se k tomu, co se děje tady a teď, se posunete na další stupeň vaší praxe. To vše pak volně začne přecházet do vašeho každodenního života, mimo jógovou podložku a obohacovat ho o větší míru kontroly pozornosti a sebe-uvědomění."  
            Html.p "Provádím jógovou praxí, která vás povede cestou poznávání sama sebe, k prožívání života ve všech jeho barvách - vědomě TADY a TEĎ." 
        ]
    ]