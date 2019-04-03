# Theme: TaxiDispatch - SA version

# Team members
* Arslan Turkšić 
* Faris Mušić 
* Medin Paldum

# Project description
TaxiDespatch je aplikacija koja korisnicima omogućava jednostvno i brzo pozivanje, kao i naručivanje taksija uz minimalno vrijeme čekanja. Zaboravite na probleme svakodnevnice, gdje čekanje izaziva testiranje Vašeg strpljenja do krajnjih granica, ili čak nedolazak vozila nakon poziva.

Cilj aplikacije je olakašavanje i unapređenje odnosa klijenata i taksista, te odstranjivanje problema i komplikacija usljed grešaka nastalih zbog čovjekovih previda u ulozi dispečera. Nudi intuitivan interfejs, kako klijentu, tako i taksisti, i omogućava uspotavu njihove veze kroz par sekundi, uz samo nekoliko dodira ekrana.

TaxiDispatch pronalazi najbolje pozicioniranog vozača za obavaljanje datog posla, te minimizira troškove taxi kompanije. Omogućava bolju koordinaciju vozača, kao i iskoristivost njihovog vremena. Jednostavno, olakšava njihov posao.

Korisnik više nikada neće biti primoran na bespotrebno čekanje usljed loše organizacije, niti obavaljati veliki broj poziva kako bi dobio uslugu.

Bilo kada, bilo gdje, TaxiDispatch Vas vodi vašem cilju!

# Processes
## Registracija klijenta

Kako bi klijentu bile na raspolaganju funkcionalnosti i prednosti aplikacije TaxiDispatch, potrebno je da kreira svoj račun putem registracije. Dužan je dostaviti sljedeće informacije:
* Ime
* Prezime
* Broj lične karte
* Datum rođenja
* Spol
* E-mail
* Username
* Password

## Zahtjev za registraciju novog vozača

Bilo koja osoba koja želi da obavlja ulogu taksi vozača mora kreirati korisnički račun na TaxiDispatch aplikaciji. Prije svega, dužan je podnijeti zahtjev za upis u evidenciju, koju provjerava i, po potrebi, odobrava admin. Zahtjev uključuje ispunjavanje formulara sa potrebnim informacijama:

* Ime
* Prezime
* Jedinstveni matični broj (JMBG)
* ID licence
* Datum rođenja
* Broj ugovora


## Registracija vozača

Ukoliko je admin odobrio registraciju datog vozača, koji je naravno prethodno dobio posao i shodno potpisao ugovor o radu, od novog uposlenika se očekuje vjerodostojan unos podataka:

* Adresa stanovanja
* E-mail
* Kontakt telefon
* Broj transakcijskog računa
* Govorni jezici
* Registracioni broj vozila
* Marka vozila
* Model vozila
* Boja vozila
* European emission standard vozila
* Broj sjedišta vozila
* Username
* Password

## Brisanje i suspenzija uposlenika

U slučaju kada bilo koji vozač, bilo zbog nemarne vožnje, kazni zbog saobraćajnih prekršaja ili općeg nezadovoljstva korisnika, bude smatran za nereprezentativnog člana kompanije, ostavljena je mogućnost njegove suspenzije. Ona uključuje blokiranje računa na određeno vrijeme, ili, u ekstremnim slučajevima, brisanje računa, ukoliko je riječ o otkazu.

## Zahtjev

Pri podnošenju zahtjeva za taksi usluge, od korisnika se očekuje da unese:
* Potreban broj mjesta u vozilu
* Maksimalno vrijeme koje može čekati na dolazak vozila

Sama lokacija klijenta se određuje uz pomoć lociranja njegovog uređaja. Nakon toga, algoritmom se pronalaze najbliži slobodni vozači, koji naravno imaju odgovarajući broj slobodnih mjesta. TaxiDispatch sastavlja listu najpogodnijih taksista za tu svrhu, te ih automatski obavještavaju o zahtjevu u vidu notifikacije koju mogu prihvatiti ili odbiti. Ukoliko jedan vozač prihvati zathjev, ostalim se gasi ta mogućnost, kako bi se izbjegla kolizija. Taksista koji je preuzeo posao vidi lokaciju klijenta.  


