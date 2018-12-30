# System zarz�dzania pokojami gier planszowych.

## Cel
Celem projektu by�o stworzenie systemu do tworzenia pokoi i zarz�dzania dost�pnymi pokojami dla graczy. System pozwala na zalogowanie si� jako unikalny gracz go��. Go�� posiada mo�liwo��  stworzenia pokoju dla wybranej gry. Obecnie system zawiera parametry dla trzech gier : go, szachy, warcaby.  System kontroluje dost�p do pokoju na podstawie ilo�ci graczy.

## Zastosowane wzorce projektowe:

### Wzorce konstrukcyjne :
- Singleton
Zastosowanie wzorca pozwala na utworzenie unikalnej instancji gracza.
- Budowniczy
Zastosowanie wzorca umo�liwia stworzenie pokoju wraz ze zmian� jego parametr�w. Zosta�y utworzone trzy typy budowniczego do r�nych pokoi.

### Wzorce Strukturalne:
-Kompozyt
Wzorzec umo�liwi� stworzenie struktury drzewiastej pokoju. �r�d�em jest instancja gry, kt�ra odpowiada za przechowywanie pokoi. Zadaniem pokoi jest kontrola ilo�ci graczy 

-Fasada
Zastosowanie wzorca umo�liwi�o ukrycie etapu inicjacji (tworzenia) pokoju i kontrolowanie statusu pokoju.
  
### Wzorce Czynno�ciowe:
- Stan
Zastosowanie wzorca umo�liwi�o wyznaczenie dw�ch r�nych stan�w dla pokoju: �otwarty� i �zamkni�ty� oraz jego zmian� za pomoc� ��dania (request).

- Obserwator
Zastosowanie wzorca umo�liwi�o po��czenie obserwatora z pokojem i monitorowanie statusu pokoju.  Dzi�ki temu mo�na reagowa� na zmian� statusu.

