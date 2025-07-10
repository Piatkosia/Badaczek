# Badaczek
Ten projekt ma w założeniu pomóc mi w prowadzeniu badań do pracy magisterskiej, ale też w jakichś późniejszych badaniach. 
Jak nie będę miała słomianego zapału i pomoże komuś też - tym lepiej :) 

# Dodawanie migracji do Identity:

W Visual Studio → Tools → NuGet Package Manager → Package Manager Console

W konsoli wybierz:
Default project: *Badaczek.Identity.Data*

A następnie:

```
Add-Migration NazwaMigracji -Project Badaczek.Identity.Data -StartupProject Badaczek.Identity.Web
Update-Database -StartupProject Badaczek.Identity.Web 

```

Tak, możecie mnie pogryźć, że na razie dałam hasło do bazy w dockercompose, ale no, to do developmpentu na razie, "żeby w ogóle działało", potem będzie zmienione przed pierwszym jakimś deployem gdziekolwiek. 
