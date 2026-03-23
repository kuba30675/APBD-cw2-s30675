using APBD_cw2_Rental.Service;
using APBD_cw2_Rental.Equipment;
using APBD_cw2_Rental.Users;

        //1. Tworzenie sprzętu
        var camera = new Camera("CMOS", 24.5, "Canon", "EOS R6", 50);
        var laptop = new Laptop(16, "Intel i7", "ThinkPad", "Lenovo", 70);
        var headphones = new Headphones(true, true, "WH-1000XM5", "Sony", 20);
        var mic = new Microphone("Cardioid", -42, "NT1-A", "Rode", 25);
        var phone = new Phone(4000, 6.5, true, "Galaxy S21", "Samsung", 30);

        //2. Tworzenie użytkowników
        var student = new Student("Jan", "Kowalski");
        var employee = new Employee("Anna", "Nowak");

        //3. Wyświetlenie sprzętu
        Console.WriteLine("=== ALL EQUIPMENT ===");
        Rental.ShowAllEquipment();

        Console.WriteLine("\n=== AVAILABLE EQUIPMENT ===");
        Rental.ShowAvailableEquipment();

        //4. Wypożyczenia
        Console.WriteLine("\n=== RENTING EQUIPMENT ===");

        Rental.Rent(student, camera, 3);
        Rental.Rent(student, laptop, 2);

        // Próba przekroczenia limitu (student ma limit 2)
        Rental.Rent(student, headphones, 2);

        // Employee ma większy limit
        Rental.Rent(employee, headphones, 5);
        Rental.Rent(employee, mic, 4);

        //5. Wyświetlenie dostępności
        Console.WriteLine("\n=== AVAILABLE AFTER RENT ===");
        Rental.ShowAvailableEquipment();

        //6. Symulacja upływu czasu
        Console.WriteLine("\n=== SIMULATING TIME ===");

        foreach (var lease in Rental.AllLeases)
        {
            lease.DaysCurrently = lease.LeasedFor + 2; // wszyscy spóźnieni
        }

        //7. Zwrot sprzętu
        Console.WriteLine("\n=== RETURNS ===");

        foreach (var lease in Rental.AllLeases)
        {
            if (!lease.IsReturned)
            {
                double cost = Rental.Return(lease);
                Console.WriteLine($"Lease {lease.Id} returned. Cost: {cost}");
            }
        }

        //8. Raport końcowy
        Console.WriteLine("\n=== FINAL REPORT ===");
        Rental.Report();

        //9. Info o użytkownikach
        Console.WriteLine("\n=== USER INFO ===");

        student.DisplayCurrentLeases();
        student.DisplayPastDeadlineLeases();

        employee.DisplayCurrentLeases();
        employee.DisplayPastDeadlineLeases();
    