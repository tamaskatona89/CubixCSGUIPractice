# CubixCSGUIPractice
Cubix Institute of Technology - CSharp &amp; DotNet Basics Course - 10th Week - 4 CS GUI Practice
# 1. Gombvadászat
### Készítsünk WinForms alkalmazást az űrlapon megjelenített gomb „elkapásához” <br/>
* A játék az első gomb kattintás hatására induljon <br/>
* A gombra kattintva a gomb felirata az eddigi elkapások számát mutassa<br/>
* Minden elkapásnál új véletlenszerű pozícióba ugorjon a gomb<br/>
* Ha nem kaptuk el a gombot, egy bizonyos idő elteltével akkor is ugorjon<br/>
* Minden elkapás után csökkenjen a következő elugrásig hátralevő idő<br/>
# 2. Animált gomb
### Készítsünk WPF-ben egyszerű gomb animációt <br/>
* Helyezzünk el egy gombot az űrlapon<br/>
* Ha az egérkurzort a gomb fölé húzzuk, a gomb kerete kezdjen el vastagodni<br/>
* Ha a gombra kattintunk forduljon el a gombunk 15 fokkal<br/>
* Ha az egérkurzort levisszük a gomb fölül, a keret álljon vissza eredeti állapotába<br/>
# 3. Visszaszámlálás dll
### Készítsünk osztály könyvtárat „Visszaszamlalas” néven<br/>
* A dll tartalmazzon egy osztályt, ennek konstruktora egy dátumot vár<br/>
* Rendelkezzen egy „MennyiMeg” metódussal, ami visszaad a „Vakáció!” szóból egy részletet<br/>
	- Ha a dátum már elmúlt, akkor „Vakáció!”<br/>
	- Ha a mai dátum és a tárolt dátum között 1 munkanap nap van akkor „akáció!”<br/>
	- Ha a mai dátum és a tárolt dátum között 2 munkanap nap van akkor „káció!”<br/>
	- Ha a fenti logika alapján nincs mit kiírni, akkor „Hol van az még!”<br/>
* Használjuk fel a dll-t egy Core és egy Framework console applikációban is!<br/>
* Hétvégi napokat NE vegyük figyelembe a szó rövidítésénél!<br/>
# 4. WebHello
### Készítsünk weboldalt, látogatóink köszöntésére<br/>
* Az oldal kérje be a látogató nevét egy egyszerű űrlap segítségével<br/>
* A következő lapon köszöntsük a látogatót<br/>
- 0-10 óra között „Jó reggelt”+ név<br/>
- 10-17 óra között „Jó napot” + név<br/>
- 17-24 óra között „Jó estét” + név<br/>
* Az oldal a háttérben készítsen log-ot: txt file-ban tároljuk a látogató nevét <br/>
és a látogatás pontos időpontját<br/>