Opis projektu:
Projekt przedstawia prosty system wypożyczalni sprzętu elektronicznego (np. kamery, laptopy, słuchawki). Umożliwia tworzenie użytkowników, wypożyczanie i zwracanie sprzętu oraz generowanie raportu o stanie systemu.

Struktura projektu:
Projekt został podzielony na trzy części:
Equipment – klasy sprzętu (Gear jako klasa bazowa oraz konkretne typy jak Camera, Laptop, itd.),
Users – użytkownicy (User oraz Student i Employee z różnymi limitami, zrobiłem klase abstrakcyjna User oraz dwie dziedziczące Student i Employee zamiast np enum UserType jako pole obiektowe w klasie nieabstrakcyjnej User aby ułatwić w przyszłości rozbudowe funkcjonalności dla poszczególnych typów użytkowników jeśli będzie tego wymagał system),
Service – logika systemu (Lease – pojedyncze wypożyczenie, Rental – operacje jak wypożyczanie i zwrot).

Kohezja i odpowiedzialność:
sprzęt przechowuje tylko dane o urządzeniach,
użytkownik przechowuje swoje wypożyczenia i limit,
Lease reprezentuje jedno wypożyczenie,
Rental zarządza logiką systemu.
Dzięki temu klasy są spójne i czytelne.

Powiązania między klasami są ograniczone:
Lease łączy użytkownika i sprzęt,
Rental zarządza operacjami,
klasy sprzętu i użytkowników nie znają szczegółów innych części systemu.
Ułatwia to rozwój i modyfikację projektu.

Uzasadnienie podziału:
Podział na Equipment, Users i Service pozwala oddzielić dane od logiki działania systemu. Dzięki temu kod jest bardziej uporządkowany, łatwiejszy do zrozumienia i rozbudowy.
Projekt prezentuje prostą, czytelną implementację systemu wypożyczalni z sensownym podziałem odpowiedzialności i możliwością dalszej rozbudowy.
