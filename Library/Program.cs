using Library;

List<Book> books = new List<Book>();
List<Member> members = new List<Member>();

books.Add(new Book("C# for beginners", "BillGates", "12345678"));
books.Add(new Book("C# Methods and classes", "Microsoft", "55667778"));

members.Add(new Member(1, "John Smith", "High Street", 0790090090));
members.Add(new Member(2, "Mary Jones", "Garden Road", 0790345666));
// Create new instances of the Member class
// These new members are created using the
// Member constructor in the Members class


// Display all the items in the Book List
foreach (Book book in books)
{
    Console.WriteLine(book.Title);
    Console.WriteLine(book.Author);
    Console.WriteLine(book.ISBN);
}

foreach (Member member in members)
{
    Console.WriteLine(member.MemberId);
    Console.WriteLine(member.Name);
    Console.WriteLine(member.Address);
    Console.WriteLine(member.Phone);

}



