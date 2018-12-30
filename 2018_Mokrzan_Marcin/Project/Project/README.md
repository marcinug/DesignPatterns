# System zarzπdzania pokojami gier planszowych.

## Cel
Celem projektu by≥o stworzenie systemu do tworzenia pokoi i zarzπdzania dostÍpnymi pokojami dla graczy. System pozwala na zalogowanie siÍ jako unikalny gracz goúÊ. GoúÊ posiada moøliwoúÊ  stworzenia pokoju dla wybranej gry. Obecnie system zawiera parametry dla trzech gier : go, szachy, warcaby.  System kontroluje dostÍp do pokoju na podstawie iloúci graczy.

## Zastosowane wzorce projektowe:

### Wzorce konstrukcyjne :
- Singleton
Zastosowanie wzorca pozwala na utworzenie unikalnej instancji gracza.
- Budowniczy
Zastosowanie wzorca umoøliwia stworzenie pokoju wraz ze zmianπ jego parametrÛw. Zosta≥y utworzone trzy typy budowniczego do rÛønych pokoi.

### Wzorce Strukturalne:
-Kompozyt
Wzorzec umoøliwi≥ stworzenie struktury drzewiastej pokoju. èrÛd≥em jest instancja gry, ktÛra odpowiada za przechowywanie pokoi. Zadaniem pokoi jest kontrola iloúci graczy 

-Fasada
Zastosowanie wzorca umoøliwi≥o ukrycie etapu inicjacji (tworzenia) pokoju i kontrolowanie statusu pokoju.
  
### Wzorce Czynnoúciowe:
- Stan
Zastosowanie wzorca umoøliwi≥o wyznaczenie dwÛch rÛønych stanÛw dla pokoju: Ñotwartyî i ÑzamkniÍtyî oraz jego zmianÍ za pomocπ øπdania (request).

- Obserwator
Zastosowanie wzorca umoøliwi≥o po≥πczenie obserwatora z pokojem i monitorowanie statusu pokoju.  DziÍki temu moøna reagowaÊ na zmianÍ statusu.

