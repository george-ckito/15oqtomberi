using _15oqtomberi;

while (true)
{
    Console.WriteLine("choose which program to run: (1,2,3)");
    int choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            davaleba1 davaleba = new davaleba1();
            davaleba.Execute();
            break;
        case 2:
            davaleba2 davaleba2 = new davaleba2();
            davaleba2.Execute();
            break;
        case 3:
            davaleba3 davaleba3 = new davaleba3();
            davaleba3.Execute();
            break;
        default:
            Console.WriteLine("Invalid choice");
            break;
    }
}