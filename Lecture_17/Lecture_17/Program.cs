using Lecture_17.Data;


// Load data from the database.


var database = new BookContext();


// IEnumerable code.


IEnumerable<Book> booksAsEnumerable = database.Books;

var booksOver50 = booksAsEnumerable.Where(book =>
{
    Console.WriteLine($"Processing: {book.Id}");

    return book.Price > 50;
});

foreach (var book in booksOver50)
    Console.WriteLine(book);


// IQueryable code.


IQueryable<Book> booksAsQueryable = database.Books;

var booksOver50Query = booksAsQueryable.Where(book => book.Price > 50);

foreach (var book in booksAsQueryable)
    Console.WriteLine(book);


Console.ReadKey();