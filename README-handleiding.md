# ZV_Eindcase_CursusAdmin
Cursus Administration Web Application

Benodigdheden:
Visual Studio 2019
Visual Studio Code
PowerShell
Nodejs

Stap 1: Clone deze repository naar je computer.

------------------------------------------------

Als je de clone geopend hebt met visual studio, ga door naar stap 2b.

Stap 2a: Open visual studio. Open solution ZV_CursusAdmin.sln.

Stap 2b: Bouw de solution. (build)

Stap 3: Start without debugging. Als er een pop-up verschijnt met de vraag om de IIS Express certificate te vertrouwen, kies Yes. Daarna, kies Yes als antwoord op de Security Warning.

Als je de applicatie draait, krijg je een error in de browser, sinds er geen Index is. Ga naar  localhost:44318/api/cursusinstantie  , daar zie je de data.

Als je alleen lege brackets ziet: 

Stap 4: Installeer de database: In solution explorer, open folder view, open de map SQL, open CreateDatabaseWithData.sql. Draai het script. In the pop up, kies local database. Dit zal de server name vullen. Kies Connect.

------------------------------------------------

Stap 5: Open visual studio code en kies open folder: ZVCursusAdminFE, welke gevonden kan worden in de map ZV_CursusAdmin.Web.
ZV_CursusAdmin.Web vind je in de map waar je de solution naar gekloond hebt. (default van visual studio: ~/Source/Repos/ZV_Eindcase_CursusAdmin.)

Stap 6: Als je nodejs nog niet eerder gebruikt hebt op deze machine (anders ga verder met stap 8 ): 
open nodejs in start, een command prompt opent. Voer het volgende commando in:  npm install npm -g

Stap 7: Ga terug naar visual studio code en open een new terminal.

------------------------------------------------

Stap 8:  voer in de terminal in:   npm install 
    trouble shooting: Als npm install op dit punt een error geeft, sluit en heropen visual studio code. Open een terminal en voer opnieuw het commando  npm install  in.

Stap 9: In de terminal voer het volgende commando uit:  npm install -g @angular/cli

Stap 10: In de terminal voer het volgende commando uit:  ng serve 
    trouble shooting: Als de volgende error verschijnt :"file ... cannot be loaded because running scripts is disabled on this system", open PowerShell als administrator.
    De execution policy for LocalMachine zou RemoteSigned moeten zijn. Als je dit wil checken voer het volgende commando uit:  Get-ExecutionPolicy -List 
    Om de ExecutionPolicy te veranderen, voer het volgende commando uit:  Set-ExecutionPolicy -ExecutionPolicy RemoteSigned -Scope LocalMachine 
    Voer nogmaals het commando  ng serve  uit.

Stap 11: Als ng serve draait , ga naar de browser en open de localhost die in de terminal staat. Default= localhost:4200


